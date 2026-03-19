// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// This is an object representing your Stripe balance. You can retrieve it to see the
    /// balance currently on your Stripe account.
    ///
    /// The top-level <c>available</c> and <c>pending</c> comprise your "payments balance.".
    ///
    /// Related guide: <a href="https://docs.stripe.com/payments/balances">Balances and
    /// settlement time</a>, <a
    /// href="https://docs.stripe.com/connect/account-balances">Understanding Connect account
    /// balances</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Balance : StripeEntity<Balance>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Available funds that you can transfer or pay out automatically by Stripe or explicitly
        /// through the <a href="https://api.stripe.com#transfers">Transfers API</a> or <a
        /// href="https://api.stripe.com#payouts">Payouts API</a>. You can find the available
        /// balance for each currency and payment type in the <c>source_types</c> property.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public List<BalanceAmount> Available { get; set; }

        /// <summary>
        /// Funds held due to negative balances on connected accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">account.controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts. You can find the connect reserve
        /// balance for each currency and payment type in the <c>source_types</c> property.
        /// </summary>
        [JsonProperty("connect_reserved")]
        [STJS.JsonPropertyName("connect_reserved")]
        public List<BalanceAmount> ConnectReserved { get; set; }

        /// <summary>
        /// Funds that you can pay out using Instant Payouts.
        /// </summary>
        [JsonProperty("instant_available")]
        [STJS.JsonPropertyName("instant_available")]
        public List<BalanceInstantAvailable> InstantAvailable { get; set; }

        [JsonProperty("issuing")]
        [STJS.JsonPropertyName("issuing")]
        public BalanceIssuing Issuing { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Funds that aren't available in the balance yet. You can find the pending balance for
        /// each currency and each payment type in the <c>source_types</c> property.
        /// </summary>
        [JsonProperty("pending")]
        [STJS.JsonPropertyName("pending")]
        public List<BalanceAmount> Pending { get; set; }

        [JsonProperty("refund_and_dispute_prefunding")]
        [STJS.JsonPropertyName("refund_and_dispute_prefunding")]
        public BalanceRefundAndDisputePrefunding RefundAndDisputePrefunding { get; set; }
    }
}
