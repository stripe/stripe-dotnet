// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderTaxDetails : StripeEntity<OrderTaxDetails>
    {
        /// <summary>
        /// Describes the purchaser's tax exemption status. One of <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The purchaser's tax IDs to be used in calculation of tax for this Order.
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<OrderTaxDetailsTaxId> TaxIds { get; set; }
    }
}
