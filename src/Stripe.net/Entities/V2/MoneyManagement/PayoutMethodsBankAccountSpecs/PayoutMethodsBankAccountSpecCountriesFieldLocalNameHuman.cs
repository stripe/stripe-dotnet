// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman : StripeEntity<PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman>
    {
        /// <summary>
        /// The default content of the localizable string.
        /// </summary>
        [JsonProperty("content")]
        [STJS.JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// A unique key representing the instance of this localizable string.
        /// </summary>
        [JsonProperty("localization_key")]
        [STJS.JsonPropertyName("localization_key")]
        public string LocalizationKey { get; set; }
    }
}
