// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceParentSubscriptionDetailsPauseCollection : StripeEntity<InvoiceParentSubscriptionDetailsPauseCollection>
    {
        [JsonProperty("behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("behavior")]
#endif
        public string Behavior { get; set; }

        [JsonProperty("resumes_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resumes_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ResumesAt { get; set; }
    }
}
