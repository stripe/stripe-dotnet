// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntegrationConfigurationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Configuration for Checkout Sessions automatic tax behavior.
        /// </summary>
        [JsonProperty("checkout_sessions")]
        [STJS.JsonPropertyName("checkout_sessions")]
        public IntegrationConfigurationUpdateCheckoutSessionsOptions CheckoutSessions { get; set; }

        /// <summary>
        /// Configuration for standalone Invoices automatic tax behavior.
        /// </summary>
        [JsonProperty("invoices")]
        [STJS.JsonPropertyName("invoices")]
        public IntegrationConfigurationUpdateInvoicesOptions Invoices { get; set; }
    }
}
