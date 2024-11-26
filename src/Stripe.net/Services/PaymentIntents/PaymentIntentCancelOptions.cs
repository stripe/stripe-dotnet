// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentCancelOptions : BaseOptions
    {
        /// <summary>
        /// Reason for canceling this PaymentIntent. Possible values are: <c>duplicate</c>,
        /// <c>fraudulent</c>, <c>requested_by_customer</c>, or <c>abandoned</c>.
        /// One of: <c>abandoned</c>, <c>duplicate</c>, <c>fraudulent</c>, or
        /// <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif
        public string CancellationReason { get; set; }
    }
}
