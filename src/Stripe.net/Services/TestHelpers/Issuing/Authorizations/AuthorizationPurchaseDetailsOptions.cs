// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AuthorizationPurchaseDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Information about the flight that was purchased with this transaction.
        /// </summary>
        [JsonProperty("flight")]
        public AuthorizationPurchaseDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
        public AuthorizationPurchaseDetailsFuelOptions Fuel { get; set; }

        /// <summary>
        /// Information about lodging that was purchased with this transaction.
        /// </summary>
        [JsonProperty("lodging")]
        public AuthorizationPurchaseDetailsLodgingOptions Lodging { get; set; }

        /// <summary>
        /// The line items in the purchase.
        /// </summary>
        [JsonProperty("receipt")]
        public List<AuthorizationPurchaseDetailsReceiptOptions> Receipt { get; set; }

        /// <summary>
        /// A merchant-specific order number.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
