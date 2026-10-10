// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsWechatPayMobileWebPaymentsOptions : INestedOptions, IHasSetTracking
    {
        private List<string> domains;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The domains of the user's mobile web checkout pages for WeChat Pay payments.
        /// </summary>
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("domains")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Domains
        {
            get => this.domains;
            set
            {
                this.domains = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
