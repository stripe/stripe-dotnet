// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsWechatPayPaymentsOptions : INestedOptions, IHasSetTracking
    {
        private List<string> mobileWebDomains;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The domains of the user's mobile web checkout pages for WeChat Pay payments. At most 4
        /// domains are allowed.
        /// </summary>
        [JsonProperty("mobile_web_domains", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("mobile_web_domains")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> MobileWebDomains
        {
            get => this.mobileWebDomains;
            set
            {
                this.mobileWebDomains = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
