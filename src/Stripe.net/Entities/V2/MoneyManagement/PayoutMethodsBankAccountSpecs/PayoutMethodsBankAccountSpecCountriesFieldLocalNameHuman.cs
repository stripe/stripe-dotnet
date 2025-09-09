// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman : StripeEntity<PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman>
    {
        /// <summary>
        /// The default content of the localizable string.
        /// </summary>
        [JsonProperty("content")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("content")]
#endif
        public string Content { get; set; }

        /// <summary>
        /// A unique key representing the instance of this localizable string.
        /// </summary>
        [JsonProperty("localization_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("localization_key")]
#endif
        public string LocalizationKey { get; set; }
    }
}
