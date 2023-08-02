namespace AnticoWebApi.DataWrappers
{
    public class DataResult
    {
        public bool success { get; set; }
        public IEnumerable<object> data { get; set; }
        public string message { get; set; } 
        public DataResult(bool success, IEnumerable<object> data)
        {
            this.success = success;
            this.data = data;
        }

        public DataResult(bool success, string message)
        {
            this.success = success;
            this.message = message;  
        }

        public DataResult(bool success, IEnumerable<object> data, string message) 
        {
            this.message = message;
            this.success = success;
            this.data = data; 
        }
    }
}
