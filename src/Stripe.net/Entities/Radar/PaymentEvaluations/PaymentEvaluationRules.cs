// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationRules : StripeEntity<PaymentEvaluationRules>
    {
        #region Expandable Matched

        /// <summary>
        /// (IDs of the Matched)
        /// List of Radar rule tokens that matched during evaluation. Expandable to full rule
        /// objects.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> MatchedIds
        {
            get => this.InternalMatched?.Select((x) => x.Id).ToList();
            set => this.InternalMatched = SetExpandableArrayIds<Rule>(value);
        }

        /// <summary>
        /// (Expanded)
        /// List of Radar rule tokens that matched during evaluation. Expandable to full rule
        /// objects.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Rule> Matched
        {
            get => this.InternalMatched?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalMatched = SetExpandableArrayObjects(value);
        }

        [JsonProperty("matched", ItemConverterType = typeof(ExpandableFieldConverter<Rule>))]
        [STJS.JsonPropertyName("matched")]
        internal List<ExpandableField<Rule>> InternalMatched { get; set; }
        #endregion

        #region Expandable Selected

        /// <summary>
        /// (ID of the Rule)
        /// The Radar rule token selected as the decisive rule for this evaluation. Expandable to
        /// the full rule object.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SelectedId
        {
            get => this.InternalSelected?.Id;
            set => this.InternalSelected = SetExpandableFieldId(value, this.InternalSelected);
        }

        /// <summary>
        /// (Expanded)
        /// The Radar rule token selected as the decisive rule for this evaluation. Expandable to
        /// the full rule object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Rule Selected
        {
            get => this.InternalSelected?.ExpandedObject;
            set => this.InternalSelected = SetExpandableFieldObject(value, this.InternalSelected);
        }

        [JsonProperty("selected")]
        [JsonConverter(typeof(ExpandableFieldConverter<Rule>))]
        [STJS.JsonPropertyName("selected")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Rule>))]
        internal ExpandableField<Rule> InternalSelected { get; set; }
        #endregion
    }
}
