// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundSetupIntentCreateOptions : BaseOptions
    {
        /// <summary>
        /// If provided, the existing payout method resource to link to this setup intent. Any
        /// payout_method_data provided is used to update information on this linked payout method
        /// resource.
        /// </summary>
        [JsonProperty("payout_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_method")]
#endif
        public string PayoutMethod { get; set; }

        /// <summary>
        /// If no payout_method provided, used to create the underlying credential that is set up
        /// for outbound money movement. If a payout_method provided, used to update data on the
        /// credential linked to this setup intent.
        /// </summary>
        [JsonProperty("payout_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_method_data")]
#endif
        public OutboundSetupIntentCreatePayoutMethodDataOptions PayoutMethodData { get; set; }

        /// <summary>
        /// Specify which type of outbound money movement this credential should be set up for
        /// (payment | transfer). If not provided, defaults to payment.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("usage_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_intent")]
#endif
        public string UsageIntent { get; set; }
    }
}
