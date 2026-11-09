// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsAlternativeOption : StripeEntity<AccountFutureRequirementsAlternativeOption>
    {
        /// <summary>
        /// The requirements that must all be provided to satisfy this option.
        /// </summary>
        [JsonProperty("entries")]
        [STJS.JsonPropertyName("entries")]
        public List<AccountFutureRequirementsAlternativeOptionEntry> Entries { get; set; }
    }
}
