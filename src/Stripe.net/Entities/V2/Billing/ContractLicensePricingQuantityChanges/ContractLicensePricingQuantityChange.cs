// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A license pricing quantity change object returned by ListContractLicenseQuantityChanges.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractLicensePricingQuantityChange : StripeEntity<ContractLicensePricingQuantityChange>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the quantity change object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The timestamp when this quantity change object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp when this quantity change takes effect.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the license pricing.
        /// </summary>
        [JsonProperty("license_pricing_id")]
        [STJS.JsonPropertyName("license_pricing_id")]
        public string LicensePricingId { get; set; }

        /// <summary>
        /// The type of the license pricing.
        /// One of: <c>license_fee</c>, or <c>price</c>.
        /// </summary>
        [JsonProperty("license_pricing_type")]
        [STJS.JsonPropertyName("license_pricing_type")]
        public string LicensePricingType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The ID of the pricing line associated with this quantity change.
        /// </summary>
        [JsonProperty("pricing_line")]
        [STJS.JsonPropertyName("pricing_line")]
        public string PricingLine { get; set; }

        /// <summary>
        /// The quantity at the effective time.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
