// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionSellerDetails : StripeEntity<RequestedSessionSellerDetails>
    {
        /// <summary>
        /// The marketplace seller details.
        /// </summary>
        [JsonProperty("marketplace_seller_details")]
        [STJS.JsonPropertyName("marketplace_seller_details")]
        public RequestedSessionSellerDetailsMarketplaceSellerDetails MarketplaceSellerDetails { get; set; }

        #region Expandable NetworkProfile

        /// <summary>
        /// (ID of the Profile)
        /// The network profile of the seller.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string NetworkProfileId
        {
            get => this.InternalNetworkProfile?.Id;
            set => this.InternalNetworkProfile = SetExpandableFieldId(value, this.InternalNetworkProfile);
        }

        /// <summary>
        /// (Expanded)
        /// The network profile of the seller.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Profile NetworkProfile
        {
            get => this.InternalNetworkProfile?.ExpandedObject;
            set => this.InternalNetworkProfile = SetExpandableFieldObject(value, this.InternalNetworkProfile);
        }

        [JsonProperty("network_profile")]
        [JsonConverter(typeof(ExpandableFieldConverter<Profile>))]
        [STJS.JsonPropertyName("network_profile")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Profile>))]
        internal ExpandableField<Profile> InternalNetworkProfile { get; set; }
        #endregion

        /// <summary>
        /// The URL to the seller's privacy notice.
        /// </summary>
        [JsonProperty("privacy_notice_url")]
        [STJS.JsonPropertyName("privacy_notice_url")]
        public string PrivacyNoticeUrl { get; set; }

        /// <summary>
        /// The URL to the seller's return policy.
        /// </summary>
        [JsonProperty("return_policy_url")]
        [STJS.JsonPropertyName("return_policy_url")]
        public string ReturnPolicyUrl { get; set; }

        /// <summary>
        /// The URL to the seller's store policy.
        /// </summary>
        [JsonProperty("store_policy_url")]
        [STJS.JsonPropertyName("store_policy_url")]
        public string StorePolicyUrl { get; set; }

        /// <summary>
        /// The URL to the seller's terms of service.
        /// </summary>
        [JsonProperty("terms_of_service_url")]
        [STJS.JsonPropertyName("terms_of_service_url")]
        public string TermsOfServiceUrl { get; set; }
    }
}
