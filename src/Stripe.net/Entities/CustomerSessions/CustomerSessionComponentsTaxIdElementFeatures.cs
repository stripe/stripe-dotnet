// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerSessionComponentsTaxIdElementFeatures : StripeEntity<CustomerSessionComponentsTaxIdElementFeatures>
    {
        /// <summary>
        /// Controls whether the Tax ID Element displays saved tax IDs for the customer. This
        /// parameter defaults to <c>disabled</c>.
        ///
        /// When enabled, the Tax ID Element will show existing tax IDs associated with the
        /// customer, allowing them to select from previously saved tax identification numbers.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("tax_id_redisplay")]
        [STJS.JsonPropertyName("tax_id_redisplay")]
        public string TaxIdRedisplay { get; set; }

        /// <summary>
        /// Controls whether the Tax ID Element allows merchants to save new tax IDs for their
        /// customer. This parameter defaults to <c>disabled</c>.
        ///
        /// When enabled, customers can enter and save new tax identification numbers during the
        /// payment flow, which will be stored securely and associated with their customer object
        /// for future use.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("tax_id_save")]
        [STJS.JsonPropertyName("tax_id_save")]
        public string TaxIdSave { get; set; }
    }
}
