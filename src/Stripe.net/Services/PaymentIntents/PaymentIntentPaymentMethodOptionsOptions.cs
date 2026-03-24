// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsOptions : INestedOptions, IHasSetTracking
    {
        private PaymentIntentPaymentMethodOptionsAcssDebitOptions acssDebit;
        private PaymentIntentPaymentMethodOptionsAffirmOptions affirm;
        private PaymentIntentPaymentMethodOptionsAfterpayClearpayOptions afterpayClearpay;
        private PaymentIntentPaymentMethodOptionsAlipayOptions alipay;
        private PaymentIntentPaymentMethodOptionsAlmaOptions alma;
        private PaymentIntentPaymentMethodOptionsAmazonPayOptions amazonPay;
        private PaymentIntentPaymentMethodOptionsAuBecsDebitOptions auBecsDebit;
        private PaymentIntentPaymentMethodOptionsBacsDebitOptions bacsDebit;
        private PaymentIntentPaymentMethodOptionsBancontactOptions bancontact;
        private PaymentIntentPaymentMethodOptionsBillieOptions billie;
        private PaymentIntentPaymentMethodOptionsBlikOptions blik;
        private PaymentIntentPaymentMethodOptionsBoletoOptions boleto;
        private PaymentIntentPaymentMethodOptionsCardOptions card;
        private PaymentIntentPaymentMethodOptionsCardPresentOptions cardPresent;
        private PaymentIntentPaymentMethodOptionsCashappOptions cashapp;
        private PaymentIntentPaymentMethodOptionsCryptoOptions crypto;
        private PaymentIntentPaymentMethodOptionsCustomerBalanceOptions customerBalance;
        private PaymentIntentPaymentMethodOptionsEpsOptions eps;
        private PaymentIntentPaymentMethodOptionsFpxOptions fpx;
        private PaymentIntentPaymentMethodOptionsGiropayOptions giropay;
        private PaymentIntentPaymentMethodOptionsGrabpayOptions grabpay;
        private PaymentIntentPaymentMethodOptionsIdealOptions ideal;
        private PaymentIntentPaymentMethodOptionsInteracPresentOptions interacPresent;
        private PaymentIntentPaymentMethodOptionsKakaoPayOptions kakaoPay;
        private PaymentIntentPaymentMethodOptionsKlarnaOptions klarna;
        private PaymentIntentPaymentMethodOptionsKonbiniOptions konbini;
        private PaymentIntentPaymentMethodOptionsKrCardOptions krCard;
        private PaymentIntentPaymentMethodOptionsLinkOptions link;
        private PaymentIntentPaymentMethodOptionsMbWayOptions mbWay;
        private PaymentIntentPaymentMethodOptionsMobilepayOptions mobilepay;
        private PaymentIntentPaymentMethodOptionsMultibancoOptions multibanco;
        private PaymentIntentPaymentMethodOptionsNaverPayOptions naverPay;
        private PaymentIntentPaymentMethodOptionsNzBankAccountOptions nzBankAccount;
        private PaymentIntentPaymentMethodOptionsOxxoOptions oxxo;
        private PaymentIntentPaymentMethodOptionsP24Options p24;
        private PaymentIntentPaymentMethodOptionsPayByBankOptions payByBank;
        private PaymentIntentPaymentMethodOptionsPaycoOptions payco;
        private PaymentIntentPaymentMethodOptionsPaynowOptions paynow;
        private PaymentIntentPaymentMethodOptionsPaypalOptions paypal;
        private PaymentIntentPaymentMethodOptionsPaytoOptions payto;
        private PaymentIntentPaymentMethodOptionsPixOptions pix;
        private PaymentIntentPaymentMethodOptionsPromptpayOptions promptpay;
        private PaymentIntentPaymentMethodOptionsRevolutPayOptions revolutPay;
        private PaymentIntentPaymentMethodOptionsSamsungPayOptions samsungPay;
        private PaymentIntentPaymentMethodOptionsSatispayOptions satispay;
        private PaymentIntentPaymentMethodOptionsSepaDebitOptions sepaDebit;
        private PaymentIntentPaymentMethodOptionsSofortOptions sofort;
        private PaymentIntentPaymentMethodOptionsSwishOptions swish;
        private PaymentIntentPaymentMethodOptionsTwintOptions twint;
        private PaymentIntentPaymentMethodOptionsUpiOptions upi;
        private PaymentIntentPaymentMethodOptionsUsBankAccountOptions usBankAccount;
        private PaymentIntentPaymentMethodOptionsWechatPayOptions wechatPay;
        private PaymentIntentPaymentMethodOptionsZipOptions zip;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// If this is a <c>acss_debit</c> PaymentMethod, this sub-hash contains details about the
        /// ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public PaymentIntentPaymentMethodOptionsAcssDebitOptions AcssDebit
        {
            get => this.acssDebit;
            set
            {
                this.acssDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is an <c>affirm</c> PaymentMethod, this sub-hash contains details about the
        /// Affirm payment method options.
        /// </summary>
        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public PaymentIntentPaymentMethodOptionsAffirmOptions Affirm
        {
            get => this.affirm;
            set
            {
                this.affirm = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>afterpay_clearpay</c> PaymentMethod, this sub-hash contains details
        /// about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public PaymentIntentPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay
        {
            get => this.afterpayClearpay;
            set
            {
                this.afterpayClearpay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>alipay</c> PaymentMethod, this sub-hash contains details about the
        /// Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipayOptions Alipay
        {
            get => this.alipay;
            set
            {
                this.alipay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>alma</c> PaymentMethod, this sub-hash contains details about the Alma
        /// payment method options.
        /// </summary>
        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public PaymentIntentPaymentMethodOptionsAlmaOptions Alma
        {
            get => this.alma;
            set
            {
                this.alma = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>amazon_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Amazon Pay payment method options.
        /// </summary>
        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentIntentPaymentMethodOptionsAmazonPayOptions AmazonPay
        {
            get => this.amazonPay;
            set
            {
                this.amazonPay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>au_becs_debit</c> PaymentMethod, this sub-hash contains details about
        /// the AU BECS Direct Debit payment method options.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public PaymentIntentPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit
        {
            get => this.auBecsDebit;
            set
            {
                this.auBecsDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this sub-hash contains details about the
        /// BACS Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public PaymentIntentPaymentMethodOptionsBacsDebitOptions BacsDebit
        {
            get => this.bacsDebit;
            set
            {
                this.bacsDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this sub-hash contains details about the
        /// Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontactOptions Bancontact
        {
            get => this.bancontact;
            set
            {
                this.bancontact = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>billie</c> PaymentMethod, this sub-hash contains details about the
        /// Billie payment method options.
        /// </summary>
        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public PaymentIntentPaymentMethodOptionsBillieOptions Billie
        {
            get => this.billie;
            set
            {
                this.billie = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this sub-hash contains details about the BLIK
        /// payment method options.
        /// </summary>
        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public PaymentIntentPaymentMethodOptionsBlikOptions Blik
        {
            get => this.blik;
            set
            {
                this.blik = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>boleto</c> PaymentMethod, this sub-hash contains details about the
        /// Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public PaymentIntentPaymentMethodOptionsBoletoOptions Boleto
        {
            get => this.boleto;
            set
            {
                this.boleto = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Configuration for any card payments attempted on this PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card
        {
            get => this.card;
            set
            {
                this.card = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>card_present</c> PaymentMethod, this sub-hash contains details about the
        /// Card Present payment method options.
        /// </summary>
        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public PaymentIntentPaymentMethodOptionsCardPresentOptions CardPresent
        {
            get => this.cardPresent;
            set
            {
                this.cardPresent = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>cashapp</c> PaymentMethod, this sub-hash contains details about the Cash
        /// App Pay payment method options.
        /// </summary>
        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public PaymentIntentPaymentMethodOptionsCashappOptions Cashapp
        {
            get => this.cashapp;
            set
            {
                this.cashapp = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>crypto</c> PaymentMethod, this sub-hash contains details about the
        /// Crypto payment method options.
        /// </summary>
        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentIntentPaymentMethodOptionsCryptoOptions Crypto
        {
            get => this.crypto;
            set
            {
                this.crypto = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>customer balance</c> PaymentMethod, this sub-hash contains details about
        /// the customer balance payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public PaymentIntentPaymentMethodOptionsCustomerBalanceOptions CustomerBalance
        {
            get => this.customerBalance;
            set
            {
                this.customerBalance = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>eps</c> PaymentMethod, this sub-hash contains details about the EPS
        /// payment method options.
        /// </summary>
        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public PaymentIntentPaymentMethodOptionsEpsOptions Eps
        {
            get => this.eps;
            set
            {
                this.eps = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>fpx</c> PaymentMethod, this sub-hash contains details about the FPX
        /// payment method options.
        /// </summary>
        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public PaymentIntentPaymentMethodOptionsFpxOptions Fpx
        {
            get => this.fpx;
            set
            {
                this.fpx = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this sub-hash contains details about the
        /// Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public PaymentIntentPaymentMethodOptionsGiropayOptions Giropay
        {
            get => this.giropay;
            set
            {
                this.giropay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>gopay</c> PaymentMethod, this sub-hash contains details about the Gopay
        /// payment method options.
        /// </summary>
        [JsonProperty("gopay")]
        [STJS.JsonPropertyName("gopay")]
        public PaymentIntentPaymentMethodOptionsGopayOptions Gopay { get; set; }

        /// <summary>
        /// If this is a <c>grabpay</c> PaymentMethod, this sub-hash contains details about the
        /// Grabpay payment method options.
        /// </summary>
        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public PaymentIntentPaymentMethodOptionsGrabpayOptions Grabpay
        {
            get => this.grabpay;
            set
            {
                this.grabpay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>id_bank_transfer</c> PaymentMethod, this sub-hash contains details about
        /// the Indonesia Bank Transfer payment method options.
        /// </summary>
        [JsonProperty("id_bank_transfer")]
        [STJS.JsonPropertyName("id_bank_transfer")]
        public PaymentIntentPaymentMethodOptionsIdBankTransferOptions IdBankTransfer { get; set; }

        /// <summary>
        /// If this is a <c>ideal</c> PaymentMethod, this sub-hash contains details about the Ideal
        /// payment method options.
        /// </summary>
        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public PaymentIntentPaymentMethodOptionsIdealOptions Ideal
        {
            get => this.ideal;
            set
            {
                this.ideal = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>interac_present</c> PaymentMethod, this sub-hash contains details about
        /// the Card Present payment method options.
        /// </summary>
        [JsonProperty("interac_present")]
        [STJS.JsonPropertyName("interac_present")]
        public PaymentIntentPaymentMethodOptionsInteracPresentOptions InteracPresent
        {
            get => this.interacPresent;
            set
            {
                this.interacPresent = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>kakao_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Kakao Pay payment method options.
        /// </summary>
        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public PaymentIntentPaymentMethodOptionsKakaoPayOptions KakaoPay
        {
            get => this.kakaoPay;
            set
            {
                this.kakaoPay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this sub-hash contains details about the
        /// Klarna payment method options.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentIntentPaymentMethodOptionsKlarnaOptions Klarna
        {
            get => this.klarna;
            set
            {
                this.klarna = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>konbini</c> PaymentMethod, this sub-hash contains details about the
        /// Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public PaymentIntentPaymentMethodOptionsKonbiniOptions Konbini
        {
            get => this.konbini;
            set
            {
                this.konbini = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>kr_card</c> PaymentMethod, this sub-hash contains details about the KR
        /// Card payment method options.
        /// </summary>
        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public PaymentIntentPaymentMethodOptionsKrCardOptions KrCard
        {
            get => this.krCard;
            set
            {
                this.krCard = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>link</c> PaymentMethod, this sub-hash contains details about the Link
        /// payment method options.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentIntentPaymentMethodOptionsLinkOptions Link
        {
            get => this.link;
            set
            {
                this.link = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>mb_way</c> PaymentMethod, this sub-hash contains details about the MB
        /// WAY payment method options.
        /// </summary>
        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public PaymentIntentPaymentMethodOptionsMbWayOptions MbWay
        {
            get => this.mbWay;
            set
            {
                this.mbWay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>MobilePay</c> PaymentMethod, this sub-hash contains details about the
        /// MobilePay payment method options.
        /// </summary>
        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public PaymentIntentPaymentMethodOptionsMobilepayOptions Mobilepay
        {
            get => this.mobilepay;
            set
            {
                this.mobilepay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>multibanco</c> PaymentMethod, this sub-hash contains details about the
        /// Multibanco payment method options.
        /// </summary>
        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public PaymentIntentPaymentMethodOptionsMultibancoOptions Multibanco
        {
            get => this.multibanco;
            set
            {
                this.multibanco = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>naver_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Naver Pay payment method options.
        /// </summary>
        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public PaymentIntentPaymentMethodOptionsNaverPayOptions NaverPay
        {
            get => this.naverPay;
            set
            {
                this.naverPay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>nz_bank_account</c> PaymentMethod, this sub-hash contains details about
        /// the NZ BECS Direct Debit payment method options.
        /// </summary>
        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public PaymentIntentPaymentMethodOptionsNzBankAccountOptions NzBankAccount
        {
            get => this.nzBankAccount;
            set
            {
                this.nzBankAccount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>oxxo</c> PaymentMethod, this sub-hash contains details about the OXXO
        /// payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public PaymentIntentPaymentMethodOptionsOxxoOptions Oxxo
        {
            get => this.oxxo;
            set
            {
                this.oxxo = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this sub-hash contains details about the
        /// Przelewy24 payment method options.
        /// </summary>
        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public PaymentIntentPaymentMethodOptionsP24Options P24
        {
            get => this.p24;
            set
            {
                this.p24 = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>pay_by_bank</c> PaymentMethod, this sub-hash contains details about the
        /// PayByBank payment method options.
        /// </summary>
        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public PaymentIntentPaymentMethodOptionsPayByBankOptions PayByBank
        {
            get => this.payByBank;
            set
            {
                this.payByBank = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>payco</c> PaymentMethod, this sub-hash contains details about the PAYCO
        /// payment method options.
        /// </summary>
        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public PaymentIntentPaymentMethodOptionsPaycoOptions Payco
        {
            get => this.payco;
            set
            {
                this.payco = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>paynow</c> PaymentMethod, this sub-hash contains details about the
        /// PayNow payment method options.
        /// </summary>
        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public PaymentIntentPaymentMethodOptionsPaynowOptions Paynow
        {
            get => this.paynow;
            set
            {
                this.paynow = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this sub-hash contains details about the
        /// PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentIntentPaymentMethodOptionsPaypalOptions Paypal
        {
            get => this.paypal;
            set
            {
                this.paypal = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>paypay</c> PaymentMethod, this sub-hash contains details about the
        /// PayPay payment method options.
        /// </summary>
        [JsonProperty("paypay")]
        [STJS.JsonPropertyName("paypay")]
        public PaymentIntentPaymentMethodOptionsPaypayOptions Paypay { get; set; }

        /// <summary>
        /// If this is a <c>payto</c> PaymentMethod, this sub-hash contains details about the PayTo
        /// payment method options.
        /// </summary>
        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public PaymentIntentPaymentMethodOptionsPaytoOptions Payto
        {
            get => this.payto;
            set
            {
                this.payto = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>pix</c> PaymentMethod, this sub-hash contains details about the Pix
        /// payment method options.
        /// </summary>
        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public PaymentIntentPaymentMethodOptionsPixOptions Pix
        {
            get => this.pix;
            set
            {
                this.pix = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>promptpay</c> PaymentMethod, this sub-hash contains details about the
        /// PromptPay payment method options.
        /// </summary>
        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public PaymentIntentPaymentMethodOptionsPromptpayOptions Promptpay
        {
            get => this.promptpay;
            set
            {
                this.promptpay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>qris</c> PaymentMethod, this sub-hash contains details about the QRIS
        /// payment method options.
        /// </summary>
        [JsonProperty("qris")]
        [STJS.JsonPropertyName("qris")]
        public PaymentIntentPaymentMethodOptionsQrisOptions Qris { get; set; }

        /// <summary>
        /// If this is a <c>rechnung</c> PaymentMethod, this sub-hash contains details about the
        /// Rechnung payment method options.
        /// </summary>
        [JsonProperty("rechnung")]
        [STJS.JsonPropertyName("rechnung")]
        public PaymentIntentPaymentMethodOptionsRechnungOptions Rechnung { get; set; }

        /// <summary>
        /// If this is a <c>revolut_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Revolut Pay payment method options.
        /// </summary>
        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public PaymentIntentPaymentMethodOptionsRevolutPayOptions RevolutPay
        {
            get => this.revolutPay;
            set
            {
                this.revolutPay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>samsung_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Samsung Pay payment method options.
        /// </summary>
        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public PaymentIntentPaymentMethodOptionsSamsungPayOptions SamsungPay
        {
            get => this.samsungPay;
            set
            {
                this.samsungPay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>satispay</c> PaymentMethod, this sub-hash contains details about the
        /// Satispay payment method options.
        /// </summary>
        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public PaymentIntentPaymentMethodOptionsSatispayOptions Satispay
        {
            get => this.satispay;
            set
            {
                this.satispay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public PaymentIntentPaymentMethodOptionsSepaDebitOptions SepaDebit
        {
            get => this.sepaDebit;
            set
            {
                this.sepaDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>shopeepay</c> PaymentMethod, this sub-hash contains details about the
        /// ShopeePay payment method options.
        /// </summary>
        [JsonProperty("shopeepay")]
        [STJS.JsonPropertyName("shopeepay")]
        public PaymentIntentPaymentMethodOptionsShopeepayOptions Shopeepay { get; set; }

        /// <summary>
        /// If this is a <c>sofort</c> PaymentMethod, this sub-hash contains details about the
        /// SOFORT payment method options.
        /// </summary>
        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public PaymentIntentPaymentMethodOptionsSofortOptions Sofort
        {
            get => this.sofort;
            set
            {
                this.sofort = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>stripe_balance</c> PaymentMethod, this sub-hash contains details about
        /// the Stripe Balance payment method options.
        /// </summary>
        [JsonProperty("stripe_balance")]
        [STJS.JsonPropertyName("stripe_balance")]
        public PaymentIntentPaymentMethodOptionsStripeBalanceOptions StripeBalance { get; set; }

        /// <summary>
        /// If this is a <c>Swish</c> PaymentMethod, this sub-hash contains details about the Swish
        /// payment method options.
        /// </summary>
        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public PaymentIntentPaymentMethodOptionsSwishOptions Swish
        {
            get => this.swish;
            set
            {
                this.swish = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>twint</c> PaymentMethod, this sub-hash contains details about the TWINT
        /// payment method options.
        /// </summary>
        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public PaymentIntentPaymentMethodOptionsTwintOptions Twint
        {
            get => this.twint;
            set
            {
                this.twint = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>us_bank_account</c> PaymentMethod, this sub-hash contains details about
        /// the US bank account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentIntentPaymentMethodOptionsUsBankAccountOptions UsBankAccount
        {
            get => this.usBankAccount;
            set
            {
                this.usBankAccount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>wechat_pay</c> PaymentMethod, this sub-hash contains details about the
        /// WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public PaymentIntentPaymentMethodOptionsWechatPayOptions WechatPay
        {
            get => this.wechatPay;
            set
            {
                this.wechatPay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If this is a <c>zip</c> PaymentMethod, this sub-hash contains details about the Zip
        /// payment method options.
        /// </summary>
        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public PaymentIntentPaymentMethodOptionsZipOptions Zip
        {
            get => this.zip;
            set
            {
                this.zip = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
