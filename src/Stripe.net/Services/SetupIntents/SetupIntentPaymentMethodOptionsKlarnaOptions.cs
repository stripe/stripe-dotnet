// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodOptionsKlarnaOptions : INestedOptions, IHasSetTracking
    {
        private List<SetupIntentPaymentMethodOptionsKlarnaSubscriptionOptions> subscriptions;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The currency of the SetupIntent. Three letter ISO currency code.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// On-demand details if setting up a payment method for on-demand payments.
        /// </summary>
        [JsonProperty("on_demand")]
        [STJS.JsonPropertyName("on_demand")]
        public SetupIntentPaymentMethodOptionsKlarnaOnDemandOptions OnDemand { get; set; }

        /// <summary>
        /// Preferred language of the Klarna authorization page that the customer is redirected to.
        /// One of: <c>cs-CZ</c>, <c>da-DK</c>, <c>de-AT</c>, <c>de-CH</c>, <c>de-DE</c>,
        /// <c>el-GR</c>, <c>en-AT</c>, <c>en-AU</c>, <c>en-BE</c>, <c>en-CA</c>, <c>en-CH</c>,
        /// <c>en-CZ</c>, <c>en-DE</c>, <c>en-DK</c>, <c>en-ES</c>, <c>en-FI</c>, <c>en-FR</c>,
        /// <c>en-GB</c>, <c>en-GR</c>, <c>en-IE</c>, <c>en-IT</c>, <c>en-NL</c>, <c>en-NO</c>,
        /// <c>en-NZ</c>, <c>en-PL</c>, <c>en-PT</c>, <c>en-RO</c>, <c>en-SE</c>, <c>en-US</c>,
        /// <c>es-ES</c>, <c>es-US</c>, <c>fi-FI</c>, <c>fr-BE</c>, <c>fr-CA</c>, <c>fr-CH</c>,
        /// <c>fr-FR</c>, <c>it-CH</c>, <c>it-IT</c>, <c>nb-NO</c>, <c>nl-BE</c>, <c>nl-NL</c>,
        /// <c>pl-PL</c>, <c>pt-PT</c>, <c>ro-RO</c>, <c>sv-FI</c>, or <c>sv-SE</c>.
        /// </summary>
        [JsonProperty("preferred_locale")]
        [STJS.JsonPropertyName("preferred_locale")]
        public string PreferredLocale { get; set; }

        /// <summary>
        /// Subscription details if setting up or charging a subscription.
        /// </summary>
        [JsonProperty("subscriptions")]
        [STJS.JsonPropertyName("subscriptions")]
        public List<SetupIntentPaymentMethodOptionsKlarnaSubscriptionOptions> Subscriptions
        {
            get => this.subscriptions;
            set
            {
                this.subscriptions = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
