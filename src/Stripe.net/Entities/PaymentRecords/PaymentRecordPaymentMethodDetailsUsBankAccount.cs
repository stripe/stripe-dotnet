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
    public class PaymentRecordPaymentMethodDetailsUsBankAccount : StripeEntity<PaymentRecordPaymentMethodDetailsUsBankAccount>
    {
        /// <summary>
        /// The type of entity that holds the account. This can be either 'individual' or 'company'.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_type")]
#endif
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The type of the bank account. This can be either 'checking' or 'savings'.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_type")]
#endif
        public string AccountType { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        #region Expandable Mandate

        /// <summary>
        /// (ID of the Mandate)
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string MandateId
        {
            get => this.InternalMandate?.Id;
            set => this.InternalMandate = SetExpandableFieldId(value, this.InternalMandate);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the mandate used to make this payment.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Mandate Mandate
        {
            get => this.InternalMandate?.ExpandedObject;
            set => this.InternalMandate = SetExpandableFieldObject(value, this.InternalMandate);
        }

        [JsonProperty("mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Mandate>))]
#endif
        internal ExpandableField<Mandate> InternalMandate { get; set; }
        #endregion

        /// <summary>
        /// The ACH payment reference for this transaction.
        /// </summary>
        [JsonProperty("payment_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_reference")]
#endif
        public string PaymentReference { get; set; }

        /// <summary>
        /// The routing number for the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }
    }
}
