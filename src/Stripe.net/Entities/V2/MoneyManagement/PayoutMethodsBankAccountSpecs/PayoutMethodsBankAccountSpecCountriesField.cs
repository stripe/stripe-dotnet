// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodsBankAccountSpecCountriesField : StripeEntity<PayoutMethodsBankAccountSpecCountriesField>
    {
        /// <summary>
        /// The currencies supported by the corresponding credentials for bank accounts in the
        /// specified country.
        /// </summary>
        [JsonProperty("currencies")]
        [STJS.JsonPropertyName("currencies")]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// The local name of the field.
        /// </summary>
        [JsonProperty("local_name")]
        [STJS.JsonPropertyName("local_name")]
        public string LocalName { get; set; }

        /// <summary>
        /// The human readable local name of the field.
        /// </summary>
        [JsonProperty("local_name_human")]
        [STJS.JsonPropertyName("local_name_human")]
        public PayoutMethodsBankAccountSpecCountriesFieldLocalNameHuman LocalNameHuman { get; set; }

        /// <summary>
        /// The maximum length of the field.
        /// </summary>
        [JsonProperty("max_length")]
        [STJS.JsonPropertyName("max_length")]
        public long MaxLength { get; set; }

        /// <summary>
        /// THe minimum length of the field.
        /// </summary>
        [JsonProperty("min_length")]
        [STJS.JsonPropertyName("min_length")]
        public long MinLength { get; set; }

        /// <summary>
        /// The placeholder value of the field.
        /// </summary>
        [JsonProperty("placeholder")]
        [STJS.JsonPropertyName("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// The stripe name of the field.
        /// </summary>
        [JsonProperty("stripe_name")]
        [STJS.JsonPropertyName("stripe_name")]
        public string StripeName { get; set; }

        /// <summary>
        /// The validation regex of the field.
        /// </summary>
        [JsonProperty("validation_regex")]
        [STJS.JsonPropertyName("validation_regex")]
        public string ValidationRegex { get; set; }
    }
}
