namespace AdresAdquisition.Infraestructure.ErrorHandling.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException(string message) : base(message) { }
    }
}
