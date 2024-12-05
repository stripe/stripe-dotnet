// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsPaypalSellerProtection : StripeEntity<ChargePaymentMethodDetailsPaypalSellerProtection>
    {
        /// <summary>
        /// An array of conditions that are covered for the transaction, if applicable.
        /// One of: <c>fraudulent</c>, or <c>product_not_received</c>.
        /// </summary>
        [JsonProperty("dispute_categories")]
        public List<string> DisputeCategories { get; set; }

        /// <summary>
        /// Indicates whether the transaction is eligible for PayPal's seller protection.
        /// One of: <c>eligible</c>, <c>not_eligible</c>, or <c>partially_eligible</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
