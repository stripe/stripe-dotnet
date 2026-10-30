// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerMarketingAttribution : StripeEntity<CustomerMarketingAttribution>
    {
        [JsonProperty("ad_conversion")]
        [STJS.JsonPropertyName("ad_conversion")]
        public CustomerMarketingAttributionAdConversion AdConversion { get; set; }

        /// <summary>
        /// The advertising platform's click identifier.
        /// </summary>
        [JsonProperty("click_id")]
        [STJS.JsonPropertyName("click_id")]
        public string ClickId { get; set; }

        /// <summary>
        /// The Unix timestamp when the advertising interaction occurred.
        /// </summary>
        [JsonProperty("occurred_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("occurred_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? OccurredAt { get; set; }

        /// <summary>
        /// The advertising group ID from the <c>utm_adgroup</c> parameter.
        /// </summary>
        [JsonProperty("utm_adgroup")]
        [STJS.JsonPropertyName("utm_adgroup")]
        public string UtmAdgroup { get; set; }

        /// <summary>
        /// The advertising content identifier from the <c>utm_content</c> parameter.
        /// </summary>
        [JsonProperty("utm_content")]
        [STJS.JsonPropertyName("utm_content")]
        public string UtmContent { get; set; }

        /// <summary>
        /// The advertising campaign ID from the <c>utm_id</c> parameter.
        /// </summary>
        [JsonProperty("utm_id")]
        [STJS.JsonPropertyName("utm_id")]
        public string UtmId { get; set; }

        /// <summary>
        /// The marketing medium from the <c>utm_medium</c> parameter.
        /// </summary>
        [JsonProperty("utm_medium")]
        [STJS.JsonPropertyName("utm_medium")]
        public string UtmMedium { get; set; }

        /// <summary>
        /// The referral source from the <c>utm_source</c> parameter.
        /// </summary>
        [JsonProperty("utm_source")]
        [STJS.JsonPropertyName("utm_source")]
        public string UtmSource { get; set; }

        /// <summary>
        /// The paid search term from the <c>utm_term</c> parameter.
        /// </summary>
        [JsonProperty("utm_term")]
        [STJS.JsonPropertyName("utm_term")]
        public string UtmTerm { get; set; }
    }
}
