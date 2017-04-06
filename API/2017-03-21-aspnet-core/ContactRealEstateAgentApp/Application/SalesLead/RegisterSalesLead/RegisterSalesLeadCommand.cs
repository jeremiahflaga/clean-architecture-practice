using Application.Interfaces;
using Domain;

namespace Application.SalesLead.RegisterSalesLead
{
    public class RegisterSalesLeadCommand
    {
		private IConfirmationMessageService confirmationMessageService;
		private IHouseRepository houseRepository;

		public RegisterSalesLeadCommand(IHouseRepository houseRepository, IConfirmationMessageService confirmationMessageService)
		{
			this.confirmationMessageService = confirmationMessageService;
			this.houseRepository = houseRepository;
		}

		public void RegisterSalesLead(RegisterSalesLeadModel salesLeadModel)
		{
			House house = houseRepository.GetHouse(salesLeadModel.HouseId);

			Domain.SalesLead salesLead = new Domain.SalesLead
			{
				Name = salesLeadModel.SalesLeadName,
				Email = salesLeadModel.SalesLeadEmail,
				PhoneNumber = salesLeadModel.SalesLeadPhoneNumber
			};

			house.RegisterSalesLead(salesLead);
			confirmationMessageService.SendMessage(salesLeadModel.ConfirmationMessage);
		}
    }
}
