namespace Argos.Summa.Dto
{
	public class Response
	{
        public object? Data { get; set; }
        public string? Message { get; set; }

        public Response()
        {
            Message = "Something went wrong...";
        }
    }
}
