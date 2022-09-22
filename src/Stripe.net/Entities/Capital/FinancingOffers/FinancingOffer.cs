// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// This is an object representing an offer of financing from Stripe Capital to a Connect
    /// subaccount.
    /// </summary>
    public class FinancingOffer : StripeEntity<FinancingOffer>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// A unique identifier for the financing object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The object type: financing_offer.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// This is an object representing the terms of an offer of financing from Stripe Capital to
        /// a Connected account. This resource represents the terms accepted by the Connected
        /// account, which may differ from those offered.
        /// </summary>
        [JsonProperty("accepted_terms")]
        public FinancingOfferAcceptedTerms AcceptedTerms { get; set; }

        /// <summary>
        /// The ID of the merchant associated with this financing object.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Time at which the offer was created. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; set; }

        /// <summary>
        /// Time at which the offer expires. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("expires_after")]
        public decimal ExpiresAfter { get; set; }

        /// <summary>
        /// The type of financing being offered.
        /// One of: <c>cash_advance</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("financing_type")]
        public string FinancingType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// This is an object representing the terms of an offer of financing from Stripe Capital to
        /// a Connected account. This resource represents both the terms offered to the Connected
        /// account.
        /// </summary>
        [JsonProperty("offered_terms")]
        public FinancingOfferOfferedTerms OfferedTerms { get; set; }

        /// <summary>
        /// Financing product identifier.
        /// One of: <c>refill</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// The current status of the offer.
        /// One of: <c>accepted</c>, <c>canceled</c>, <c>completed</c>, <c>delivered</c>,
        /// <c>expired</c>, <c>fully_repaid</c>, <c>paid_out</c>, <c>rejected</c>, or
        /// <c>undelivered</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// See <a
        /// href="https://stripe.com/docs/api/capital/connect_financing_object#financing_offer_object-financing_type">financing_type</a>.
        /// One of: <c>cash_advance</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
