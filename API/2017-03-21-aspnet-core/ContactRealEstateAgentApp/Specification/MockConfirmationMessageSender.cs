using Application.Interfaces;

namespace Specification
{
	internal class MockConfirmationMessageSender : IConfirmationMessageService
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