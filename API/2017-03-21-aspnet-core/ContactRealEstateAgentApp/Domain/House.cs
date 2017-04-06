using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class House
	{
		public Guid Id { get; private set; }

		public House() 
			: this(Guid.NewGuid()) 
		{}

		public House(Guid id)
		{
			this.Id = Guid.NewGuid();
		}

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
