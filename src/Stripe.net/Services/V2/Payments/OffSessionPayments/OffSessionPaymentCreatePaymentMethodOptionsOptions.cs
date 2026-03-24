// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreatePaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Payment method options for the card payment type.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OffSessionPaymentCreatePaymentMethodOptionsCardOptions Card { get; set; }
    }
}
