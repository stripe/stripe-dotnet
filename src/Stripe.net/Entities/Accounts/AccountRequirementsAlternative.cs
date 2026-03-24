// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRequirementsAlternative : StripeEntity<AccountRequirementsAlternative>
    {
        /// <summary>
        /// Fields that can be provided to resolve all fields in <c>original_fields_due</c>.
        /// </summary>
        [JsonProperty("alternative_fields_due")]
        [STJS.JsonPropertyName("alternative_fields_due")]
        public List<string> AlternativeFieldsDue { get; set; }

        /// <summary>
        /// Fields that are due and can be resolved by providing all fields in
        /// <c>alternative_fields_due</c>.
        /// </summary>
        [JsonProperty("original_fields_due")]
        [STJS.JsonPropertyName("original_fields_due")]
        public List<string> OriginalFieldsDue { get; set; }
    }
}
