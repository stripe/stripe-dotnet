// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCatalogImportStatusDetailsSucceededWithErrorsErrorFileDownloadUrl : StripeEntity<ProductCatalogImportStatusDetailsSucceededWithErrorsErrorFileDownloadUrl>
    {
        /// <summary>
        /// The timestamp when the download URL expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The pre-signed URL for downloading the error file.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
