// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account ID to evaluate. Exactly one of account or account_data must be provided.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Account data for entity-less evaluation. Exactly one of account or account_data must be
        /// provided.
        /// </summary>
        [JsonProperty("account_data")]
        [STJS.JsonPropertyName("account_data")]
        public AccountEvaluationCreateAccountDataOptions AccountData { get; set; }

        /// <summary>
        /// List of signals to evaluate.
        /// One of: <c>fraudulent_website</c>, <c>user_account_sharing</c>, or
        /// <c>user_multi_accounting</c>.
        /// </summary>
        [JsonProperty("signals")]
        [STJS.JsonPropertyName("signals")]
        public List<string> Signals { get; set; }
    }
}
