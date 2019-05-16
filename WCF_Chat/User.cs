using System.ServiceModel;
namespace WCF_Chat
{
    class User
    {
        // Имя пользователя
        public string Name { get; set; }
        // Уникальный номер
        public int IdU { get; set; }
        // Переменная операции
        public OperationContext operationContext { get; set; }
    }
}
