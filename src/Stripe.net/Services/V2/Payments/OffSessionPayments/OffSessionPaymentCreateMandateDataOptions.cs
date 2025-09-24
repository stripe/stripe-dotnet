// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreateMandateDataOptions : INestedOptions
    {
        /// <summary>
        /// This hash contains details about the customer acceptance of the Mandate.
        /// </summary>
        [JsonProperty("customer_acceptance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_acceptance")]
#endif
        public OffSessionPaymentCreateMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}
