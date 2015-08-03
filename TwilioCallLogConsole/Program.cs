using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;

namespace TwilioCallLogConsole
{
    public class Program
    {
        public void Main(string[] args)
        {
            // Instanciate a new Twilio Rest Client
            var client = new TwilioRestClient("your-twilio-account-sid", "your-twilio-auth-token");
            
            // Select all calls from my account
            var calls = client.ListCalls(new CallListRequest()).Calls;
            
            // Loop through them and show information
            foreach(var call in calls){
                var detail = String.Format("From: {0}, Day: {1}, Duration: {2}s", call.From, call.DateCreated, call.Duration);
                Console.WriteLine(detail);
            }
        }
    }
}
