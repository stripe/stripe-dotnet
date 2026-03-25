// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.SharedPayment
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GrantedTokenCreateOptions : BaseOptions
    {
        private Dictionary<string, string> sharedMetadata;

        /// <summary>
        /// The Customer that the SharedPaymentGrantedToken belongs to. Should match the Customer
        /// that the PaymentMethod is attached to if any.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The PaymentMethod that is going to be shared by the SharedPaymentGrantedToken.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to the SharedPaymentGrantedToken.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata
        {
            get => this.sharedMetadata;
            set
            {
                this.sharedMetadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Limits on how this SharedPaymentGrantedToken can be used.
        /// </summary>
        [JsonProperty("usage_limits")]
        [STJS.JsonPropertyName("usage_limits")]
        public GrantedTokenUsageLimitsOptions UsageLimits { get; set; }
    }
}
