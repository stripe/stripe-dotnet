// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransaction : StripeEntity<DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransaction>
    {
        /// <summary>
        /// User Account ID used to log into business platform. Must be recognizable by the user.
        /// </summary>
        [JsonProperty("customer_account_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account_id")]
#endif

        public string CustomerAccountId { get; set; }

        /// <summary>
        /// Unique identifier of the cardholder’s device derived from a combination of at least two
        /// hardware and software attributes. Must be at least 20 characters.
        /// </summary>
        [JsonProperty("customer_device_fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_device_fingerprint")]
#endif

        public string CustomerDeviceFingerprint { get; set; }

        /// <summary>
        /// Unique identifier of the cardholder’s device such as a device serial number (e.g.,
        /// International Mobile Equipment Identity [IMEI]). Must be at least 15 characters.
        /// </summary>
        [JsonProperty("customer_device_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_device_id")]
#endif

        public string CustomerDeviceId { get; set; }

        /// <summary>
        /// The email address of the customer.
        /// </summary>
        [JsonProperty("customer_email_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_email_address")]
#endif

        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The IP address that the customer used when making the purchase.
        /// </summary>
        [JsonProperty("customer_purchase_ip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_purchase_ip")]
#endif

        public string CustomerPurchaseIp { get; set; }

        /// <summary>
        /// Categorization of disputed payment.
        /// One of: <c>merchandise</c>, or <c>services</c>.
        /// </summary>
        [JsonProperty("merchandise_or_services")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchandise_or_services")]
#endif

        public string MerchandiseOrServices { get; set; }

        /// <summary>
        /// A description of the product or service that was sold.
        /// </summary>
        [JsonProperty("product_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_description")]
#endif

        public string ProductDescription { get; set; }

        /// <summary>
        /// The address to which a physical product was shipped. All fields are required for Visa
        /// Compelling Evidence 3.0 evidence submission.
        /// </summary>
        [JsonProperty("shipping_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_address")]
#endif

        public DisputeEvidenceEnhancedEvidenceVisaCompellingEvidence3DisputedTransactionShippingAddress ShippingAddress { get; set; }
    }
}
