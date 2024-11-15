// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionKonbiniDisplayDetailsStores : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStores>
    {
        /// <summary>
        /// FamilyMart instruction details.
        /// </summary>
        [JsonProperty("familymart")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("familymart")]
#endif

        public PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymart Familymart { get; set; }

        /// <summary>
        /// Lawson instruction details.
        /// </summary>
        [JsonProperty("lawson")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lawson")]
#endif

        public PaymentIntentNextActionKonbiniDisplayDetailsStoresLawson Lawson { get; set; }

        /// <summary>
        /// Ministop instruction details.
        /// </summary>
        [JsonProperty("ministop")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ministop")]
#endif

        public PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistop Ministop { get; set; }

        /// <summary>
        /// Seicomart instruction details.
        /// </summary>
        [JsonProperty("seicomart")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("seicomart")]
#endif

        public PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomart Seicomart { get; set; }
    }
}
