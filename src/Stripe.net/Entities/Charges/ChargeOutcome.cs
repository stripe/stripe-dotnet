// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class ChargeOutcome : StripeEntity<ChargeOutcome>
    {
        /// <summary>
        /// An enumerated value providing a more detailed explanation on <a
        /// href="https://stripe.com/docs/declines#retrying-issuer-declines">how to proceed with an
        /// error</a>.
        /// One of: <c>confirm_card_data</c>, <c>do_not_try_again</c>, or <c>try_again_later</c>.
        /// </summary>
        [JsonProperty("advice_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("advice_code")]
#endif
        public string AdviceCode { get; set; }

        /// <summary>
        /// For charges declined by the network, a 2 digit code which indicates the advice returned
        /// by the network on how to proceed with an error.
        /// </summary>
        [JsonProperty("network_advice_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_advice_code")]
#endif
        public string NetworkAdviceCode { get; set; }

        /// <summary>
        /// For charges declined by the network, a brand specific 2, 3, or 4 digit code which
        /// indicates the reason the authorization failed.
        /// </summary>
        [JsonProperty("network_decline_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_decline_code")]
#endif
        public string NetworkDeclineCode { get; set; }

        /// <summary>
        /// Possible values are <c>approved_by_network</c>, <c>declined_by_network</c>,
        /// <c>not_sent_to_network</c>, and <c>reversed_after_approval</c>. The value
        /// <c>reversed_after_approval</c> indicates the payment was <a
        /// href="https://stripe.com/docs/declines#blocked-payments">blocked by Stripe</a> after
        /// bank authorization, and may temporarily appear as "pending" on a cardholder's statement.
        /// </summary>
        [JsonProperty("network_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_status")]
#endif
        public string NetworkStatus { get; set; }

        /// <summary>
        /// An enumerated value providing a more detailed explanation of the outcome's <c>type</c>.
        /// Charges blocked by Radar's default block rule have the value <c>highest_risk_level</c>.
        /// Charges placed in review by Radar's default review rule have the value
        /// <c>elevated_risk_level</c>. Charges authorized, blocked, or placed in review by custom
        /// rules have the value <c>rule</c>. See <a
        /// href="https://stripe.com/docs/declines">understanding declines</a> for more details.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// Stripe Radar's evaluation of the riskiness of the payment. Possible values for evaluated
        /// payments are <c>normal</c>, <c>elevated</c>, <c>highest</c>. For non-card payments, and
        /// card-based payments predating the public assignment of risk levels, this field will have
        /// the value <c>not_assessed</c>. In the event of an error in the evaluation, this field
        /// will have the value <c>unknown</c>. This field is only available with Radar.
        /// </summary>
        [JsonProperty("risk_level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("risk_level")]
#endif
        public string RiskLevel { get; set; }

        /// <summary>
        /// Stripe Radar's evaluation of the riskiness of the payment. Possible values for evaluated
        /// payments are between 0 and 100. For non-card payments, card-based payments predating the
        /// public assignment of risk scores, or in the event of an error during evaluation, this
        /// field will not be present. This field is only available with Radar for Fraud Teams.
        /// </summary>
        [JsonProperty("risk_score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("risk_score")]
#endif
        public long RiskScore { get; set; }

        #region Expandable Rule

        /// <summary>
        /// (ID of the Radar.Rule)
        /// The ID of the Radar rule that matched the payment, if applicable.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string RuleId
        {
            get => this.InternalRule?.Id;
            set => this.InternalRule = SetExpandableFieldId(value, this.InternalRule);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Radar rule that matched the payment, if applicable.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Radar.Rule Rule
        {
            get => this.InternalRule?.ExpandedObject;
            set => this.InternalRule = SetExpandableFieldObject(value, this.InternalRule);
        }

        [JsonProperty("rule")]
        [JsonConverter(typeof(ExpandableFieldConverter<Radar.Rule>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rule")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Radar.Rule>))]
#endif
        internal ExpandableField<Radar.Rule> InternalRule { get; set; }
        #endregion

        /// <summary>
        /// A human-readable description of the outcome type and reason, designed for you (the
        /// recipient of the payment), not your customer.
        /// </summary>
        [JsonProperty("seller_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("seller_message")]
#endif
        public string SellerMessage { get; set; }

        /// <summary>
        /// Possible values are <c>authorized</c>, <c>manual_review</c>, <c>issuer_declined</c>,
        /// <c>blocked</c>, and <c>invalid</c>. See <a
        /// href="https://stripe.com/docs/declines">understanding declines</a> and <a
        /// href="https://stripe.com/docs/radar/reviews">Radar reviews</a> for details.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
