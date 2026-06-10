// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A TaxFund object represents a single tax float sweep event — funds moved between a
    /// merchant's payments balance and their tax fund financial account for Stripe Tax
    /// obligations.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxFund : StripeEntity<TaxFund>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount swept, in the smallest currency unit. Always positive.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Associated billing or tax documents for this sweep.
        /// </summary>
        [JsonProperty("context")]
        [STJS.JsonPropertyName("context")]
        public TaxFundContext Context { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Where funds moved to.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public TaxFundDestination Destination { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Where funds moved from.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public TaxFundSource Source { get; set; }

        /// <summary>
        /// What caused the sweep.
        /// </summary>
        [JsonProperty("trigger")]
        [STJS.JsonPropertyName("trigger")]
        public TaxFundTrigger Trigger { get; set; }
    }
}
