// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman : StripeEntity<PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman>
    {
        [JsonProperty("content")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("content")]
#endif
        public string Content { get; set; }

        [JsonProperty("localization_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("localization_key")]
#endif
        public string LocalizationKey { get; set; }
    }
}
