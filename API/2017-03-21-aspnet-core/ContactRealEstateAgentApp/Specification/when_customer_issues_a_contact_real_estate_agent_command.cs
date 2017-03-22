using Domain;
using System;
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
		}


		[Fact]
		public void then_system_should_register_a_new_sales_lead()
		{
			// arrange
			SalesLead salesLead = new SalesLead
			{
				Name = "Jboy Flaga",
				Email = "jboyflaga@example.com",
				PhoneNumber = "09090909090"
			};

			// act
			houseTheCustomerWants.RegisterSalesLead(salesLead);

			// assert
			Assert.Equal(1, houseTheCustomerWants.GetSalesLeads().Count);
			SalesLead newlyAddedSalesLead = houseTheCustomerWants.GetSalesLeads()[0];
			Assert.Equal("Jboy Flaga", newlyAddedSalesLead.Name);
			Assert.Equal("jboyflaga@example.com", newlyAddedSalesLead.Email);
			Assert.Equal("09090909090", newlyAddedSalesLead.PhoneNumber);
		}
	}
}
