// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionRegulatoryReceipt : StripeEntity<TransactionRegulatoryReceipt>
    {
        /// <summary>
        /// Current availability of the regulatory receipt.
        /// One of: <c>available</c>, <c>not_applicable</c>, <c>pending</c>, or <c>url_expired</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Hosted URL for the receipt.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Time until which <c>url</c> is valid.
        /// </summary>
        [JsonProperty("url_expires_at")]
        [STJS.JsonPropertyName("url_expires_at")]
        public DateTime? UrlExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
