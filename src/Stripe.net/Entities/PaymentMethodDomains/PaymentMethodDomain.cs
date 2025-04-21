// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A payment method domain represents a web domain that you have registered with Stripe.
    /// Stripe Elements use registered payment method domains to control where certain payment
    /// methods are shown.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/payments/payment-methods/pmd-registration">Payment method
    /// domains</a>.
    /// </summary>
    public class PaymentMethodDomain : StripeEntity<PaymentMethodDomain>, IHasId, IHasObject
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

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public PaymentMethodDomainAmazonPay AmazonPay { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public PaymentMethodDomainApplePay ApplePay { get; set; }

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
        /// The domain name that this payment method domain object represents.
        /// </summary>
        [JsonProperty("domain_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("domain_name")]
#endif
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this payment method domain is enabled. If the domain is not enabled, payment
        /// methods that require a payment method domain will not appear in Elements.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("google_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("google_pay")]
#endif
        public PaymentMethodDomainGooglePay GooglePay { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public PaymentMethodDomainKlarna Klarna { get; set; }

        /// <summary>
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public PaymentMethodDomainLink Link { get; set; }

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
        /// Indicates the status of a specific payment method on a payment method domain.
        /// </summary>
        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public PaymentMethodDomainPaypal Paypal { get; set; }
    }
}
