// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantKonbiniPaymentsSupportOptions : INestedOptions
    {
        /// <summary>
        /// Support email address for Konbini payments.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Support hours for Konbini payments.
        /// </summary>
        [JsonProperty("hours")]
        [STJS.JsonPropertyName("hours")]
        public AccountCreateConfigurationMerchantKonbiniPaymentsSupportHoursOptions Hours { get; set; }

        /// <summary>
        /// Support phone number for Konbini payments.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
