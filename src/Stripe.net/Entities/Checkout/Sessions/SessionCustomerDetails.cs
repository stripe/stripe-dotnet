// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCustomerDetails : StripeEntity<SessionCustomerDetails>
    {
        /// <summary>
        /// The email associated with the Customer, if one exists, on the Checkout Session at the
        /// time of checkout or at time of session expiry. Otherwise, if the customer has consented
        /// to promotional content, this value is the most recent valid email provided by the
        /// customer on the Checkout form.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The customer's phone number at the time of checkout.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer’s tax exempt status at time of checkout.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer’s tax IDs at time of checkout.
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<SessionCustomerDetailsTaxId> TaxIds { get; set; }
    }
}
