// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsCardRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// Specify the card brands to block in the Checkout Session. If a customer enters or
        /// selects a card belonging to a blocked brand, they can't complete the Session.
        /// One of: <c>american_express</c>, <c>discover_global_network</c>, <c>mastercard</c>, or
        /// <c>visa</c>.
        /// </summary>
        [JsonProperty("brands_blocked")]
        public List<string> BrandsBlocked { get; set; }
    }
}
