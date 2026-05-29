// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsOptions : INestedOptions, IHasSetTracking
    {
        private SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitOptions acssDebit;
        private SubscriptionPaymentSettingsPaymentMethodOptionsBancontactOptions bancontact;
        private SubscriptionPaymentSettingsPaymentMethodOptionsBizumOptions bizum;
        private SubscriptionPaymentSettingsPaymentMethodOptionsBlikOptions blik;
        private SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions card;
        private SubscriptionPaymentSettingsPaymentMethodOptionsCheckScanOptions checkScan;
        private SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions customerBalance;
        private SubscriptionPaymentSettingsPaymentMethodOptionsIdBankTransferOptions idBankTransfer;
        private SubscriptionPaymentSettingsPaymentMethodOptionsKonbiniOptions konbini;
        private SubscriptionPaymentSettingsPaymentMethodOptionsPaytoOptions payto;
        private SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions pix;
        private SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebitOptions sepaDebit;
        private SubscriptionPaymentSettingsPaymentMethodOptionsUpiOptions upi;
        private SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOptions usBankAccount;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("acss_debit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitOptions AcssDebit
        {
            get => this.acssDebit;
            set
            {
                this.acssDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("bancontact")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact
        {
            get => this.bancontact;
            set
            {
                this.bancontact = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Bizum payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bizum", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("bizum")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBizumOptions Bizum
        {
            get => this.bizum;
            set
            {
                this.bizum = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Blik payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("blik", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("blik")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBlikOptions Blik
        {
            get => this.blik;
            set
            {
                this.blik = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("card")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions Card
        {
            get => this.card;
            set
            {
                this.card = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Check Scan payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("check_scan", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("check_scan")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCheckScanOptions CheckScan
        {
            get => this.checkScan;
            set
            {
                this.checkScan = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_balance")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions CustomerBalance
        {
            get => this.customerBalance;
            set
            {
                this.customerBalance = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Indonesia bank transfer payment method options
        /// to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("id_bank_transfer", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("id_bank_transfer")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsIdBankTransferOptions IdBankTransfer
        {
            get => this.idBankTransfer;
            set
            {
                this.idBankTransfer = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("konbini", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("konbini")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsKonbiniOptions Konbini
        {
            get => this.konbini;
            set
            {
                this.konbini = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the PayTo payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("payto", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("payto")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsPaytoOptions Payto
        {
            get => this.payto;
            set
            {
                this.payto = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the Pix payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("pix", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("pix")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions Pix
        {
            get => this.pix;
            set
            {
                this.pix = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the SEPA Direct Debit payment method options to
        /// pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("sepa_debit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebitOptions SepaDebit
        {
            get => this.sepaDebit;
            set
            {
                this.sepaDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the UPI payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("upi", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("upi")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUpiOptions Upi
        {
            get => this.upi;
            set
            {
                this.upi = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options to pass
        /// to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("us_bank_account", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("us_bank_account")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOptions UsBankAccount
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
