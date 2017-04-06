using Application.Interfaces;

namespace Application.SalesLead.RegisterSalesLead
{
    public class RegisterSalesLeadCommand
    {
		private IConfirmationMessageService confirmationMessageService;

		public RegisterSalesLeadCommand(IConfirmationMessageService confirmationMessageService)
		{
			this.confirmationMessageService = confirmationMessageService;
		}

		public void RegisterSalesLead(RegisterSalesLeadModel salesLeadModel)
		{
			Domain.SalesLead salesLead = new Domain.SalesLead
			{
				Name = salesLeadModel.SalesLeadName,
				Email = salesLeadModel.SalesLeadEmail,
				PhoneNumber = salesLeadModel.SalesLeadPhoneNumber
			};

			confirmationMessageService.SendMessage(salesLeadModel.ConfirmationMessage);
		}
    }
}
