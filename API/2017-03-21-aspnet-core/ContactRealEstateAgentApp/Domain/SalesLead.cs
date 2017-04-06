using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class SalesLead
	{
		private IConfirmationMessageSender confirmationMessageSender;

		public SalesLead(IConfirmationMessageSender confirmationMessageSender)
		{
			this.confirmationMessageSender = confirmationMessageSender;
		}

		public string Name { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }

		public void SendConfirmationMessage(string message)
		{
			this.confirmationMessageSender.SendMessage(message);
		}
	}
}
