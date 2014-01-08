using System.Collections.Generic;

using Newtonsoft.Json;
namespace Stripe
{
	public class StripeInvoiceItemCreateOptions
	{
	    public StripeInvoiceItemCreateOptions()
	    {
            Metadata = new Dictionary<string, string>(10);
	    }

		[JsonProperty("amount")]
		public int AmountInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("invoice")]
		public string InvoiceId { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Stripe only allows 10 kvps
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
	}
}