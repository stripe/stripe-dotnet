// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsCardRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// The card brands to block. If a customer enters or selects a card belonging to a blocked
        /// brand, they can't complete the payment.
        /// One of: <c>american_express</c>, <c>discover_global_network</c>, <c>mastercard</c>, or
        /// <c>visa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("brands_blocked")]
        [STJS.JsonPropertyName("brands_blocked")]
        public List<string> BrandsBlocked { get; set; }

        /// <summary>
        /// Card funding types to block for this Checkout Session. Supported values are
        /// <c>credit</c>, <c>debit</c>, and <c>prepaid</c>.
        /// One of: <c>credit</c>, <c>debit</c>, or <c>prepaid</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("funding_types_blocked")]
        [STJS.JsonPropertyName("funding_types_blocked")]
        public List<string> FundingTypesBlocked { get; set; }
    }
}
