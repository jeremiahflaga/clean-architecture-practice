namespace Application.SalesLead.RegisterSalesLead
{
	public class RegisterSalesLeadModel
	{
		public int HouseId { get; set; }

		public string SalesLeadName { get; set; }
		public string SalesLeadEmail { get; set; }
		public string SalesLeadPhoneNumber { get; set; }

		public string ConfirmationMessage { get; set; }
	}
}
