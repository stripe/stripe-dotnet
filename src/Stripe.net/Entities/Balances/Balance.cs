// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This is an object representing your Stripe balance. You can retrieve it to see the
    /// balance currently on your Stripe account.
    ///
    /// The top-level <c>available</c> and <c>pending</c> comprise your "payments balance.".
    ///
    /// Related guide: <a href="https://stripe.com/docs/payments/balances">Balances and
    /// settlement time</a>, <a
    /// href="https://stripe.com/docs/connect/account-balances">Understanding Connect account
    /// balances</a>.
    /// </summary>
    public class Balance : StripeEntity<Balance>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Available funds that you can transfer or pay out automatically by Stripe or explicitly
        /// through the <a href="https://stripe.com/docs/api#transfers">Transfers API</a> or <a
        /// href="https://stripe.com/docs/api#payouts">Payouts API</a>. You can find the available
        /// balance for each currency and payment type in the <c>source_types</c> property.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public List<BalanceAmount> Available { get; set; }

        /// <summary>
        /// Funds held due to negative balances on connected accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">account.controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts. You can find the connect reserve
        /// balance for each currency and payment type in the <c>source_types</c> property.
        /// </summary>
        [JsonProperty("connect_reserved")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("connect_reserved")]
#endif
        public List<BalanceAmount> ConnectReserved { get; set; }

        /// <summary>
        /// Funds that you can pay out using Instant Payouts.
        /// </summary>
        [JsonProperty("instant_available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("instant_available")]
#endif
        public List<BalanceInstantAvailable> InstantAvailable { get; set; }

        [JsonProperty("issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing")]
#endif
        public BalanceIssuing Issuing { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Funds that aren't available in the balance yet. You can find the pending balance for
        /// each currency and each payment type in the <c>source_types</c> property.
        /// </summary>
        [JsonProperty("pending")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending")]
#endif
        public List<BalanceAmount> Pending { get; set; }

        [JsonProperty("refund_and_dispute_prefunding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_and_dispute_prefunding")]
#endif
        public BalanceRefundAndDisputePrefunding RefundAndDisputePrefunding { get; set; }
    }
}
