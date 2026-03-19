// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodConfigurationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Canadian pre-authorized debit payments, check this <a
        /// href="https://docs.stripe.com/payments/acss-debit">page</a> for more details like
        /// country availability.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public PaymentMethodConfigurationAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// Whether the configuration can be used for new payments.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <a href="https://www.affirm.com/">Affirm</a> gives your customers a way to split
        /// purchases over a series of payments. Depending on the purchase, they can pay with four
        /// interest-free payments (Split Pay) or pay over a longer term (Installments), which might
        /// include interest. Check this <a href="https://docs.stripe.com/payments/affirm">page</a>
        /// for more details like country availability.
        /// </summary>
        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public PaymentMethodConfigurationAffirmOptions Affirm { get; set; }

        /// <summary>
        /// Afterpay gives your customers a way to pay for purchases in installments, check this <a
        /// href="https://docs.stripe.com/payments/afterpay-clearpay">page</a> for more details like
        /// country availability. Afterpay is particularly popular among businesses selling fashion,
        /// beauty, and sports products.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public PaymentMethodConfigurationAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// Alipay is a digital wallet in China that has more than a billion active users worldwide.
        /// Alipay users can pay on the web or on a mobile device using login credentials or their
        /// Alipay app. Alipay has a low dispute rate and reduces fraud by authenticating payments
        /// using the customer's login credentials. Check this <a
        /// href="https://docs.stripe.com/payments/alipay">page</a> for more details.
        /// </summary>
        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public PaymentMethodConfigurationAlipayOptions Alipay { get; set; }

        /// <summary>
        /// Alma is a Buy Now, Pay Later payment method that offers customers the ability to pay in
        /// 2, 3, or 4 installments.
        /// </summary>
        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public PaymentMethodConfigurationAlmaOptions Alma { get; set; }

        /// <summary>
        /// Amazon Pay is a wallet payment method that lets your customers check out the same way as
        /// on Amazon.
        /// </summary>
        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentMethodConfigurationAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// Stripe users can accept <a href="https://stripe.com/payments/apple-pay">Apple Pay</a> in
        /// iOS applications in iOS 9 and later, and on the web in Safari starting with iOS 10 or
        /// macOS Sierra. There are no additional fees to process Apple Pay payments, and the <a
        /// href="https://stripe.com/pricing">pricing</a> is the same as other card transactions.
        /// Check this <a href="https://docs.stripe.com/apple-pay">page</a> for more details.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public PaymentMethodConfigurationApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Apple Pay Later, a payment method for customers to buy now and pay later, gives your
        /// customers a way to split purchases into four installments across six weeks.
        /// </summary>
        [JsonProperty("apple_pay_later")]
        [STJS.JsonPropertyName("apple_pay_later")]
        public PaymentMethodConfigurationApplePayLaterOptions ApplePayLater { get; set; }

        /// <summary>
        /// Stripe users in Australia can accept Bulk Electronic Clearing System (BECS) direct debit
        /// payments from customers with an Australian bank account. Check this <a
        /// href="https://docs.stripe.com/payments/au-becs-debit">page</a> for more details.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public PaymentMethodConfigurationAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// Stripe users in the UK can accept Bacs Direct Debit payments from customers with a UK
        /// bank account, check this <a
        /// href="https://docs.stripe.com/payments/payment-methods/bacs-debit">page</a> for more
        /// details.
        /// </summary>
        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public PaymentMethodConfigurationBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// Bancontact is the most popular online payment method in Belgium, with over 15 million
        /// cards in circulation. <a href="https://docs.stripe.com/api/customers">Customers</a> use
        /// a Bancontact card or mobile app linked to a Belgian bank account to make online payments
        /// that are secure, guaranteed, and confirmed immediately. Check this <a
        /// href="https://docs.stripe.com/payments/bancontact">page</a> for more details.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public PaymentMethodConfigurationBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// Billie is a <a
        /// href="https://docs.stripe.com/payments/payment-methods#usage">single-use</a> payment
        /// method that offers businesses Pay by Invoice where they offer payment terms ranging from
        /// 7-120 days. Customers are redirected from your website or app, authorize the payment
        /// with Billie, then return to your website or app. You get <a
        /// href="https://stripe.com/payments/payment-methods#payment-notification">immediate
        /// notification</a> of whether the payment succeeded or failed.
        /// </summary>
        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public PaymentMethodConfigurationBillieOptions Billie { get; set; }

        /// <summary>
        /// BLIK is a <a href="https://docs.stripe.com/payments/payment-methods#usage">single
        /// use</a> payment method that requires customers to authenticate their payments. When
        /// customers want to pay online using BLIK, they request a six-digit code from their
        /// banking application and enter it into the payment collection form. Check this <a
        /// href="https://docs.stripe.com/payments/blik">page</a> for more details.
        /// </summary>
        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public PaymentMethodConfigurationBlikOptions Blik { get; set; }

        /// <summary>
        /// Boleto is an official (regulated by the Central Bank of Brazil) payment method in
        /// Brazil. Check this <a href="https://docs.stripe.com/payments/boleto">page</a> for more
        /// details.
        /// </summary>
        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public PaymentMethodConfigurationBoletoOptions Boleto { get; set; }

        /// <summary>
        /// Cards are a popular way for consumers and businesses to pay online or in person. Stripe
        /// supports global and local card networks.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentMethodConfigurationCardOptions Card { get; set; }

        /// <summary>
        /// Cartes Bancaires is France's local card network. More than 95% of these cards are
        /// co-branded with either Visa or Mastercard, meaning you can process these cards over
        /// either Cartes Bancaires or the Visa or Mastercard networks. Check this <a
        /// href="https://docs.stripe.com/payments/cartes-bancaires">page</a> for more details.
        /// </summary>
        [JsonProperty("cartes_bancaires")]
        [STJS.JsonPropertyName("cartes_bancaires")]
        public PaymentMethodConfigurationCartesBancairesOptions CartesBancaires { get; set; }

        /// <summary>
        /// Cash App is a popular consumer app in the US that allows customers to bank, invest,
        /// send, and receive money using their digital wallet. Check this <a
        /// href="https://docs.stripe.com/payments/cash-app-pay">page</a> for more details.
        /// </summary>
        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public PaymentMethodConfigurationCashappOptions Cashapp { get; set; }

        /// <summary>
        /// <a href="https://docs.stripe.com/payments/stablecoin-payments">Stablecoin payments</a>
        /// enable customers to pay in stablecoins like USDC from 100s of wallets including Phantom
        /// and Metamask.
        /// </summary>
        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentMethodConfigurationCryptoOptions Crypto { get; set; }

        /// <summary>
        /// Uses a customer’s <a href="https://docs.stripe.com/payments/customer-balance">cash
        /// balance</a> for the payment. The cash balance can be funded via a bank transfer. Check
        /// this <a href="https://docs.stripe.com/payments/bank-transfers">page</a> for more
        /// details.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public PaymentMethodConfigurationCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// EPS is an Austria-based payment method that allows customers to complete transactions
        /// online using their bank credentials. EPS is supported by all Austrian banks and is
        /// accepted by over 80% of Austrian online retailers. Check this <a
        /// href="https://docs.stripe.com/payments/eps">page</a> for more details.
        /// </summary>
        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public PaymentMethodConfigurationEpsOptions Eps { get; set; }

        /// <summary>
        /// Financial Process Exchange (FPX) is a Malaysia-based payment method that allows
        /// customers to complete transactions online using their bank credentials. Bank Negara
        /// Malaysia (BNM), the Central Bank of Malaysia, and eleven other major Malaysian financial
        /// institutions are members of the PayNet Group, which owns and operates FPX. It is one of
        /// the most popular online payment methods in Malaysia, with nearly 90 million transactions
        /// in 2018 according to BNM. Check this <a
        /// href="https://docs.stripe.com/payments/fpx">page</a> for more details.
        /// </summary>
        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public PaymentMethodConfigurationFpxOptions Fpx { get; set; }

        /// <summary>
        /// Meal vouchers in France, or “titres-restaurant”, is a local benefits program commonly
        /// offered by employers for their employees to purchase prepared food and beverages on
        /// working days. Check this <a
        /// href="https://docs.stripe.com/payments/meal-vouchers/fr-meal-vouchers">page</a> for more
        /// details.
        /// </summary>
        [JsonProperty("fr_meal_voucher_conecs")]
        [STJS.JsonPropertyName("fr_meal_voucher_conecs")]
        public PaymentMethodConfigurationFrMealVoucherConecsOptions FrMealVoucherConecs { get; set; }

        /// <summary>
        /// giropay is a German payment method based on online banking, introduced in 2006. It
        /// allows customers to complete transactions online using their online banking environment,
        /// with funds debited from their bank account. Depending on their bank, customers confirm
        /// payments on giropay using a second factor of authentication or a PIN. giropay accounts
        /// for 10% of online checkouts in Germany. Check this <a
        /// href="https://docs.stripe.com/payments/giropay">page</a> for more details.
        /// </summary>
        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public PaymentMethodConfigurationGiropayOptions Giropay { get; set; }

        /// <summary>
        /// Google Pay allows customers to make payments in your app or website using any credit or
        /// debit card saved to their Google Account, including those from Google Play, YouTube,
        /// Chrome, or an Android device. Use the Google Pay API to request any credit or debit card
        /// stored in your customer's Google account. Check this <a
        /// href="https://docs.stripe.com/google-pay">page</a> for more details.
        /// </summary>
        [JsonProperty("google_pay")]
        [STJS.JsonPropertyName("google_pay")]
        public PaymentMethodConfigurationGooglePayOptions GooglePay { get; set; }

        /// <summary>
        /// GoPay is a <a href="https://docs.stripe.com/payments/payment-methods#usage">single
        /// use</a> digital wallet payment method popular in Indonesia. When paying with GoPay,
        /// customers authenticate and approve payments using the Gojek app. Desktop checkout is
        /// performed by scanning a QR code. When checking out on mobile, customers are redirected
        /// to the Gojek app to confirm payment.
        /// </summary>
        [JsonProperty("gopay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gopay")]
