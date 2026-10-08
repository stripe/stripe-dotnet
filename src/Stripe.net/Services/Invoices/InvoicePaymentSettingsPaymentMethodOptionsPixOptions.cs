// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsPixOptions : INestedOptions
    {
        /// <summary>
        /// Determines if the amount includes the IOF tax. Defaults to <c>never</c>.
        /// One of: <c>always</c>, or <c>never</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("amount_includes_iof")]
        [STJS.JsonPropertyName("amount_includes_iof")]
        public string AmountIncludesIof { get; set; }

        /// <summary>
        /// The number of seconds after PaymentIntent confirmation when the Pix expires (between 60
        /// and 1209600, inclusive). If unspecified, defaults to 14400 seconds (4 hours).
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        [STJS.JsonPropertyName("expires_after_seconds")]
        public long? ExpiresAfterSeconds { get; set; }
    }
}
