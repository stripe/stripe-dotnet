// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantKonbiniPayments : StripeEntity<AccountConfigurationMerchantKonbiniPayments>
    {
        /// <summary>
        /// Support for Konbini payments.
        /// </summary>
        [JsonProperty("support")]
        [STJS.JsonPropertyName("support")]
        public AccountConfigurationMerchantKonbiniPaymentsSupport Support { get; set; }
    }
}