#endif
        public PaymentMethodConfigurationGopayOptions Gopay { get; set; }

        /// <summary>
        /// GrabPay is a payment method developed by <a
        /// href="https://www.grab.com/sg/consumer/finance/pay/">Grab</a>. GrabPay is a digital
        /// wallet - customers maintain a balance in their wallets that they pay out with. Check
        /// this <a href="https://docs.stripe.com/payments/grabpay">page</a> for more details.
        /// </summary>
        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public PaymentMethodConfigurationGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// Stripe users in Indonesia can receive bank transfers from customers in Indonesia. Bank
        /// transfers are a popular B2C and B2B payment method in Indonesia.
        /// </summary>
        [JsonProperty("id_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_bank_transfer")]
#endif
        public PaymentMethodConfigurationIdBankTransferOptions IdBankTransfer { get; set; }

        /// <summary>
        /// iDEAL is a Netherlands-based payment method that allows customers to complete
        /// transactions online using their bank credentials. All major Dutch banks are members of
        /// Currence, the scheme that operates iDEAL, making it the most popular online payment
        /// method in the Netherlands with a share of online transactions close to 55%. Check this
        /// <a href="https://docs.stripe.com/payments/ideal">page</a> for more details.
        /// </summary>
        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public PaymentMethodConfigurationIdealOptions Ideal { get; set; }

        /// <summary>
        /// JCB is a credit card company based in Japan. JCB is currently available in Japan to
        /// businesses approved by JCB, and available to all businesses in Australia, Canada, Hong
        /// Kong, Japan, New Zealand, Singapore, Switzerland, United Kingdom, United States, and all
        /// countries in the European Economic Area except Iceland. Check this <a
        /// href="https://support.stripe.com/questions/accepting-japan-credit-bureau-%28jcb%29-payments">page</a>
        /// for more details.
        /// </summary>
        [JsonProperty("jcb")]
        [STJS.JsonPropertyName("jcb")]
        public PaymentMethodConfigurationJcbOptions Jcb { get; set; }

        /// <summary>
        /// Kakao Pay is a popular local wallet available in South Korea.
        /// </summary>
        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public PaymentMethodConfigurationKakaoPayOptions KakaoPay { get; set; }

        /// <summary>
        /// Klarna gives customers a range of <a
        /// href="https://docs.stripe.com/payments/klarna#payment-options">payment options</a>
        /// during checkout. Available payment options vary depending on the customer's billing
        /// address and the transaction amount. These payment options make it convenient for
        /// customers to purchase items in all price ranges. Check this <a
        /// href="https://docs.stripe.com/payments/klarna">page</a> for more details.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentMethodConfigurationKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// Konbini allows customers in Japan to pay for bills and online purchases at convenience
        /// stores with cash. Check this <a href="https://docs.stripe.com/payments/konbini">page</a>
        /// for more details.
        /// </summary>
        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public PaymentMethodConfigurationKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// Korean cards let users pay using locally issued cards from South Korea.
        /// </summary>
        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public PaymentMethodConfigurationKrCardOptions KrCard { get; set; }

        /// <summary>
        /// <a href="https://docs.stripe.com/payments/link">Link</a> is a payment method network.
        /// With Link, users save their payment details once, then reuse that information to pay
        /// with one click for any business on the network.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentMethodConfigurationLinkOptions Link { get; set; }

        /// <summary>
        /// MB WAY is the most popular wallet in Portugal. After entering their phone number in your
        /// checkout, customers approve the payment directly in their MB WAY app. Check this <a
        /// href="https://docs.stripe.com/payments/mb-way">page</a> for more details.
        /// </summary>
        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public PaymentMethodConfigurationMbWayOptions MbWay { get; set; }

        /// <summary>
        /// MobilePay is a <a
        /// href="https://docs.stripe.com/payments/payment-methods#usage">single-use</a> card wallet
        /// payment method used in Denmark and Finland. It allows customers to <a
        /// href="https://docs.stripe.com/payments/payment-methods#customer-actions">authenticate
        /// and approve</a> payments using the MobilePay app. Check this <a
        /// href="https://docs.stripe.com/payments/mobilepay">page</a> for more details.
        /// </summary>
        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public PaymentMethodConfigurationMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// Stripe users in Europe and the United States can accept Multibanco payments from
        /// customers in Portugal using <a href="https://stripe.com/docs/sources">Sources</a>—a
        /// single integration path for creating payments using any supported method.
        /// </summary>
        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public PaymentMethodConfigurationMultibancoOptions Multibanco { get; set; }

        /// <summary>
        /// Configuration name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Naver Pay is a popular local wallet available in South Korea.
        /// </summary>
        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public PaymentMethodConfigurationNaverPayOptions NaverPay { get; set; }

        /// <summary>
        /// Stripe users in New Zealand can accept Bulk Electronic Clearing System (BECS) direct
        /// debit payments from customers with a New Zeland bank account. Check this <a
        /// href="https://docs.stripe.com/payments/nz-bank-account">page</a> for more details.
        /// </summary>
        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public PaymentMethodConfigurationNzBankAccountOptions NzBankAccount { get; set; }

        /// <summary>
        /// OXXO is a Mexican chain of convenience stores with thousands of locations across Latin
        /// America and represents nearly 20% of online transactions in Mexico. OXXO allows
        /// customers to pay bills and online purchases in-store with cash. Check this <a
        /// href="https://docs.stripe.com/payments/oxxo">page</a> for more details.
        /// </summary>
        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public PaymentMethodConfigurationOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// Przelewy24 is a Poland-based payment method aggregator that allows customers to complete
        /// transactions online using bank transfers and other methods. Bank transfers account for
        /// 30% of online payments in Poland and Przelewy24 provides a way for customers to pay with
        /// over 165 banks. Check this <a href="https://docs.stripe.com/payments/p24">page</a> for
        /// more details.
        /// </summary>
        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public PaymentMethodConfigurationP24Options P24 { get; set; }

        /// <summary>
        /// Pay by bank is a redirect payment method backed by bank transfers. A customer is
        /// redirected to their bank to authorize a bank transfer for a given amount. This removes a
        /// lot of the error risks inherent in waiting for the customer to initiate a transfer
        /// themselves, and is less expensive than card payments.
        /// </summary>
        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public PaymentMethodConfigurationPayByBankOptions PayByBank { get; set; }

        /// <summary>
        /// PAYCO is a [single-use](https://docs.stripe.com/payments/payment-methods#usage local
        /// wallet available in South Korea.
        /// </summary>
        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public PaymentMethodConfigurationPaycoOptions Payco { get; set; }

        /// <summary>
        /// PayNow is a Singapore-based payment method that allows customers to make a payment using
        /// their preferred app from participating banks and participating non-bank financial
        /// institutions. Check this <a href="https://docs.stripe.com/payments/paynow">page</a> for
        /// more details.
        /// </summary>
        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public PaymentMethodConfigurationPaynowOptions Paynow { get; set; }

        /// <summary>
        /// PayPal, a digital wallet popular with customers in Europe, allows your customers
        /// worldwide to pay using their PayPal account. Check this <a
        /// href="https://docs.stripe.com/payments/paypal">page</a> for more details.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentMethodConfigurationPaypalOptions Paypal { get; set; }

        /// <summary>
        /// Customers can pay with PayPay online or using the PayPay app.
        /// </summary>
        [JsonProperty("paypay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay")]
