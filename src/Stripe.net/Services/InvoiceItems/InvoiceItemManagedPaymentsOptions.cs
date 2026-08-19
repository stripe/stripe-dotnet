// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceItemManagedPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable <a
        /// href="https://docs.stripe.com/payments/managed-payments">Managed Payments</a>, Stripe's
        /// merchant of record solution.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
