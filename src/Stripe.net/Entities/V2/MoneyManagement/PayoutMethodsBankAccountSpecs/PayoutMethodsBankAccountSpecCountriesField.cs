// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodsBankAccountSpecCountriesField : StripeEntity<PayoutMethodsBankAccountSpecCountriesField>
    {
        /// <summary>
        /// The local name of the field.
        /// </summary>
        [JsonProperty("local_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local_name")]
#endif
        public string LocalName { get; set; }

        /// <summary>
        /// The human readable local name of the field.
        /// </summary>
        [JsonProperty("local_name_human")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local_name_human")]
#endif
        public PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman LocalNameHuman { get; set; }

        /// <summary>
        /// The maximum length of the field.
        /// </summary>
        [JsonProperty("max_length")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("max_length")]
#endif
        public long MaxLength { get; set; }

        /// <summary>
        /// THe minimum length of the field.
        /// </summary>
        [JsonProperty("min_length")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("min_length")]
#endif
        public long MinLength { get; set; }

        /// <summary>
        /// The placeholder value of the field.
        /// </summary>
        [JsonProperty("placeholder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("placeholder")]
#endif
        public string Placeholder { get; set; }

        /// <summary>
        /// The stripe name of the field.
        /// </summary>
        [JsonProperty("stripe_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_name")]
#endif
        public string StripeName { get; set; }

        /// <summary>
        /// The validation regex of the field.
        /// </summary>
        [JsonProperty("validation_regex")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_regex")]
#endif
        public string ValidationRegex { get; set; }
    }
}
