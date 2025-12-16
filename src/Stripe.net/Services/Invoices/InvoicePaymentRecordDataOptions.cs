// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentRecordDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The amount that was paid out of band.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The currency that was paid out of band.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The type of money movement for this out of band payment record.
        /// </summary>
        [JsonProperty("money_movement_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("money_movement_type")]
#endif
        public string MoneyMovementType { get; set; }

        /// <summary>
        /// The timestamp when this out of band payment was paid.
        /// </summary>
        [JsonProperty("paid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paid_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// The reference for this out of band payment record.
        /// </summary>
        [JsonProperty("payment_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_reference")]
#endif
        public string PaymentReference { get; set; }
    }
}
