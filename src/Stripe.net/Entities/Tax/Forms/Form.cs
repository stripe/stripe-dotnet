// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Tax forms are legal documents which are delivered to one or more tax authorities for
    /// information reporting purposes.
    ///
    /// Related guide: <a href="https://stripe.com/docs/connect/tax-reporting">US tax reporting
    /// for Connect platforms</a>.
    /// </summary>
    public class Form : StripeEntity<Form>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable CorrectedBy

        /// <summary>
        /// (ID of the Form)
        /// The form that corrects this form, if any.
        /// </summary>
        [JsonIgnore]
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
        public Form CorrectedBy
        {
            get => this.InternalCorrectedBy?.ExpandedObject;
            set => this.InternalCorrectedBy = SetExpandableFieldObject(value, this.InternalCorrectedBy);
        }

        [JsonProperty("corrected_by")]
        [JsonConverter(typeof(ExpandableFieldConverter<Form>))]
        internal ExpandableField<Form> InternalCorrectedBy { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A list of tax filing statuses. Note that a filing status will only be included if the
        /// form has been filed directly with the jurisdiction’s tax authority.
        /// </summary>
        [JsonProperty("filing_statuses")]
        public List<FormFilingStatus> FilingStatuses { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("payee")]
        public FormPayee Payee { get; set; }

        /// <summary>
        /// The type of the tax form. An additional hash is included on the tax form with a name
        /// matching this value. It contains additional information specific to the tax form type.
        /// One of: <c>us_1099_k</c>, <c>us_1099_misc</c>, or <c>us_1099_nec</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_1099_k")]
        public FormUs1099K Us1099K { get; set; }

        [JsonProperty("us_1099_misc")]
        public FormUs1099Misc Us1099Misc { get; set; }

        [JsonProperty("us_1099_nec")]
        public FormUs1099Nec Us1099Nec { get; set; }
    }
}
