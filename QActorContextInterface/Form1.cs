using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QActorContextInterface
{
    public partial class Form1 : Form
    {
        TcpClient client;
        public Form1()
        {
            InitializeComponent();
            btnSend2.Enabled = btnSend.Enabled = false;

            if (File.Exists("commands.txt"))
            {
                cmbMessage.Items.AddRange(File.ReadAllLines("commands.txt"));
            }
        }

        private int id = 1;
        private void AddOutput(string val)
        {
            lstOutput.Items.Add(val);
            int nItems = (int)(lstOutput.Height / lstOutput.ItemHeight);
            lstOutput.TopIndex = lstOutput.Items.Count - nItems;
        }
        private void Read()
        {
            string v = "";
            while (true)
            {
                try
                {
                    while (!v.Contains("\n"))
                    {
                        byte[] buffer = new byte[1024];
                        int read = client.GetStream().Read(buffer, 0, 1024);
                        v += Encoding.UTF8.GetString(buffer, 0, read);
                    }

                    int col = v.IndexOf('\n');
                    string msg = v.Substring(0, col);
                    lstOutput.Invoke(new MethodInvoker(delegate ()
                    {
                        AddOutput(msg);
                    }));
                    if (v.Length > col + 1)
                    {
                        v = v.Substring(col + 1, v.Length - col - 1);
                    }
                    else
                    {
                        v = "";
                    }
                }
                catch
                {
                    v = "";
                }
            }
        }

        Thread readT;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                try
                {
                    IPEndPoint target = new IPEndPoint(IPAddress.Parse(txbIPAddress.Text), int.Parse(txbPort.Text));

                    client = new TcpClient();
                    client.Connect(target);
                    btnSend2.Enabled = btnSend.Enabled = true;
                    btnConnect.Text = "Disconnect";
                    AddOutput("Connected");
                    readT = new Thread(Read);
                    readT.Start();
                }
                catch (Exception ex)
                {
                    AddOutput(ex.Message);
                }
            }
            else
            {
                CloseConnection();
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (readT != null)
                    readT.Abort();
                if (readT != null)
                    client.Close();
            }
            catch { }
            btnSend2.Enabled = btnSend.Enabled = false;
            btnConnect.Text = "Connect";
            client = null;
            AddOutput("Disconnected");
        }

        private void SendMsg(string msg)
        {
            if (!cmbMessage.Items.Contains(msg))
                cmbMessage.Items.Add(msg);

            List<string> commands = new List<string>();
            foreach (var i in cmbMessage.Items)
            {
                commands.Add(i.ToString());
            }
            File.WriteAllLines("commands.txt", commands.ToArray());

            try
            {
                AddOutput("Sent: " + msg);
                byte[] data = Encoding.UTF8.GetBytes(msg + "\n");

                client.GetStream().Write(data, 0, data.Length);
                client.GetStream().Flush();
            }
            catch (Exception ex)
            {
                AddOutput(ex.Message);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = String.Format("msg({0},{1},{2},{3},{4},{5})",
            txbMessageID.Text, cmbMessageType.Text, txbMit.Text, txbDest.Text, txbMessage.Text, id++);
            SendMsg(msg);
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            SendMsg(cmbMessage.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseConnection();
        }
    }
}
