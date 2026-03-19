// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfirmationTokenPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for any card payments confirmed using this ConfirmationToken.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public ConfirmationTokenPaymentMethodOptionsCardOptions Card { get; set; }
    }
}
