using Application.Interfaces;
using Application.SalesLead.RegisterSalesLead;
using Domain;
using System;
using System.Linq;
using Xunit;

namespace Specification
{
	public class when_customer_issues_a_contact_real_estate_agent_command
	{
		House houseTheCustomerWants;
		MockConfirmationMessageSender mockConfirmationSender;
		MockHouseRepository mockHouseRepository;


		public when_customer_issues_a_contact_real_estate_agent_command()
		{
			houseTheCustomerWants = new House();
			mockConfirmationSender = new MockConfirmationMessageSender();
			mockHouseRepository = new MockHouseRepository(houseTheCustomerWants);
		}


		[Fact]
		public void then_system_validates_all_data()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void then_system_should_register_a_new_sales_lead()
		{
			// arrange
			RegisterSalesLeadModel salesLeadModel = new RegisterSalesLeadModel()
			{
				HouseId = houseTheCustomerWants.Id,

				SalesLeadName = "Jboy Flaga",
				SalesLeadEmail = "jboyflaga@example.com",
				SalesLeadPhoneNumber = "09090909090",

				ConfirmationMessage = "message of confirmation"
			};

			RegisterSalesLeadCommand registerSalesLeadCommand = new RegisterSalesLeadCommand(mockHouseRepository, mockConfirmationSender);

			// act
			registerSalesLeadCommand.RegisterSalesLead(salesLeadModel);

			// assert
			Assert.Equal(1, houseTheCustomerWants.RegisteredSalesLeads.Count());
			SalesLead newlyAddedSalesLead = houseTheCustomerWants.RegisteredSalesLeads.Single();
			Assert.Equal("Jboy Flaga", newlyAddedSalesLead.Name);
			Assert.Equal("jboyflaga@example.com", newlyAddedSalesLead.Email);
			Assert.Equal("09090909090", newlyAddedSalesLead.PhoneNumber);
		}
		
		[Fact]
		public void then_system_should_confirm_to_the_user_that_his_request_has_been_processed()
		{
			// arrange
			RegisterSalesLeadModel salesLeadModel = new RegisterSalesLeadModel()
			{
				HouseId = houseTheCustomerWants.Id,

				SalesLeadName = "Jboy Flaga",
				SalesLeadEmail = "jboyflaga@example.com",
				SalesLeadPhoneNumber = "09090909090",

				ConfirmationMessage = "message of confirmation"
			};

			RegisterSalesLeadCommand registerSalesLeadCommand = new RegisterSalesLeadCommand(mockHouseRepository, mockConfirmationSender);

			//act
			registerSalesLeadCommand.RegisterSalesLead(salesLeadModel);

			//assert
			Assert.True(mockConfirmationSender.messageIsSent);
			Assert.Equal("message of confirmation", mockConfirmationSender.sentMessage);
		}
	}
}
