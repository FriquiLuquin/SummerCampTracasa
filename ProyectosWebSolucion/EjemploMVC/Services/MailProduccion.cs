namespace EjemploMVC.Services
{
    public class MailProduccion : IMail
    {
        public string EnviarMail()
        {
            return "Correo en produccion enviado";
        }
    }
}
