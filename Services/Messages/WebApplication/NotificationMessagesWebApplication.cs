namespace ServiceLayer.Messages.WebApplication
{
    public static class NotificationMessagesWebApplication
    {
        private const string BaseAddMessage = " ¡Ha sido Guardado!";
        private const string BaseUpdateMessage = " ¡Ha sido Actualizado!";
        private const string BaseDeleteMessage = " ¡Ha sido Eliminado!";


        public const string SuccessedTitle = "¡Feliciatciones!";
        public const string FailedTitle = "¡Lo sentimos!";

        public static string AddMessage(string subject) => subject + BaseAddMessage;
        public static string asd(string subject) => subject;

        public static string UpdateMessage(string subject) => subject + BaseUpdateMessage;
        public static string DeleteMessage(string subject) => subject + BaseDeleteMessage;
        

    }
}
