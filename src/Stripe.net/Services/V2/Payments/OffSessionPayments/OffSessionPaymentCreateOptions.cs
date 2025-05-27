// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount you want to collect.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The frequency of the OSP.
        /// One of: <c>recurring</c>, or <c>unscheduled</c>.
        /// </summary>
        [JsonProperty("cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cadence")]
#endif
        public string Cadence { get; set; }

        /// <summary>
        /// Customer that owns the provided payment method.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Any of your internal data you want to track here.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The OBO merchant you want to use.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Payment method you want to debit. Must be attached to a customer and set up for
        /// off-session usage.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// How you want stripe to retry the OSP.
        /// </summary>
        [JsonProperty("retry_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retry_details")]
#endif
        public OffSessionPaymentCreateRetryDetailsOptions RetryDetails { get; set; }

        /// <summary>
        /// String you want to appear on your customer's statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Suffix appended to your account level descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Test clock to be used for testing your retry handling. Only usable in a sandbox.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }

        /// <summary>
        /// How you want to transfer the funds to your connected accounts.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public OffSessionPaymentCreateTransferDataOptions TransferData { get; set; }
    }
}
