// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// This object represents the limit for the remaining amount that the crypto customer can
    /// onramp.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnrampTransactionLimits : StripeEntity<OnrampTransactionLimits>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The ID of the crypto customer.
        /// </summary>
        [JsonProperty("crypto_customer_id")]
        [STJS.JsonPropertyName("crypto_customer_id")]
        public string CryptoCustomerId { get; set; }

        /// <summary>
        /// The remaining onramp limit for the crypto customer, separated by currency, payment
        /// method, and settlement speed.
        ///
        /// Limits are shown for currencies that correspond to the regions where the customer
        /// previously transacted. If the customer has no prior transactions, we return limits for
        /// all supported currencies.
        /// </summary>
        [JsonProperty("limits")]
        [STJS.JsonPropertyName("limits")]
        public Dictionary<string, object> Limits { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
