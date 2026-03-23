// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoiceParentSubscriptionDetailsPauseCollection : StripeEntity<QuotePreviewInvoiceParentSubscriptionDetailsPauseCollection>
    {
        /// <summary>
        /// The payment collection behavior for this subscription while paused.
        /// One of: <c>keep_as_draft</c>, <c>mark_uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("behavior")]
        [STJS.JsonPropertyName("behavior")]
        public string Behavior { get; set; }

        /// <summary>
        /// The time after which the subscription will resume collecting payments.
        /// </summary>
        [JsonProperty("resumes_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("resumes_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ResumesAt { get; set; }
    }
}
