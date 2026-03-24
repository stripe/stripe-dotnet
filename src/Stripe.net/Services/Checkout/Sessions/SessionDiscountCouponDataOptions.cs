// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionDiscountCouponDataOptions : INestedOptions, IHasMetadata, IHasSetTracking
    {
        private Dictionary<string, string> metadata;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// A positive integer representing the amount to subtract from an invoice total (required
        /// if <c>percent_off</c> is not passed).
        /// </summary>
        [JsonProperty("amount_off")]
        [STJS.JsonPropertyName("amount_off")]
        public long? AmountOff { get; set; }

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// of the <c>amount_off</c> parameter (required if <c>amount_off</c> is passed).
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Specifies how long the discount will be in effect if used on a subscription. Defaults to
        /// <c>once</c>.
        /// One of: <c>forever</c>, <c>once</c>, or <c>repeating</c>.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Name of the coupon displayed to customers on, for instance invoices, or receipts. By
        /// default the <c>id</c> is shown if <c>name</c> is not set.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A positive float larger than 0, and smaller or equal to 100, that represents the
        /// discount the coupon will apply (required if <c>amount_off</c> is not passed).
        /// </summary>
        [JsonProperty("percent_off")]
        [STJS.JsonPropertyName("percent_off")]
        public decimal? PercentOff { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
