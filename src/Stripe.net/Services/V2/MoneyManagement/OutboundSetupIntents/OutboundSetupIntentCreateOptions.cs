// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundSetupIntentCreateOptions : BaseOptions
    {
        /// <summary>
        /// If provided, the existing payout method resource to link to this setup intent. Any
        /// payout_method_data provided is used to update information on this linked payout method
        /// resource.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }

        /// <summary>
        /// If no payout_method provided, used to create the underlying credential that is set up
        /// for outbound money movement. If a payout_method provided, used to update data on the
        /// credential linked to this setup intent.
        /// </summary>
        [JsonProperty("payout_method_data")]
        [STJS.JsonPropertyName("payout_method_data")]
        public OutboundSetupIntentCreatePayoutMethodDataOptions PayoutMethodData { get; set; }

        /// <summary>
        /// Specify which type of outbound money movement this credential should be set up for
        /// (payment | transfer). If not provided, defaults to payment.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("usage_intent")]
        [STJS.JsonPropertyName("usage_intent")]
        public string UsageIntent { get; set; }
    }
}
