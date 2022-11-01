// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// You can add one or multiple tax IDs to a <a
    /// href="https://stripe.com/docs/api/customers">customer</a>. A customer's tax IDs are
    /// displayed on invoices and credit notes issued for the customer.
    ///
    /// Related guide: <a href="https://stripe.com/docs/billing/taxes/tax-ids">Customer Tax
    /// Identification Numbers</a>.
    /// </summary>
    public class TaxId : StripeEntity<TaxId>, IHasId, IHasObject
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

        /// <summary>
        /// Two-letter ISO code representing the country of the tax ID.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Type of the tax ID, one of <c>ae_trn</c>, <c>au_abn</c>, <c>au_arn</c>, <c>bg_uic</c>,
        /// <c>br_cnpj</c>, <c>br_cpf</c>, <c>ca_bn</c>, <c>ca_gst_hst</c>, <c>ca_pst_bc</c>,
        /// <c>ca_pst_mb</c>, <c>ca_pst_sk</c>, <c>ca_qst</c>, <c>ch_vat</c>, <c>cl_tin</c>,
        /// <c>eg_tin</c>, <c>es_cif</c>, <c>eu_oss_vat</c>, <c>eu_vat</c>, <c>gb_vat</c>,
        /// <c>ge_vat</c>, <c>hk_br</c>, <c>hu_tin</c>, <c>id_npwp</c>, <c>il_vat</c>,
        /// <c>in_gst</c>, <c>is_vat</c>, <c>jp_cn</c>, <c>jp_rn</c>, <c>jp_trn</c>, <c>ke_pin</c>,
        /// <c>kr_brn</c>, <c>li_uid</c>, <c>mx_rfc</c>, <c>my_frp</c>, <c>my_itn</c>,
        /// <c>my_sst</c>, <c>no_vat</c>, <c>nz_gst</c>, <c>ph_tin</c>, <c>ru_inn</c>,
        /// <c>ru_kpp</c>, <c>sa_vat</c>, <c>sg_gst</c>, <c>sg_uen</c>, <c>si_tin</c>,
        /// <c>th_vat</c>, <c>tr_tin</c>, <c>tw_vat</c>, <c>ua_vat</c>, <c>us_ein</c>, or
        /// <c>za_vat</c>. Note that some legacy tax IDs have type <c>unknown</c>.
        /// One of: <c>ae_trn</c>, <c>au_abn</c>, <c>au_arn</c>, <c>bg_uic</c>, <c>br_cnpj</c>,
        /// <c>br_cpf</c>, <c>ca_bn</c>, <c>ca_gst_hst</c>, <c>ca_pst_bc</c>, <c>ca_pst_mb</c>,
        /// <c>ca_pst_sk</c>, <c>ca_qst</c>, <c>ch_vat</c>, <c>cl_tin</c>, <c>eg_tin</c>,
        /// <c>es_cif</c>, <c>eu_oss_vat</c>, <c>eu_vat</c>, <c>gb_vat</c>, <c>ge_vat</c>,
        /// <c>hk_br</c>, <c>hu_tin</c>, <c>id_npwp</c>, <c>il_vat</c>, <c>in_gst</c>,
        /// <c>is_vat</c>, <c>jp_cn</c>, <c>jp_rn</c>, <c>jp_trn</c>, <c>ke_pin</c>, <c>kr_brn</c>,
        /// <c>li_uid</c>, <c>mx_rfc</c>, <c>my_frp</c>, <c>my_itn</c>, <c>my_sst</c>,
        /// <c>no_vat</c>, <c>nz_gst</c>, <c>ph_tin</c>, <c>ru_inn</c>, <c>ru_kpp</c>,
        /// <c>sa_vat</c>, <c>sg_gst</c>, <c>sg_uen</c>, <c>si_tin</c>, <c>th_vat</c>,
        /// <c>tr_tin</c>, <c>tw_vat</c>, <c>ua_vat</c>, <c>unknown</c>, <c>us_ein</c>, or
        /// <c>za_vat</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value of the tax ID.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Tax ID verification information.
        /// </summary>
        [JsonProperty("verification")]
        public TaxIdVerification Verification { get; set; }
    }
}
