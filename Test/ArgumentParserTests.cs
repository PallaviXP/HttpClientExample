using System;
using Xunit;
using Code;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class ArgumentParserTests
    {
        string url = "https://www.google.com";
        [Fact]
        public void ShouldAcceptURL()
        {
           List<string> args = new List<string>() { "https://www.google.com" };
             ArgumentParser parser = new ArgumentParser(args.ToArray());
             Request request = parser.GetArguments();
            Assert.Equal(url, request.URL);
             Assert.Equal(RequestType.Get, request.MethodType);
        }

        /*[Fact]
        public void ShouldAcceptURLAndMethodAsParam()
        {
            List<string> args = { "https://www.google.com", "--Method:GET" };
             ArgumentParser parser = new ArgumentParser(args.ToArray());
             Arguments arg = parser.GetArguments();
            Assert.Equal(url, arg.url);
             Assert.Equal(RequestType.Get, arg.MethodType);
        }

        [Fact]
        public void ShouldAcceptURLAndMAsParam()
        {
           List<string> args = {"https://www.google.com", "--m:GET"};

             ArgumentParser parser = new ArgumentParser(args.ToArray());
             Arguments arg = parser.GetArguments();
            Assert.Equal(url, arg.url);
             Assert.Equal(RequestType.Get, arg.MethodType);
        }*/
    }
}
