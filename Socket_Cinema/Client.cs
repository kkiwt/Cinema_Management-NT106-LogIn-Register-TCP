
using System.Net.Sockets;
using System.Net;

namespace Socket_Cinema
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private TcpClient tcpClient;
        private string data;
        //private NetworkStream ns;
        private const int serverPort = 8080;
        private Thread clientThread;
        private StreamReader sReader;
        private StreamWriter sWriter;
        private bool stoptcpClient = true;

        private delegate void SafeCallDelegate(string text);
        private void UpdateChatHistorySafeCall(string text)
        {
            if (msgBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistorySafeCall);
                msgBox.Invoke(d, new object[] { text });
            }
            else
            {
                msgBox.Text += text + "\n";
            }
        }

        private void ClientReceive()
        {
            sReader = new StreamReader(tcpClient.GetStream());

            while (!stoptcpClient && tcpClient.Connected)
            {
                // Application.DoEvents();
                string rcvdata = sReader.ReadLine();
                UpdateChatHistorySafeCall(rcvdata);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                stoptcpClient = false;

                tcpClient = new TcpClient();
              
                //1. Create IP endpoint



                //2. Call connect function of TCPClient class


                //3. using streamwrite and tcpClient.GetStream()
                

                //4. using variable sWriter to write username into stream
                

                

                //5. Create new Thread(ClientReceive)

                //6. Start Thread

              

               // MessageBox.Show("Connected");
               //connectButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                data = sendMsgBox.Text;
                //7. using streamwriter to send data (readline function)
                

                sendMsgBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            stoptcpClient = true;
            clientThread = null;
            tcpClient.Close();

            MessageBox.Show("Disconnected.");
        }
    }
}
