namespace ServiceLayer.Messages.WebApplication
{
    public static class ValidationMessages
    {
        public static string NullEmptyMessage(string propName)
        {
            return $"{propName} debe terner un valor.";
        }

        public static string MaximumCharachterAllowence(string propName, int resctriction)
        {
            return $"{propName} puede tener maximo {resctriction}";
        }

        public static string GreaterThanMessage(string propName, int restriction)
        {
            return $"{propName} debe ser mayor que {restriction}";
        }

        public static string LessThanMessage(string propName, int restriction)
        {
            return $"{propName} debe ser menor que {restriction}";
        }
    }
}
