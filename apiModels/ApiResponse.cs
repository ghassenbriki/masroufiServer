namespace masroufiServer.apiModels
{
    public class ApiResponse
        
    {
    
        public List<string> errorMessages { get; private set; }

        public bool success => errorMessages.Count == 0;

       
        public ApiResponse()

        {
           errorMessages = new List<string>();

        }

    
    }
    //we can make two classes with same name
    public class APIResponse<T> : ApiResponse
       where T : new()
    {
        
        public T? Response { get; set; }

    }
}
