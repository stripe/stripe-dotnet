// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsUsBankAccount : StripeEntity<ChargePaymentMethodDetailsUsBankAccount>
    {
        /// <summary>
        /// Account holder type: individual or company.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// Account type: checkings or savings. Defaults to checking if omitted.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        #region Expandable Mandate

        /// <summary>
        /// (ID of the Mandate)
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonIgnore]
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
        public Mandate Mandate
        {
            get => this.InternalMandate?.ExpandedObject;
            set => this.InternalMandate = SetExpandableFieldObject(value, this.InternalMandate);
        }

        [JsonProperty("mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
        internal ExpandableField<Mandate> InternalMandate { get; set; }
        #endregion

        /// <summary>
        /// Reference number to locate ACH payments with customer's bank.
        /// </summary>
        [JsonProperty("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// Routing number of the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
