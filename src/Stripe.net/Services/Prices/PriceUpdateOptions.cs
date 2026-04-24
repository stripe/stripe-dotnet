// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PriceUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, PriceCurrencyOptionsOptions> currencyOptions;
        private string externalReference;
        private Dictionary<string, string> metadata;
        private PriceMigrateToOptions migrateTo;

        /// <summary>
        /// Whether the price can be used for new purchases. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Prices defined in each available currency option. Each key must be a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a> and a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("currency_options")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, PriceCurrencyOptionsOptions> CurrencyOptions
        {
            get => this.currencyOptions;
            set
            {
                this.currencyOptions = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A custom identifier for this price, such as a SKU number or product code, that can be
        /// used to reference records from external systems.
        /// </summary>
        [JsonProperty("external_reference", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("external_reference")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ExternalReference
        {
            get => this.externalReference;
            set
            {
                this.externalReference = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A lookup key used to retrieve prices dynamically from a static string. This may be up to
        /// 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        /// If specified, subscriptions using this price will be updated to use the new referenced
        /// price.
        /// </summary>
        [JsonProperty("migrate_to", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("migrate_to")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PriceMigrateToOptions MigrateTo
        {
            get => this.migrateTo;
            set
            {
                this.migrateTo = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A brief description of the price, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        [STJS.JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Only required if a <a
        /// href="https://docs.stripe.com/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)">default
        /// tax behavior</a> was not provided in the Stripe Tax settings. Specifies whether the
        /// price is considered inclusive of taxes or exclusive of taxes. One of <c>inclusive</c>,
        /// <c>exclusive</c>, or <c>unspecified</c>. Once specified as either <c>inclusive</c> or
        /// <c>exclusive</c>, it cannot be changed.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// If set to true, will atomically remove the lookup key from the existing price, and
        /// assign it to this price.
        /// </summary>
        [JsonProperty("transfer_lookup_key")]
        [STJS.JsonPropertyName("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }
    }
}
