using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
	public class StripeCharge
	{
	    public StripeCharge()
	    {
	        Metadata = new Dictionary<string, string>(10);
	    }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("amount_refunded")]
		public int? AmountInCentsRefunded { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

        // Do not add JsonProperty as this is managed by the InternalCustomer field
		public string CustomerId { get; private set; }
        // Do not add JsonProperty as this is managed by the InternalCustomer field
        public StripeCustomer Customer { get; private set; }

	    [JsonProperty("customer")]
	    internal object InternalCustomer
	    {
            get { return Customer; }
	        set
	        {
	            if (value is JObject)
	            {
	                Customer = ((JToken) value).ToObject<StripeCustomer>();
	                CustomerId = Customer.Id;
	            }
	            else
	            {
                    CustomerId = value == null ? string.Empty : value.ToString();
	                Customer = null;
	            }
	        }
	    }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("paid")]
		public bool? Paid { get; set; }

		[JsonProperty("refunded")]
		public bool? Refunded { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("card")]
		public StripeCard StripeCard { get; set; }

        // Do not add JsonProperty as this is managed by the InternalInvoice field
		public string InvoiceId { get; private set; }
        // Do not add JsonProperty as this is managed by the InternalInvoice field
        public StripeInvoice Invoice { get; private set; }

	    [JsonProperty("invoice")]
	    internal object InternalInvoice
	    {
	        get { return Invoice; }
	        set
	        {
                if (value is JObject)
                {
                    Invoice = ((JToken)value).ToObject<StripeInvoice>();
                    InvoiceId = Invoice.Id;
                }
                else
                {
                    InvoiceId = value == null ? string.Empty : value.ToString();
                    Invoice = null;
                }
	        }
	    }

		[JsonProperty("failure_message")]
		public string FailureMessage { get; private set; }

		[JsonProperty("failure_code")]
		public string FailureCode { get; private set; }

		[JsonProperty("captured")]
		public bool? Captured { get; set; }

        /// <summary>
        /// Stripe only allows 10 kvps
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
	}
}