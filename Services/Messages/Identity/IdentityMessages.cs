namespace ServiceLayer.Messages.Identity
{
    public static class IdentityMessages
    {
        public const string SecurityStampError = "Su información crítica ha sido cambiada. " +
            "Por favor, intente iniciar sesión nuevamente";

        public static string CheckEmailAddress()
        {
            return "Debe ingresar un email válido.";
        }

        public static string ComparePassword()
        {
            return "Las contraseñas no coinciden.";
        }     
    }
}
