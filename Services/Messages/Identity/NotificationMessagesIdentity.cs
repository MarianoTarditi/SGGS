namespace ServiceLayer.Messages.Identity
{
    public static class NotificationMessagesIdentity
    {
        private const string UserEditSuccess = " ¡Ha sido Actualizado!";
        private const string SignUpSuccess = " ¡Ha sido Creado!";

        public const string LogInSuccess = "¡Has iniciado sesión correctemente!";
        public const string PasswordResetSuccess = "Hemos enviado un link a su email para reestablecer la contraseña.";
        public const string TokenValidationError = "Su token no es válido. Porfavor, intentelo de nuevo";
        public const string UserError = "¡El usuario no existe!";
        public const string PasswordChangeSuccess = "Se ha cambiado su contraseña. Por favor, inicie sesión.";

        public const string SuccessedTitle = "¡Felicitaciones!";
        public const string FailedTitle = "¡Lo sientimos!";

        public const string ExtendClaimSuccess = "¡El usuario tiene 5 días más!";
        public const string ExtendClaimFailed = "¡El método de extensión del usuario está fallando!";

        public static string SignUp(string userName) => userName + SignUpSuccess;
        public static string UserEdit(string userName) => userName + UserEditSuccess;

        public static string UpdateUserRole(string userName) => userName + UserEditSuccess;




    }
}
