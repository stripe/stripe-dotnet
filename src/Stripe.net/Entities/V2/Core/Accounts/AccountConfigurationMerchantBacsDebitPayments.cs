// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantBacsDebitPayments : StripeEntity<AccountConfigurationMerchantBacsDebitPayments>
    {
        /// <summary>
        /// Display name for Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Service User Number (SUN) for Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("service_user_number")]
        [STJS.JsonPropertyName("service_user_number")]
        public string ServiceUserNumber { get; set; }
    }
}
