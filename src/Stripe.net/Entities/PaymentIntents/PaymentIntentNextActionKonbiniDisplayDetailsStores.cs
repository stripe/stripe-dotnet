// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextActionKonbiniDisplayDetailsStores : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStores>
    {
        /// <summary>
        /// FamilyMart instruction details.
        /// </summary>
        [JsonProperty("familymart")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymart Familymart { get; set; }

        /// <summary>
        /// Lawson instruction details.
        /// </summary>
        [JsonProperty("lawson")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresLawson Lawson { get; set; }

        /// <summary>
        /// Ministop instruction details.
        /// </summary>
        [JsonProperty("ministop")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistop Ministop { get; set; }

        /// <summary>
        /// Seicomart instruction details.
        /// </summary>
        [JsonProperty("seicomart")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomart Seicomart { get; set; }
    }
}
