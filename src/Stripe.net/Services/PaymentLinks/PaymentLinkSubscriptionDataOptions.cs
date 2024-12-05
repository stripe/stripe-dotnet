// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkSubscriptionDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public PaymentLinkSubscriptionDataInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that will
        /// declaratively set metadata on <a
        /// href="https://stripe.com/docs/api/subscriptions">Subscriptions</a> generated from this
        /// payment link. Unlike object-level metadata, this field is declarative. Updates will
        /// clear prior values.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time. Has to be at least 1.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        public PaymentLinkSubscriptionDataTrialSettingsOptions TrialSettings { get; set; }
    }
}
