// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsOptions : INestedOptions, IHasSetTracking
    {
        private InvoicePaymentSettingsPaymentMethodOptionsAcssDebitOptions acssDebit;
        private InvoicePaymentSettingsPaymentMethodOptionsBancontactOptions bancontact;
        private InvoicePaymentSettingsPaymentMethodOptionsCardOptions card;
        private InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOptions customerBalance;
        private InvoicePaymentSettingsPaymentMethodOptionsKonbiniOptions konbini;
        private InvoicePaymentSettingsPaymentMethodOptionsPaytoOptions payto;
        private InvoicePaymentSettingsPaymentMethodOptionsPixOptions pix;
        private InvoicePaymentSettingsPaymentMethodOptionsSepaDebitOptions sepaDebit;
        private InvoicePaymentSettingsPaymentMethodOptionsUpiOptions upi;
        private InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountOptions usBankAccount;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// If paying by <c>acss_debit</c>, this sub-hash contains details about the Canadian
        /// pre-authorized debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("acss_debit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebitOptions AcssDebit
        {
            get => this.acssDebit;
            set
            {
                this.acssDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>bancontact</c>, this sub-hash contains details about the Bancontact
        /// payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("bancontact")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact
        {
            get => this.bancontact;
            set
            {
                this.bancontact = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>card</c>, this sub-hash contains details about the Card payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("card")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsCardOptions Card
        {
            get => this.card;
            set
            {
                this.card = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>customer_balance</c>, this sub-hash contains details about the Bank
        /// transfer payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_balance")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOptions CustomerBalance
        {
            get => this.customerBalance;
            set
            {
                this.customerBalance = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>konbini</c>, this sub-hash contains details about the Konbini payment
        /// method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("konbini", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("konbini")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsKonbiniOptions Konbini
        {
            get => this.konbini;
            set
            {
                this.konbini = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>payto</c>, this sub-hash contains details about the PayTo payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("payto", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("payto")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsPaytoOptions Payto
        {
            get => this.payto;
            set
            {
                this.payto = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>pix</c>, this sub-hash contains details about the Pix payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("pix", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("pix")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsPixOptions Pix
        {
            get => this.pix;
            set
            {
                this.pix = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>sepa_debit</c>, this sub-hash contains details about the SEPA Direct
        /// Debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("sepa_debit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsSepaDebitOptions SepaDebit
        {
            get => this.sepaDebit;
            set
            {
                this.sepaDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>upi</c>, this sub-hash contains details about the UPI payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("upi", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("upi")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsUpiOptions Upi
        {
            get => this.upi;
            set
            {
                this.upi = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>us_bank_account</c>, this sub-hash contains details about the ACH direct
        /// debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("us_bank_account", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("us_bank_account")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountOptions UsBankAccount
        {
            get => this.usBankAccount;
            set
            {
                this.usBankAccount = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
