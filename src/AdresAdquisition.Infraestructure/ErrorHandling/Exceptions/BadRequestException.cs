namespace AdresAdquisition.Infraestructure.ErrorHandling.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message) { }
    }
}
