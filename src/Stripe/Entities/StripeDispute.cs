using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeDispute
	{
		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

        // Do not add JsonProperty as this is managed by the InternalCharge field
        public string ChargeId { get; private set; }
        // Do not add JsonProperty as this is managed by the InternalCharge field
        public StripeCharge Charge { get; private set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            get { return Charge; }
            set
            {
                if (value is JObject)
                {
                    Charge = ((JToken)value).ToObject<StripeCharge>();
                    ChargeId = Charge.Id;
                }
                else
                {
                    ChargeId = value == null ? string.Empty : value.ToString();
                    Charge = null;
                }
            }
        }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("evidence_due_by")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? EvidenceDueBy { get; set; }

		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("evidence")]
		public string Evidence { get; set; }
	}
}