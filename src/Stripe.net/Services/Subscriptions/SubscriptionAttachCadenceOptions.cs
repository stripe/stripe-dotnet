// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionAttachCadenceOptions : BaseOptions
    {
        /// <summary>
        /// The Billing Cadence which controls the timing of recurring invoice generation for this
        /// subscription. If unset, the subscription will bill according to its own configured
        /// schedule and create its own invoices. If set, this subscription will be billed by the
        /// cadence instead, potentially sharing invoices with the other subscriptions linked to
        /// that Cadence.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }
    }
}
