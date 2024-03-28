// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsIssuingCardsListFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow card management features.
        /// </summary>
        [JsonProperty("card_management")]
        public bool? CardManagement { get; set; }

        /// <summary>
        /// Whether to allow cardholder management features.
        /// </summary>
        [JsonProperty("cardholder_management")]
        public bool? CardholderManagement { get; set; }
    }
}
