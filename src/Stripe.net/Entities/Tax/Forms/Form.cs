// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Tax forms are legal documents which are delivered to one or more tax authorities for
    /// information reporting purposes.
    ///
    /// Related guide: <a href="https://stripe.com/docs/connect/tax-reporting">US tax reporting
    /// for Connect platforms</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Form : StripeEntity<Form>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        [JsonProperty("au_serr")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_serr")]
#endif
        public FormAuSerr AuSerr { get; set; }

        [JsonProperty("ca_mrdp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ca_mrdp")]
#endif
        public FormCaMrdp CaMrdp { get; set; }

        #region Expandable CorrectedBy

        /// <summary>
        /// (ID of the Form)
        /// The form that corrects this form, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CorrectedById
        {
            get => this.InternalCorrectedBy?.Id;
            set => this.InternalCorrectedBy = SetExpandableFieldId(value, this.InternalCorrectedBy);
        }

        /// <summary>
        /// (Expanded)
        /// The form that corrects this form, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Form CorrectedBy
        {
            get => this.InternalCorrectedBy?.ExpandedObject;
            set => this.InternalCorrectedBy = SetExpandableFieldObject(value, this.InternalCorrectedBy);
        }

        [JsonProperty("corrected_by")]
        [JsonConverter(typeof(ExpandableFieldConverter<Form>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("corrected_by")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Form>))]
#endif
        internal ExpandableField<Form> InternalCorrectedBy { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("eu_dac7")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eu_dac7")]
#endif
        public FormEuDac7 EuDac7 { get; set; }

        /// <summary>
        /// A list of tax filing statuses. Note that a filing status will only be included if the
        /// form has been filed directly with the jurisdiction’s tax authority.
        /// </summary>
        [JsonProperty("filing_statuses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filing_statuses")]
#endif
        public List<FormFilingStatus> FilingStatuses { get; set; }

        [JsonProperty("gb_mrdp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_mrdp")]
#endif
        public FormGbMrdp GbMrdp { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        [JsonProperty("nz_mrdp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nz_mrdp")]
#endif
        public FormNzMrdp NzMrdp { get; set; }

        [JsonProperty("payee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payee")]
#endif
        public FormPayee Payee { get; set; }

        /// <summary>
        /// The type of the tax form. An additional hash is included on the tax form with a name
        /// matching this value. It contains additional information specific to the tax form type.
        /// One of: <c>au_serr</c>, <c>ca_mrdp</c>, <c>eu_dac7</c>, <c>gb_mrdp</c>, <c>nz_mrdp</c>,
        /// <c>us_1099_k</c>, <c>us_1099_misc</c>, or <c>us_1099_nec</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("us_1099_k")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_1099_k")]
#endif
        public FormUs1099K Us1099K { get; set; }

        [JsonProperty("us_1099_misc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_1099_misc")]
#endif
        public FormUs1099Misc Us1099Misc { get; set; }

        [JsonProperty("us_1099_nec")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_1099_nec")]
#endif
        public FormUs1099Nec Us1099Nec { get; set; }
    }
}
