namespace Domain
{
	public interface IConfirmationMessageSender
	{
		void SendMessage(string message);
	}
}