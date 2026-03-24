// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionKonbiniDisplayDetailsStores : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStores>
    {
        /// <summary>
        /// FamilyMart instruction details.
        /// </summary>
        [JsonProperty("familymart")]
        [STJS.JsonPropertyName("familymart")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymart Familymart { get; set; }

        /// <summary>
        /// Lawson instruction details.
        /// </summary>
        [JsonProperty("lawson")]
        [STJS.JsonPropertyName("lawson")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresLawson Lawson { get; set; }

        /// <summary>
        /// Ministop instruction details.
        /// </summary>
        [JsonProperty("ministop")]
        [STJS.JsonPropertyName("ministop")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistop Ministop { get; set; }

        /// <summary>
        /// Seicomart instruction details.
        /// </summary>
        [JsonProperty("seicomart")]
        [STJS.JsonPropertyName("seicomart")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomart Seicomart { get; set; }
    }
}
