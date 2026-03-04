// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class RequestedSessionSellerDetails : StripeEntity<RequestedSessionSellerDetails>
    {
        /// <summary>
        /// The marketplace seller details.
        /// </summary>
        [JsonProperty("marketplace_seller_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketplace_seller_details")]
#endif
        public RequestedSessionSellerDetailsMarketplaceSellerDetails MarketplaceSellerDetails { get; set; }

        #region Expandable NetworkProfile

        /// <summary>
        /// (ID of the Profile)
        /// The network profile of the seller.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Profile NetworkProfile
        {
            get => this.InternalNetworkProfile?.ExpandedObject;
            set => this.InternalNetworkProfile = SetExpandableFieldObject(value, this.InternalNetworkProfile);
        }

        [JsonProperty("network_profile")]
        [JsonConverter(typeof(ExpandableFieldConverter<Profile>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_profile")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Profile>))]
#endif
        internal ExpandableField<Profile> InternalNetworkProfile { get; set; }
        #endregion

        /// <summary>
        /// The URL to the seller's privacy notice.
        /// </summary>
        [JsonProperty("privacy_notice_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("privacy_notice_url")]
#endif
        public string PrivacyNoticeUrl { get; set; }

        /// <summary>
        /// The URL to the seller's return policy.
        /// </summary>
        [JsonProperty("return_policy_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_policy_url")]
#endif
        public string ReturnPolicyUrl { get; set; }

        /// <summary>
        /// The URL to the seller's store policy.
        /// </summary>
        [JsonProperty("store_policy_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("store_policy_url")]
#endif
        public string StorePolicyUrl { get; set; }

        /// <summary>
        /// The URL to the seller's terms of service.
        /// </summary>
        [JsonProperty("terms_of_service_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service_url")]
#endif
        public string TermsOfServiceUrl { get; set; }
    }
}
