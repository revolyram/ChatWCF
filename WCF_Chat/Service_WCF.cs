using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace WCF_Chat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service_WCF : IService_WCF
    {
        /// <summary>
        /// Список юзеров
        /// </summary>
        List<User> users = new List<User>();
        /// <summary>
        /// Уникальный номер
        /// </summary>
        static int id = 1;
        /// <summary>
        /// Метод подключения
        /// </summary>
        public int Connect(string name)
        {
            User user = new User()
            {
                IdU = id,
                Name = name,
                operationContext = OperationContext.Current
            };
            id++;
            Smsg(user.Name + " подключился к чату!", 0);
            users.Add(user);
            return user.IdU;
        }

        /// <summary>
        /// Метод отключения
        /// </summary>
        public void DisConnect(int id)
        {
            var u = users.FirstOrDefault(i => i.IdU == id);
            if (u != null)
            {
                users.Remove(u);
                Smsg(u.Name + " покинул чат!", 0);
            }
        }

        /// <summary>
        /// Метод отправки сообщения
        /// </summary>
        public void Smsg(string msg, int id)
        {
            foreach (var item in users)
            {
                string s = DateTime.Now.ToShortTimeString();
                var u = users.FirstOrDefault(i => i.IdU == id);
                if (u != null)
                {
                    s += ": " + u.Name;
                }
                s += " " + msg;
                item.operationContext.GetCallbackChannel<ICallBack>().CallBackMSG(s);
            }
        }
    }
}
