// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProfileListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter billing profiles by a customer. Mutually exclusive with <c>lookup_keys</c> and
        /// <c>default_payment_method</c>.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Filter billing profiles by a default payment method. Mutually exclusive with
        /// <c>customer</c> and <c>lookup_keys</c>.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Filter billing profiles by lookup keys. Mutually exclusive with <c>customer</c> and
        /// <c>default_payment_method</c>. You can specify up to 10 lookup_keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_keys")]
#endif
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Filter billing profiles by status. Can be combined with all other filters. If not
        /// provided, all billing profiles will be returned.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
