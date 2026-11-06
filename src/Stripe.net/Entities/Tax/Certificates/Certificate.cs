// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Tax exemption and resale certificates associated with tax exemptions.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Certificate : StripeEntity<Certificate>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether the certificate has been deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        #region Expandable File

        /// <summary>
        /// (ID of the File)
        /// The uploaded certificate file.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string FileId
        {
            get => this.InternalFile?.Id;
            set => this.InternalFile = SetExpandableFieldId(value, this.InternalFile);
        }

        /// <summary>
        /// (Expanded)
        /// The uploaded certificate file.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public File File
        {
            get => this.InternalFile?.ExpandedObject;
            set => this.InternalFile = SetExpandableFieldObject(value, this.InternalFile);
        }

        [JsonProperty("file")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        [STJS.JsonPropertyName("file")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalFile { get; set; }
        #endregion

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        #region Expandable TaxExemption

        /// <summary>
        /// (ID of the CustomerTaxExemption)
        /// The tax exemption associated with this certificate.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string TaxExemptionId
        {
            get => this.InternalTaxExemption?.Id;
            set => this.InternalTaxExemption = SetExpandableFieldId(value, this.InternalTaxExemption);
        }

        /// <summary>
        /// (Expanded)
        /// The tax exemption associated with this certificate.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public CustomerTaxExemption TaxExemption
        {
            get => this.InternalTaxExemption?.ExpandedObject;
            set => this.InternalTaxExemption = SetExpandableFieldObject(value, this.InternalTaxExemption);
        }

        [JsonProperty("tax_exemption")]
        [JsonConverter(typeof(ExpandableFieldConverter<CustomerTaxExemption>))]
        [STJS.JsonPropertyName("tax_exemption")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<CustomerTaxExemption>))]
        internal ExpandableField<CustomerTaxExemption> InternalTaxExemption { get; set; }
        #endregion
    }
}
