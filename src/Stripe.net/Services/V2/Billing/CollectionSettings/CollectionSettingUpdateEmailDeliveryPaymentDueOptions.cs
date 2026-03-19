// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CollectionSettingUpdateEmailDeliveryPaymentDueOptions : INestedOptions
    {
        /// <summary>
        /// If true an email for the invoice would be generated and sent out.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// If true the payment link to hosted invoice page would be included in email and PDF of
        /// the invoice.
        /// </summary>
        [JsonProperty("include_payment_link")]
        [STJS.JsonPropertyName("include_payment_link")]
        public bool? IncludePaymentLink { get; set; }
    }
}
