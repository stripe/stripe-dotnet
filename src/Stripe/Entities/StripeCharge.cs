using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeCharge : StripeObject
	{
		[JsonProperty("amount")]
		public int? Amount { get; set; }

		[JsonProperty("amount_refunded")]
		public int? AmountRefunded { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }
		
		public string CustomerId { get; set; }
		public StripeCustomer Customer { get; set; }

		[JsonProperty("customer")]
		internal object InternalCustomer
		{
			set
			{
				if (value is JObject)
					Customer = Mapper<StripeCustomer>.MapFromJson(value.ToString());
				else
					CustomerId = value == null ? null : value.ToString();
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

		public string InvoiceId { get; set; }
		public StripeInvoice Invoice { get; set; }

		[JsonProperty("invoice")]
		internal object InternalInvoice
		{
			set
			{
				if (value is JObject)
					Invoice = Mapper<StripeInvoice>.MapFromJson(value.ToString());
				else
					InvoiceId = value == null ? null : value.ToString();
			}
		}

		[JsonProperty("failure_message")]
		public string FailureMessage { get; private set; }

		[JsonProperty("failure_code")]
		public string FailureCode { get; private set; }

		[JsonProperty("captured")]
		public bool? Captured { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}