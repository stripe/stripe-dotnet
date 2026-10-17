// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationPurchaseDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Fleet-specific information for transactions using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
        [STJS.JsonPropertyName("fleet")]
        public AuthorizationPurchaseDetailsFleetOptions Fleet { get; set; }

        /// <summary>
        /// Information about the flight that was purchased with this transaction.
        /// </summary>
        [JsonProperty("flight")]
        [STJS.JsonPropertyName("flight")]
        public AuthorizationPurchaseDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
        [STJS.JsonPropertyName("fuel")]
        public AuthorizationPurchaseDetailsFuelOptions Fuel { get; set; }

        /// <summary>
        /// Information about lodging that was purchased with this transaction.
        /// </summary>
        [JsonProperty("lodging")]
        [STJS.JsonPropertyName("lodging")]
        public AuthorizationPurchaseDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// The line items in the purchase.
        /// </summary>
        [JsonProperty("receipt")]
        [STJS.JsonPropertyName("receipt")]
        public List<AuthorizationPurchaseDetailsReceiptOptions> Receipt { get; set; }

        /// <summary>
        /// A merchant-specific order number.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
