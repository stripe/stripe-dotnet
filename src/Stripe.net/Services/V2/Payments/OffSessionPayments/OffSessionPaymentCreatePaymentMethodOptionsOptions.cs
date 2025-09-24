// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreatePaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Payment method options for the card payment type.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public OffSessionPaymentCreatePaymentMethodOptionsCardOptions Card { get; set; }
    }
}
