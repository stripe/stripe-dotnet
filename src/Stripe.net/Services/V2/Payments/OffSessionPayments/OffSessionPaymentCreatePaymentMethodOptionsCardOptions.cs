// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreatePaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Indicates whether the saved card is used for a recurring or unscheduled payment.
        /// One of: <c>recurring</c>, or <c>unscheduled</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("stored_credential_usage")]
        [STJS.JsonPropertyName("stored_credential_usage")]
        public string StoredCredentialUsage { get; set; }
    }
}
