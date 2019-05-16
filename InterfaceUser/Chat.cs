using System;
using System.Windows.Forms;

namespace InterfaceUser
{
    public partial class Chat : Form, HostServise.IService_WCFCallback
    {
        /// <summary>
        /// Показатель онлайна
        /// </summary>
        bool online = false;
        HostServise.Service_WCFClient uclient;
        /// <summary>
        /// Уникальный номер юзера
        /// </summary>
        int idUser;
        /// <summary>
        /// Главный метод программы
        /// </summary>
        public Chat()
        {
            InitializeComponent();
            tb_inmsg.ReadOnly = true;
            tb_outmsg.ReadOnly = true;
            tb_inmsg.Enabled = true;
        }

        /// <summary>
        /// Метод подключения
        /// </summary>
        void Connect()
        {
            if (!online)
            {
                tb_outmsg.ReadOnly = false;
                uclient = new HostServise.Service_WCFClient(new System.ServiceModel.InstanceContext(this));
                uclient.DisConnect(idUser);
                idUser = uclient.Connect(tb_name.Text);
                tb_name.ReadOnly = true;
                cdnnect.Text = "Disconnect";
                online = true;
            }
        }

        /// <summary>
        /// Метод отключения
        /// </summary>
        void DisConnect()
        {
            if (online)
            {
                tb_outmsg.ReadOnly = true;
                uclient.DisConnect(idUser);
                uclient = null;
                tb_name.ReadOnly = false;
                cdnnect.Text = "Connect";
                online = false;
            }
        }

        /// <summary>
        /// Метод подключения
        /// </summary>
        private void cdnnect_Click(object sender, EventArgs e)
        {
            if (online)
            {
                DisConnect();
            }
            else
            {
                Connect();
            }
        }

        /// <summary>
        /// Метод возврата сообщения
        /// </summary>
        public void CallBackMSG(string msg)
        {
            tb_inmsg.Text += msg + Environment.NewLine;
        }

        /// <summary>
        /// Метод обработки клавиши Enter
        /// </summary>
        private void Chat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (uclient != null)
                {
                    uclient.Smsg(tb_outmsg.Text, idUser);
                    tb_outmsg.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Метод закрытия формы
        /// </summary>
        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisConnect();
        }
    }
}
