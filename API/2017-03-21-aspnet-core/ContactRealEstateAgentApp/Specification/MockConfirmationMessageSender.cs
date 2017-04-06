using Domain;
using System;

namespace Specification
{
	internal class MockConfirmationMessageSender : IConfirmationMessageSender
	{
		public bool messageIsSent = false;
		public string sentMessage = "";


		public void SendMessage(string message)
		{
			messageIsSent = true;
			sentMessage = message;
		}
	}
}