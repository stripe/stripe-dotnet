namespace Stripe
{
	internal static class Urls
	{
		public static string Invoices
		{
			get { return BaseUrl + "/invoices"; }
		}

		public static string InvoiceItems
		{
			get { return BaseUrl + "/invoiceitems"; }
		}

		public static string Tokens
		{
			get { return BaseUrl + "/tokens"; }
		}

		public static string Charges
		{
			get { return BaseUrl + "/charges"; }
		}

		public static string Coupons
		{
			get { return BaseUrl + "/coupons"; }
		}

		public static string Plans
		{
			get { return BaseUrl + "/plans"; }
		}
		
		public static string Customers
		{
			get { return BaseUrl + "/customers"; }
		}

		public static string Events
		{
			get { return BaseUrl + "/events"; }
		}

		private static string BaseUrl
		{
			get { return "https://api.stripe.com/v1"; }
		}
	}
}
