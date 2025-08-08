namespace EducationalPlatform.API.Responses
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "OK";
        public T Data { get; set; }

        public ApiResponse(T data)
        {
            Data = data;
        }
    }

}
