// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAgentDetails : StripeEntity<PaymentIntentAgentDetails>
    {
        /// <summary>
        /// The name of the agent that initiated the payment.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        #region Expandable NetworkBusinessProfile

        /// <summary>
        /// (ID of the Profile)
        /// The Stripe profile associated with the agent that initiated the payment.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string NetworkBusinessProfileId
        {
            get => this.InternalNetworkBusinessProfile?.Id;
            set => this.InternalNetworkBusinessProfile = SetExpandableFieldId(value, this.InternalNetworkBusinessProfile);
        }

        /// <summary>
        /// (Expanded)
        /// The Stripe profile associated with the agent that initiated the payment.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Profile NetworkBusinessProfile
        {
            get => this.InternalNetworkBusinessProfile?.ExpandedObject;
            set => this.InternalNetworkBusinessProfile = SetExpandableFieldObject(value, this.InternalNetworkBusinessProfile);
        }

        [JsonProperty("network_business_profile")]
        [JsonConverter(typeof(ExpandableFieldConverter<Profile>))]
        [STJS.JsonPropertyName("network_business_profile")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Profile>))]
        internal ExpandableField<Profile> InternalNetworkBusinessProfile { get; set; }
        #endregion
    }
}
