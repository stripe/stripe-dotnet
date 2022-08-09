// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCustomerDetails : StripeEntity<SessionCustomerDetails>
    {
        /// <summary>
        /// The customer's address after a completed Checkout Session. Note: This property is
        /// populated only for sessions on or after March 30, 2022.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The email associated with the Customer, if one exists, on the Checkout Session after a
        /// completed Checkout Session or at time of session expiry. Otherwise, if the customer has
        /// consented to promotional content, this value is the most recent valid email provided by
        /// the customer on the Checkout form.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The customer's name after a completed Checkout Session. Note: This property is populated
        /// only for sessions on or after March 30, 2022.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The customer's phone number after a completed Checkout Session.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer’s tax exempt status after a completed Checkout Session.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer’s tax IDs after a completed Checkout Session.
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<SessionCustomerDetailsTaxId> TaxIds { get; set; }
    }
}
