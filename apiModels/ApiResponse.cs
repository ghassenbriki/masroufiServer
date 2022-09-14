namespace masroufiServer.apiModels
{
    public class ApiResponse<T>
        where T : new()
    {
    
        public T? Response { get;  set; }
        public List<string> errorMessages { get; private set; }

        public bool success => errorMessages.Count == 0;

        

        public ApiResponse()

        {
           errorMessages = new List<string>();

        }

    
    }
}