#endif
        public PaymentMethodConfigurationPaypayOptions Paypay { get; set; }

        /// <summary>
        /// PayTo is a <a href="https://docs.stripe.com/payments/real-time">real-time</a> payment
        /// method that enables customers in Australia to pay by providing their bank account
        /// details. Customers must accept a mandate authorizing you to debit their account. Check
        /// this <a href="https://docs.stripe.com/payments/payto">page</a> for more details.
        /// </summary>
        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public PaymentMethodConfigurationPaytoOptions Payto { get; set; }

        /// <summary>
        /// Pix is a payment method popular in Brazil. When paying with Pix, customers authenticate
        /// and approve payments by scanning a QR code in their preferred banking app. Check this <a
        /// href="https://docs.stripe.com/payments/pix">page</a> for more details.
        /// </summary>
        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public PaymentMethodConfigurationPixOptions Pix { get; set; }

        /// <summary>
        /// PromptPay is a Thailand-based payment method that allows customers to make a payment
        /// using their preferred app from participating banks. Check this <a
        /// href="https://docs.stripe.com/payments/promptpay">page</a> for more details.
        /// </summary>
        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public PaymentMethodConfigurationPromptpayOptions Promptpay { get; set; }

        /// <summary>
        /// QRIS is a <a href="https://docs.stripe.com/payments/real-time">real-time</a> payment
        /// method popular in Indonesia. When paying with QRIS, customers authenticate and approve
        /// payments by scanning a QR code in their preferred digital wallet app.
        /// </summary>
        [JsonProperty("qris")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qris")]
#endif
        public PaymentMethodConfigurationQrisOptions Qris { get; set; }

        /// <summary>
        /// Revolut Pay, developed by Revolut, a global finance app, is a digital wallet payment
        /// method. Revolut Pay uses the customer’s stored balance or cards to fund the payment, and
        /// offers the option for non-Revolut customers to save their details after their first
        /// purchase.
        /// </summary>
        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public PaymentMethodConfigurationRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// Samsung Pay is a [single-use](https://docs.stripe.com/payments/payment-methods#usage
        /// local wallet available in South Korea.
        /// </summary>
        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public PaymentMethodConfigurationSamsungPayOptions SamsungPay { get; set; }

        /// <summary>
        /// Satispay is a <a
        /// href="https://docs.stripe.com/payments/payment-methods#usage">single-use</a> payment
        /// method where customers are required to <a
        /// href="https://stripe.com/payments/payment-methods#customer-actions">authenticate</a>
        /// their payment. Customers pay by being redirected from your website or app, authorizing
        /// the payment with Satispay, then returning to your website or app. You get <a
        /// href="https://stripe.com/payments/payment-methods#payment-notification">immediate
        /// notification</a> of whether the payment succeeded or failed.
        /// </summary>
        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public PaymentMethodConfigurationSatispayOptions Satispay { get; set; }

        /// <summary>
        /// The <a href="https://en.wikipedia.org/wiki/Single_Euro_Payments_Area">Single Euro
        /// Payments Area (SEPA)</a> is an initiative of the European Union to simplify payments
        /// within and across member countries. SEPA established and enforced banking standards to
        /// allow for the direct debiting of every EUR-denominated bank account within the SEPA
        /// region, check this <a href="https://docs.stripe.com/payments/sepa-debit">page</a> for
        /// more details.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public PaymentMethodConfigurationSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// ShopeePay is a <a href="https://docs.stripe.com/payments/payment-methods#usage">single
        /// use</a> digital wallet payment method popular in Indonesia. When paying with GoPay,
        /// customers authenticate and approve payments using the Shopee app. Desktop checkout is
        /// performed by scanning a QR code. When checking out on mobile, customers are redirected
        /// to the Shopee app to confirm payment.
        /// </summary>
        [JsonProperty("shopeepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shopeepay")]
#endif
        public PaymentMethodConfigurationShopeepayOptions Shopeepay { get; set; }

        /// <summary>
        /// Stripe users in Europe and the United States can use the <a
        /// href="https://stripe.com/docs/payments/payment-intents">Payment Intents API</a>—a single
        /// integration path for creating payments using any supported method—to accept <a
        /// href="https://www.sofort.com/">Sofort</a> payments from customers. Check this <a
        /// href="https://docs.stripe.com/payments/sofort">page</a> for more details.
        /// </summary>
        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public PaymentMethodConfigurationSofortOptions Sofort { get; set; }

        /// <summary>
        /// Swish is a <a href="https://docs.stripe.com/payments/real-time">real-time</a> payment
        /// method popular in Sweden. It allows customers to <a
        /// href="https://docs.stripe.com/payments/payment-methods#customer-actions">authenticate
        /// and approve</a> payments using the Swish mobile app and the Swedish BankID mobile app.
        /// Check this <a href="https://docs.stripe.com/payments/swish">page</a> for more details.
        /// </summary>
        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public PaymentMethodConfigurationSwishOptions Swish { get; set; }

        /// <summary>
        /// Twint is a payment method popular in Switzerland. It allows customers to pay using their
        /// mobile phone. Check this <a href="https://docs.stripe.com/payments/twint">page</a> for
        /// more details.
        /// </summary>
        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public PaymentMethodConfigurationTwintOptions Twint { get; set; }

        /// <summary>
        /// Stripe users in the United States can accept ACH direct debit payments from customers
        /// with a US bank account using the Automated Clearing House (ACH) payments system operated
        /// by Nacha. Check this <a
        /// href="https://docs.stripe.com/payments/ach-direct-debit">page</a> for more details.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentMethodConfigurationUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// WeChat, owned by Tencent, is China's leading mobile app with over 1 billion monthly
        /// active users. Chinese consumers can use WeChat Pay to pay for goods and services inside
        /// of businesses' apps and websites. WeChat Pay users buy most frequently in gaming,
        /// e-commerce, travel, online education, and food/nutrition. Check this <a
        /// href="https://docs.stripe.com/payments/wechat-pay">page</a> for more details.
        /// </summary>
        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public PaymentMethodConfigurationWechatPayOptions WechatPay { get; set; }

        /// <summary>
        /// Zip gives your customers a way to split purchases over a series of payments. Check this
        /// <a href="https://docs.stripe.com/payments/zip">page</a> for more details like country
        /// availability.
        /// </summary>
        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public PaymentMethodConfigurationZipOptions Zip { get; set; }
    }
}
