// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonalizationDesignCarrierTextOptions : INestedOptions, IHasSetTracking
    {
        private string footerBody;
        private string footerTitle;
        private string headerBody;
        private string headerTitle;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The footer body text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_body", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("footer_body")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string FooterBody
        {
            get => this.footerBody;
            set
            {
                this.footerBody = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The footer title text of the carrier letter.
        /// </summary>
        [JsonProperty("footer_title", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("footer_title")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string FooterTitle
        {
            get => this.footerTitle;
            set
            {
                this.footerTitle = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The header body text of the carrier letter.
        /// </summary>
        [JsonProperty("header_body", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("header_body")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string HeaderBody
        {
            get => this.headerBody;
            set
            {
                this.headerBody = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The header title text of the carrier letter.
        /// </summary>
        [JsonProperty("header_title", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("header_title")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string HeaderTitle
        {
            get => this.headerTitle;
            set
            {
                this.headerTitle = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
