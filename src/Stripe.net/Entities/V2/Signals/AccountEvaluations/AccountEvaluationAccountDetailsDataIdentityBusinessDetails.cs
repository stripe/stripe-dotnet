// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationAccountDetailsDataIdentityBusinessDetails : StripeEntity<AccountEvaluationAccountDetailsDataIdentityBusinessDetails>
    {
        /// <summary>
        /// Registered business name.
        /// </summary>
        [JsonProperty("registered_name")]
        [STJS.JsonPropertyName("registered_name")]
        public string RegisteredName { get; set; }
    }
}
