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
			SalesLead salesLead = new SalesLead
			{
				Name = "Jboy Flaga",
				Email = "jboyflaga@example.com",
				PhoneNumber = "09090909090"
			};

			houseTheCustomerWants.RegisterSalesLead(salesLead);

			Assert.Equal(1, houseTheCustomerWants.GetSalesLeads().Count);
		}
	}
}
