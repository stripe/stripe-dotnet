// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodLink : StripeEntity<PaymentMethodLink>
    {
        /// <summary>
        /// Account owner's email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// [Deprecated] This is a legacy parameter that no longer has any function.
        /// </summary>
        [Obsolete("This property is deprecated, please refer to the description for details.")]
        [JsonProperty("persistent_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("persistent_token")]
#endif
        public string PersistentToken { get; set; }
    }
}
