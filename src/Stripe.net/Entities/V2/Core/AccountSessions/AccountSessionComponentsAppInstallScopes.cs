// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsAppInstallScopes : StripeEntity<AccountSessionComponentsAppInstallScopes>
    {
        /// <summary>
        /// The Stripe App IDs allowed in the enabled app components.
        /// </summary>
        [JsonProperty("allowed_stripe_app_ids")]
        [STJS.JsonPropertyName("allowed_stripe_app_ids")]
        public List<string> AllowedStripeAppIds { get; set; }
    }
}
