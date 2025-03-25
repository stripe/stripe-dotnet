// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferStatusDetailsReturned : StripeEntity<OutboundTransferStatusDetailsReturned>
    {
        /// <summary>
        /// Open Enum. The <c>returned</c> status reason.
        /// One of: <c>payout_method_canceled_by_customer</c>, <c>payout_method_closed</c>,
        /// <c>payout_method_currency_unsupported</c>, <c>payout_method_does_not_exist</c>,
        /// <c>payout_method_holder_address_incorrect</c>,
        /// <c>payout_method_holder_details_incorrect</c>,
        /// <c>payout_method_holder_name_incorrect</c>, <c>payout_method_invalid_account_number</c>,
        /// <c>payout_method_restricted</c>, <c>recalled</c>, or <c>unknown_failure</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
