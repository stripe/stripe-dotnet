// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionPurchaseDetails : StripeEntity<TransactionPurchaseDetails>
    {
        /// <summary>
        /// Fleet-specific information for transactions using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fleet")]
#endif
        public TransactionPurchaseDetailsFleet Fleet { get; set; }

        /// <summary>
        /// Information about the flight that was purchased with this transaction.
        /// </summary>
        [JsonProperty("flight")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flight")]
#endif
        public TransactionPurchaseDetailsFlight Flight { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fuel")]
#endif
        public TransactionPurchaseDetailsFuel Fuel { get; set; }

        /// <summary>
        /// Information about lodging that was purchased with this transaction.
        /// </summary>
        [JsonProperty("lodging")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lodging")]
#endif
        public TransactionPurchaseDetailsLodging Lodging { get; set; }

        /// <summary>
        /// The line items in the purchase.
        /// </summary>
        [JsonProperty("receipt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt")]
#endif
        public List<TransactionPurchaseDetailsReceipt> Receipt { get; set; }

        /// <summary>
        /// A merchant-specific order number.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
