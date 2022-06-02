using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SocketIOClient;


namespace formjdrppe
{
    public partial class chat : Form
    {
        public static string message;
        private static SocketIO socket;


        public delegate void Connect() ;
        public delegate void AddMessage(String message);
        public AddMessage addMessage;


        public chat()
        {
            Uri uri = new Uri("http://localhost:8080/");

            

            if (global.token == "")
            {
                this.Close();
                connexion cnx = new connexion();
                cnx.ShowDialog();
            }
            else
            {
                InitializeComponent();
                socket = new SocketIO(uri, new SocketIOOptions
                {
                    Query = new Dictionary<string, string>
                            {
                                {"token", global.token }
                            },
                });



                //socket.On("connection", response =>
                //    {
                //        message = response.ToString();
                //        if (message != "" && message != null)
                //        {
                //            Invoke(this.addMessage, new object[] { message });
                //        }
                //    });

                //;
                ConnectMethod();
                socket.On("connected", response =>
                {
                    message = response.ToString();
                    if (message != "" && message != null)
                    {
                        Invoke(this.addMessage, new object[] { message });
                    }

                });


                

            }

            
        }
        private void chat_Load(object sender, EventArgs e)
        {
            

            
            addMessage = new AddMessage(AddMessageMethod);
            socket.On("message", response =>
            {
                message = response.ToString();
                if (message != "" && message != null)
                {
                    Invoke(this.addMessage, new object[] { message });
                }
            });

        }



        public static async void ConnectMethod()
        {
            await socket.ConnectAsync();

            int id_room = 1;
            await socket.EmitAsync("enter_room", id_room);
            

        }


        public void AddMessageMethod(String message)
        {
            listBoxMessage.Items.Add(message.Replace("[","").Replace("]","").Replace("\"",""));
        }

        public static async void SendMsg(string message)
        {
            //string username = global.charaName;
            //if (username == "" || username == null)
            //{
            //    username = global.user;
            //}
            //await socket.ConnectAsync();
            object[] data = new object[] { message };
            await socket.EmitAsync("message", data);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            string msg = textBoxSending.Text;
            SendMsg(msg);
        }

        private void textBoxSending_TextChanged(object sender, EventArgs e)
        {

        }

        private void chat_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }

}
