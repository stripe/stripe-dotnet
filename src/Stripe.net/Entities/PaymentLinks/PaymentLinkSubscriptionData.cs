// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkSubscriptionData : StripeEntity<PaymentLinkSubscriptionData>, IHasMetadata
    {
        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("invoice_settings")]
        [STJS.JsonPropertyName("invoice_settings")]
        public PaymentLinkSubscriptionDataInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that will set
        /// metadata on <a href="https://docs.stripe.com/api/subscriptions">Subscriptions</a>
        /// generated from this payment link.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        [STJS.JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        [STJS.JsonPropertyName("trial_settings")]
        public PaymentLinkSubscriptionDataTrialSettings TrialSettings { get; set; }
    }
}
