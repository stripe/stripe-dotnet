// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsBancontact : StripeEntity<ChargePaymentMethodDetailsBancontact>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif
        public string BankCode { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// Bank Identifier Code of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bic")]
#endif
        public string Bic { get; set; }

        #region Expandable GeneratedSepaDebit

        /// <summary>
        /// (ID of the PaymentMethod)
        /// The ID of the SEPA Direct Debit PaymentMethod which was generated by this Charge.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string GeneratedSepaDebitId
        {
            get => this.InternalGeneratedSepaDebit?.Id;
            set => this.InternalGeneratedSepaDebit = SetExpandableFieldId(value, this.InternalGeneratedSepaDebit);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SEPA Direct Debit PaymentMethod which was generated by this Charge.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentMethod GeneratedSepaDebit
        {
            get => this.InternalGeneratedSepaDebit?.ExpandedObject;
            set => this.InternalGeneratedSepaDebit = SetExpandableFieldObject(value, this.InternalGeneratedSepaDebit);
        }

        [JsonProperty("generated_sepa_debit")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("generated_sepa_debit")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
#endif
        internal ExpandableField<PaymentMethod> InternalGeneratedSepaDebit { get; set; }
        #endregion

        #region Expandable GeneratedSepaDebitMandate

        /// <summary>
        /// (ID of the Mandate)
        /// The mandate for the SEPA Direct Debit PaymentMethod which was generated by this Charge.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string GeneratedSepaDebitMandateId
        {
            get => this.InternalGeneratedSepaDebitMandate?.Id;
            set => this.InternalGeneratedSepaDebitMandate = SetExpandableFieldId(value, this.InternalGeneratedSepaDebitMandate);
        }

        /// <summary>
        /// (Expanded)
        /// The mandate for the SEPA Direct Debit PaymentMethod which was generated by this Charge.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Mandate GeneratedSepaDebitMandate
        {
            get => this.InternalGeneratedSepaDebitMandate?.ExpandedObject;
            set => this.InternalGeneratedSepaDebitMandate = SetExpandableFieldObject(value, this.InternalGeneratedSepaDebitMandate);
        }

        [JsonProperty("generated_sepa_debit_mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("generated_sepa_debit_mandate")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Mandate>))]
#endif
        internal ExpandableField<Mandate> InternalGeneratedSepaDebitMandate { get; set; }
        #endregion

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("iban_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban_last4")]
#endif
        public string IbanLast4 { get; set; }

        /// <summary>
        /// Preferred language of the Bancontact authorization page that the customer is redirected
        /// to. Can be one of <c>en</c>, <c>de</c>, <c>fr</c>, or <c>nl</c>.
        /// One of: <c>de</c>, <c>en</c>, <c>fr</c>, or <c>nl</c>.
        /// </summary>
        [JsonProperty("preferred_language")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_language")]
#endif
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by Bancontact directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_name")]
#endif
        public string VerifiedName { get; set; }
    }
}
