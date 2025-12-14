// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// <c>Source</c> objects allow you to accept a variety of payment methods. They represent a
    /// customer's payment instrument, and can be used with the Stripe API just like a
    /// <c>Card</c> object: once chargeable, they can be charged, or can be attached to
    /// customers.
    ///
    /// Stripe doesn't recommend using the deprecated <a
    /// href="https://docs.stripe.com/api/sources">Sources API</a>. We recommend that you adopt
    /// the <a href="https://docs.stripe.com/api/payment_methods">PaymentMethods API</a>. This
    /// newer API provides access to our latest features and payment method types.
    ///
    /// Related guides: <a href="https://docs.stripe.com/sources">Sources API</a> and <a
    /// href="https://docs.stripe.com/sources/customers">Sources &amp; Customers</a>.
    /// </summary>
    public class Source : StripeEntity<Source>, IHasId, IHasMetadata, IHasObject, IPaymentSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        [JsonProperty("ach_credit_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach_credit_transfer")]
#endif
        public SourceAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach_debit")]
#endif
        public SourceAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public SourceAcssDebit AcssDebit { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public SourceAlipay Alipay { get; set; }

        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow. The
        /// field defaults to “unspecified”.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redisplay")]
#endif
        public string AllowRedisplay { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for
        /// ¥1, Japanese Yen being a zero-decimal currency) representing the total amount associated
        /// with the source. This is the amount for which the source will be chargeable once ready.
        /// Required for <c>single_use</c> sources.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public SourceAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public SourceBancontact Bancontact { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public SourceCard Card { get; set; }

        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public SourceCardPresent CardPresent { get; set; }

        /// <summary>
        /// The client secret of the source. Used for client-side retrieval using a publishable key.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

        [JsonProperty("code_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code_verification")]
#endif
        public SourceCodeVerification CodeVerification { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// associated with the source. This is the currency for which the source will be chargeable
        /// once ready. Required for <c>single_use</c> sources.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the customer to which this source is attached. This will not be present when
        /// the source has not been attached to a customer.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif
        public SourceEps Eps { get; set; }

        /// <summary>
        /// The authentication <c>flow</c> of the source. <c>flow</c> is one of <c>redirect</c>,
        /// <c>receiver</c>, <c>code_verification</c>, <c>none</c>.
        /// </summary>
        [JsonProperty("flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow")]
#endif
        public string Flow { get; set; }

        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif
        public SourceGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public SourceIdeal Ideal { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public SourceKlarna Klarna { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif
        public SourceMultibanco Multibanco { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by
        /// particular source types.
        /// </summary>
        [JsonProperty("owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
#endif
        public SourceOwner Owner { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif
        public SourceP24 P24 { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public SourcePaypal Paypal { get; set; }

        [JsonProperty("receiver")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receiver")]
#endif
        public SourceReceiver Receiver { get; set; }

        [JsonProperty("redirect")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect")]
#endif
        public SourceRedirect Redirect { get; set; }

        [JsonProperty("sepa_credit_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_credit_transfer")]
#endif
        public SourceSepaCreditTransfer SepaCreditTransfer { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public SourceSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public SourceSofort Sofort { get; set; }

        [JsonProperty("source_order")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_order")]
#endif
        public SourceSourceOrder SourceOrder { get; set; }

        /// <summary>
        /// Extra information about a source. This will appear on your customer's statement every
        /// time you charge the source.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the source, one of <c>canceled</c>, <c>chargeable</c>, <c>consumed</c>,
        /// <c>failed</c>, or <c>pending</c>. Only <c>chargeable</c> sources can be used to create a
        /// charge.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("three_d_secure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("three_d_secure")]
#endif
        public SourceThreeDSecure ThreeDSecure { get; set; }

        /// <summary>
        /// The <c>type</c> of the source. The <c>type</c> is a payment method, one of
        /// <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>alipay</c>, <c>bancontact</c>,
        /// <c>card</c>, <c>card_present</c>, <c>eps</c>, <c>giropay</c>, <c>ideal</c>,
        /// <c>multibanco</c>, <c>klarna</c>, <c>p24</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>three_d_secure</c>, or <c>wechat</c>. An additional hash is included on the source
        /// with a name matching this value. It contains additional information specific to the <a
        /// href="https://docs.stripe.com/sources">payment method</a> used.
        /// One of: <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>acss_debit</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bancontact</c>, <c>card</c>, <c>card_present</c>, <c>eps</c>,
        /// <c>giropay</c>, <c>ideal</c>, <c>klarna</c>, <c>multibanco</c>, <c>p24</c>,
        /// <c>paypal</c>, <c>sepa_credit_transfer</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>three_d_secure</c>, or <c>wechat</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Either <c>reusable</c> or <c>single_use</c>. Whether this source should be reusable or
        /// not. Some source types may or may not be reusable by construction, while others may
        /// leave the option at creation. If an incompatible value is passed, an error will be
        /// returned.
        /// </summary>
        [JsonProperty("usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage")]
#endif
        public string Usage { get; set; }

        [JsonProperty("wechat")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat")]
#endif
        public SourceWechat Wechat { get; set; }
    }
}
