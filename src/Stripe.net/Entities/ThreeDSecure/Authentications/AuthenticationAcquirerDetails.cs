// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationAcquirerDetails : StripeEntity<AuthenticationAcquirerDetails>
    {
        /// <summary>
        /// The Acquirer BIN (specific to the directory_server).
        /// </summary>
        [JsonProperty("acquirer_bin")]
        [STJS.JsonPropertyName("acquirer_bin")]
        public string AcquirerBin { get; set; }

        /// <summary>
        /// The two-letter country code of the acquirer (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("acquirer_country")]
        [STJS.JsonPropertyName("acquirer_country")]
        public string AcquirerCountry { get; set; }

        /// <summary>
        /// The Merchant ID (or Card Acceptor ID) that your acquirer assigned you (specific to the
        /// directory_server).
        /// </summary>
        [JsonProperty("acquirer_merchant_id")]
        [STJS.JsonPropertyName("acquirer_merchant_id")]
        public string AcquirerMerchantId { get; set; }

        /// <summary>
        /// The <a href="https://en.wikipedia.org/wiki/Merchant_category_code">merchant category
        /// code</a> as defined by each payment system or directory server.
        /// </summary>
        [JsonProperty("mcc")]
        [STJS.JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant name assigned by the acquirer or payment system. Same name used in the
        /// authorization message as defined in <a href="https://en.wikipedia.org/wiki/ISO_8583">ISO
        /// 8583</a>.
        /// </summary>
        [JsonProperty("merchant_name")]
        [STJS.JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// Requestor ID if you’re enrolled in the card network’s 3DS program. Otherwise, you can
        /// omit this field because Stripe assigns a Requestor ID with the card networks.
        /// </summary>
        [JsonProperty("requestor_id")]
        [STJS.JsonPropertyName("requestor_id")]
        public string RequestorId { get; set; }
    }
}
