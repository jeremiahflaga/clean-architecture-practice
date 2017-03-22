using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class House
    {
		IList<SalesLead> salesLeads = new List<SalesLead>();

		public void RegisterSalesLead(SalesLead salesLead)
		{
			salesLeads.Add(salesLead);
		}

		public IList<SalesLead> GetSalesLeads()
		{
			return salesLeads;
		}
	}
}
