using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Cinema_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        private Thread listenThread;
        private TcpListener tcpListener;
        private bool stopChatServer = true;
        private readonly int _serverPort = 8080;
        private Dictionary<string, TcpClient> dict = new Dictionary<string, TcpClient>();

        public void Listen()
        {
            try
            {
                //1. new and start a tcpListener
                

                while (!stopChatServer)
                {
                    //1.1. create a TcpClient = tcpListener.AcceptTcpClient()


                    //2. create a streamReader and StreamWriter; getStream from tcplient in step 1


                    //3. Using streamreader read stream to get username which is sent by client.
                    //string username = ;

                    //4. check if username exists by dictionary.containskey(username)


                         //4.1 if username exists using streamwriter to write message username already exists to client.



                         //4.2 if username not exists: add username into dictionary (dict variable) then create and start a thread to handle client receive data.
                    



                }
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(sockEx.Message);
            }
        }

        private delegate void SafeCallDelegate(string text);

        public void UpdateChatHistorySafeCall(string text)
        {
            if (logMsgBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistorySafeCall);
                logMsgBox.Invoke(d, new object[] { text });
            }
            else
            {
                if (text[text.Length - 1] == '\n')
                {
                    logMsgBox.Text += text;
                }
                else
                {
                    logMsgBox.Text += text + "\n";
                }
            }
        }
        //the function is called after start a thread in step 4.2
        public void ClientRecv(string username, TcpClient tcpClient)
        {
            //5. create a streamReader and getstream from tcpClient
          

            while (!stopChatServer)
            {

                //6. using ReadLine() from streamReader to read content of tream
                
                
                
                foreach (TcpClient otherClient in dict.Values)
                {
                    //7. using streamwriter to send data to other clients
                    
                }

                //8. call UpdateChatHistorySafeCall function to update ui with the msg
               
            }
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            if (stopChatServer)
            {
                stopChatServer = false;
                //0. create a listerThread
                //listenThread = new Thread(new ThreadStart(Listen));
                //listenThread.Start();
                //MessageBox.Show("Listening...");

                listenButton.Text = @"Stop";
            }
            else
            {
                stopChatServer = true;

                tcpListener.Stop();
                listenThread = null;
                listenButton.Text = @"Listen";
            }
        }
    }
}
