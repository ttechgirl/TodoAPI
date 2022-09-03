namespace TodoAPIClass
{
    /*this will pass a response to the user
     indicating that the request is either successful
    or not*/
    public class ResponseModel
    {
        public bool Success { get; set; }
        public string Error { get; set; }
    }
}
