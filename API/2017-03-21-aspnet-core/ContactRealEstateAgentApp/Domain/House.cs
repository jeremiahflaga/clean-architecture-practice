using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class House
	{
		IList<SalesLead> salesLeads = new List<SalesLead>();

		public IEnumerable<SalesLead> RegisteredSalesLeads
		{
			get { return salesLeads; }
		}

		public void RegisterSalesLead(SalesLead salesLead)
		{
			salesLeads.Add(salesLead);
		}		
	}
}
