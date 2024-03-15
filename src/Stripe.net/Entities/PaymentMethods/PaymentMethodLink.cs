// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentMethodLink : StripeEntity<PaymentMethodLink>
    {
        /// <summary>
        /// Account owner's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// [Deprecated] This is a legacy parameter that no longer has any function.
        /// </summary>
        [Obsolete("This property is deprecated, please refer to the description for details.")]
        [JsonProperty("persistent_token")]
        public string PersistentToken { get; set; }
    }
}
