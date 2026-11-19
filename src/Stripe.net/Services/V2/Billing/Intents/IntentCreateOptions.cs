// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateOptions : BaseOptions
    {
        /// <summary>
        /// Actions to be performed by this Billing Intent.
        /// </summary>
        [JsonProperty("actions")]
        [STJS.JsonPropertyName("actions")]
        public List<IntentCreateActionOptions> Actions { get; set; }

        /// <summary>
        /// ID of an existing Billing Group to use.
        /// </summary>
        [JsonProperty("billing_group")]
        [STJS.JsonPropertyName("billing_group")]
        public string BillingGroup { get; set; }

        /// <summary>
        /// Data for creating a new Billing Group.
        /// </summary>
        [JsonProperty("billing_group_data")]
        [STJS.JsonPropertyName("billing_group_data")]
        public IntentCreateBillingGroupDataOptions BillingGroupData { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
