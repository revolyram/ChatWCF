using System.ServiceModel;

namespace WCF_Chat
{
    [ServiceContract(CallbackContract = typeof(ICallBack))]
    public interface IService_WCF
    {
        /// <summary>
        /// Метод подключения
        /// </summary>
        [OperationContract]
        int Connect(string name);

        /// <summary>
        /// Метод отключения
        /// </summary>
        [OperationContract]
        void DisConnect(int id);

        /// <summary>
        /// Метод отправки сообщения
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void Smsg(string msg, int id);
    }

    public interface ICallBack
    {
        [OperationContract(IsOneWay =true)]
        void CallBackMSG(string msg);
    }
}
