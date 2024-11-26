// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationPurchaseDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Fleet-specific information for transactions using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fleet")]
#endif
        public AuthorizationPurchaseDetailsFleetOptions Fleet { get; set; }

        /// <summary>
        /// Information about the flight that was purchased with this transaction.
        /// </summary>
        [JsonProperty("flight")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flight")]
#endif
        public AuthorizationPurchaseDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fuel")]
#endif
        public AuthorizationPurchaseDetailsFuelOptions Fuel { get; set; }

        /// <summary>
        /// Information about lodging that was purchased with this transaction.
        /// </summary>
        [JsonProperty("lodging")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lodging")]
#endif
        public AuthorizationPurchaseDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// The line items in the purchase.
        /// </summary>
        [JsonProperty("receipt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt")]
#endif
        public List<AuthorizationPurchaseDetailsReceiptOptions> Receipt { get; set; }

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
