// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CollectionSettingVersionEmailDeliveryPaymentDue : StripeEntity<CollectionSettingVersionEmailDeliveryPaymentDue>
    {
        /// <summary>
        /// If true an email for the invoice would be generated and sent out.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// If true the payment link to hosted invoice page would be included in email and PDF of
        /// the invoice.
        /// </summary>
        [JsonProperty("include_payment_link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include_payment_link")]
#endif
        public bool IncludePaymentLink { get; set; }
    }
}
