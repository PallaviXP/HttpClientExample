using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RestClient client = new RestClient();
            ArgumentParser parser = new ArgumentParser(args);   
            var output =  client.Execute(parser.GetArguments());       
            Console.WriteLine(); 
            
        }
    }

    public class ArgumentParser
    {
        Request request = new Request();

        string[] _args; 
        public ArgumentParser(string[] args)
        {
            _args = args;     
        } 

        
        public Request GetArguments()
        {
            request.URL = _args[0];
            return request;
        }

    }

    public class Request
    {
        public string URL {  get; set; }
        public RequestType MethodType {  get; set; }
    }

    public enum RequestType
    {
        Get,
    }  
}
