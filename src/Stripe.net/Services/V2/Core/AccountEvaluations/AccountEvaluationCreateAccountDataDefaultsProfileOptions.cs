// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateAccountDataDefaultsProfileOptions : INestedOptions
    {
        /// <summary>
        /// The business URL.
        /// </summary>
        [JsonProperty("business_url")]
        [STJS.JsonPropertyName("business_url")]
        public string BusinessUrl { get; set; }

        /// <summary>
        /// Doing business as (DBA) name.
        /// </summary>
        [JsonProperty("doing_business_as")]
        [STJS.JsonPropertyName("doing_business_as")]
        public string DoingBusinessAs { get; set; }

        /// <summary>
        /// Description of the account's product or service.
        /// </summary>
        [JsonProperty("product_description")]
        [STJS.JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }
    }
}
