// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProfileListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter billing profiles by a customer. Mutually exclusive with <c>lookup_keys</c> and
        /// <c>default_payment_method</c>.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Filter billing profiles by a default payment method. Mutually exclusive with
        /// <c>customer</c> and <c>lookup_keys</c>.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Filter billing profiles by lookup keys. Mutually exclusive with <c>customer</c> and
        /// <c>default_payment_method</c>. You can specify up to 10 lookup_keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
        [STJS.JsonPropertyName("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Filter billing profiles by status. Can be combined with all other filters. If not
        /// provided, all billing profiles will be returned.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
