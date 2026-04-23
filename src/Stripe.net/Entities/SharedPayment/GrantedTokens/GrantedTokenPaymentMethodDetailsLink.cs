// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetailsLink : StripeEntity<GrantedTokenPaymentMethodDetailsLink>
    {
        /// <summary>
        /// Account owner's email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// [Deprecated] This is a legacy parameter that no longer has any function.
        /// </summary>
        [Obsolete("This property is deprecated, please refer to the description for details.")]
        [JsonProperty("persistent_token")]
        [STJS.JsonPropertyName("persistent_token")]
        public string PersistentToken { get; set; }
    }
}
