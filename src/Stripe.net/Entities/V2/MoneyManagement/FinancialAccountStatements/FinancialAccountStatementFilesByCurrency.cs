// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatementFilesByCurrency : StripeEntity<FinancialAccountStatementFilesByCurrency>
    {
        /// <summary>
        /// The MIME type of the file.
        /// </summary>
        [JsonProperty("content_type")]
        [STJS.JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The download URL and expiration.
        /// </summary>
        [JsonProperty("download_url")]
        [STJS.JsonPropertyName("download_url")]
        public FinancialAccountStatementFilesByCurrencyDownloadUrl DownloadUrl { get; set; }

        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        [JsonProperty("size")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("size")]
        public long Size { get; set; }
    }
}
