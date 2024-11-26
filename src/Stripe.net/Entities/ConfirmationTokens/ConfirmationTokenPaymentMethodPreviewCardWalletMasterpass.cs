// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewCardWalletMasterpass : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardWalletMasterpass>
    {
        /// <summary>
        /// Owner's verified billing address. Values are verified or provided by the wallet directly
        /// (if supported) at the time of authorization or settlement. They cannot be set or
        /// mutated.
        /// </summary>
        [JsonProperty("billing_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_address")]
#endif
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Owner's verified email. Values are verified or provided by the wallet directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by the wallet directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Owner's verified shipping address. Values are verified or provided by the wallet
        /// directly (if supported) at the time of authorization or settlement. They cannot be set
        /// or mutated.
        /// </summary>
        [JsonProperty("shipping_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_address")]
#endif
        public Address ShippingAddress { get; set; }
    }
}
