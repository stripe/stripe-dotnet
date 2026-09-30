// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationAccountDetailsDataIdentity : StripeEntity<AccountEvaluationAccountDetailsDataIdentity>
    {
        /// <summary>
        /// Business details for identity data.
        /// </summary>
        [JsonProperty("business_details")]
        [STJS.JsonPropertyName("business_details")]
        public AccountEvaluationAccountDetailsDataIdentityBusinessDetails BusinessDetails { get; set; }
    }
}
