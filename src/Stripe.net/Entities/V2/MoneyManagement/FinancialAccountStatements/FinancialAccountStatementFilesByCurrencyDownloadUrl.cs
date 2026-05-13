// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatementFilesByCurrencyDownloadUrl : StripeEntity<FinancialAccountStatementFilesByCurrencyDownloadUrl>
    {
        /// <summary>
        /// The time at which the URL expires, in ISO 8601 format (UTC).
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL to download the file.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
