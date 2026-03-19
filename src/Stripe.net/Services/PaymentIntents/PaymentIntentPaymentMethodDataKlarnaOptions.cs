// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodDataKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Customer's date of birth.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public DobOptions Dob { get; set; }
    }
}
