// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionShippingOptionOptions : INestedOptions, IHasSetTracking
    {
        private List<string> taxRates;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The ID of the Shipping Rate to use for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate")]
        [STJS.JsonPropertyName("shipping_rate")]
        public string ShippingRate { get; set; }

        /// <summary>
        /// Parameters to be passed to Shipping Rate creation for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate_data")]
        [STJS.JsonPropertyName("shipping_rate_data")]
        public SessionShippingOptionShippingRateDataOptions ShippingRateData { get; set; }

        /// <summary>
        /// The tax rates that will be applied to this shipping option. This parameter is only
        /// supported for Checkout Sessions with <c>ui_mode</c> set to <c>form</c> or
        /// <c>elements</c>.
        /// </summary>
        [JsonProperty("tax_rates", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tax_rates")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> TaxRates
        {
            get => this.taxRates;
            set
            {
                this.taxRates = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
