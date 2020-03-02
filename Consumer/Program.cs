using System;
using Library;

namespace Consumer
{
    public class Program
    {
        static void Main(string[] args)
        {
	        Connect();
        }

        public static void Connect()
        {
	        Connector.Connect();
        }
    }
}
