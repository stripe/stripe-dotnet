// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// This is an object representing financing that has been accepted by a merchant.
    /// </summary>
    public class AcceptedFinancing : StripeEntity<AcceptedFinancing>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("accepted_advance_amount")]
        public long AcceptedAdvanceAmount { get; set; }

        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime AcceptedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("accepted_premium_amount")]
        public long AcceptedPremiumAmount { get; set; }

        [JsonProperty("accepted_withhold_rate")]
        public decimal AcceptedWithholdRate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("financing_type")]
        public string FinancingType { get; set; }

        [JsonProperty("is_refill")]
        public bool IsRefill { get; set; }

        [JsonProperty("merchant")]
        public string Merchant { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}
