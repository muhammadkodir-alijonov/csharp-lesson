namespace CarShop.Api.Dtos.Common
{
    public class ErrorDto
    {
        public int StatusCode { get; set; }

        public string Message { get; set; } = String.Empty;
    }
}
