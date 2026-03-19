// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionScheduleBillingScheduleAppliesTo : StripeEntity<QuotePreviewSubscriptionScheduleBillingScheduleAppliesTo>
    {
        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// The billing schedule will apply to the subscription item with the given price ID.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        /// <summary>
        /// (Expanded)
        /// The billing schedule will apply to the subscription item with the given price ID.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonProperty("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        [STJS.JsonPropertyName("price")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalPrice { get; set; }
        #endregion

        /// <summary>
        /// Controls which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
