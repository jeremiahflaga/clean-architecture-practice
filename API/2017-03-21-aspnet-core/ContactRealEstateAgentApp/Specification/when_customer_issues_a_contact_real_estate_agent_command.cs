using Domain;
using System;
using System.Linq;
using Xunit;

namespace Specification
{
	public class when_customer_issues_a_contact_real_estate_agent_command
	{
		House houseTheCustomerWants;

		public when_customer_issues_a_contact_real_estate_agent_command()
		{
			houseTheCustomerWants = new House();
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
			MockConfirmationMessageSender mockConfirmationSender = new MockConfirmationMessageSender();
			
			SalesLead salesLead = new SalesLead(mockConfirmationSender)
			{
				Name = "Jboy Flaga",
				Email = "jboyflaga@example.com",
				PhoneNumber = "09090909090"
			};

			// act
			houseTheCustomerWants.RegisterSalesLead(salesLead);

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
			MockConfirmationMessageSender mockConfirmationSender = new MockConfirmationMessageSender();
			IConfirmationMessageSender confirmationSender = mockConfirmationSender;

			SalesLead salesLead = new SalesLead(confirmationSender)
			{
				Name = "Jboy Flaga",
				Email = "jboyflaga@example.com",
				PhoneNumber = "09090909090"
			};

			//act
			salesLead.SendConfirmationMessage("message of confirmation");

			//assert
			Assert.True(mockConfirmationSender.messageIsSent);
			Assert.Equal("message of confirmation", mockConfirmationSender.sentMessage);
		}
	}
}
