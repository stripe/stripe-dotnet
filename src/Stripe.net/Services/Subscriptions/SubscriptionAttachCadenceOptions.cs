// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cadence")]
#endif
        public string BillingCadence { get; set; }
    }
}
