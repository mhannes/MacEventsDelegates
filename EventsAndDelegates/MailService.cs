using System;

namespace EventsAndDelegates
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Mailservice: Sending an email...");
        }
    }
}
  