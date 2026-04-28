// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IssuedTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The PaymentMethod that is going to be shared by the SharedPaymentIssuedToken.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If the customer does not exit their browser while authenticating, they will be
        /// redirected to this specified URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Seller details of the SharedPaymentIssuedToken, including network_id and external_id.
        /// </summary>
        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public IssuedTokenSellerDetailsOptions SellerDetails { get; set; }

        /// <summary>
        /// Indicates that you intend to save the PaymentMethod of this SharedPaymentToken to a
        /// customer later.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to the SharedPaymentIssuedToken. The values here are visible by default with the
        /// party that you share this SharedPaymentIssuedToken with.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// Limits on how this SharedPaymentToken can be used.
        /// </summary>
        [JsonProperty("usage_limits")]
        [STJS.JsonPropertyName("usage_limits")]
        public IssuedTokenUsageLimitsOptions UsageLimits { get; set; }
    }
}
