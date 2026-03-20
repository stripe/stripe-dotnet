// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// This is an object representing an offer of financing from Stripe Capital to a Connect
    /// subaccount.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancingOffer : StripeEntity<FinancingOffer>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// A unique identifier for the financing object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The object type: financing_offer.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// This is an object representing the terms of an offer of financing from Stripe Capital to
        /// a Connected account. This resource represents the terms accepted by the Connected
        /// account, which may differ from those offered.
        /// </summary>
        [JsonProperty("accepted_terms")]
        [STJS.JsonPropertyName("accepted_terms")]
        public FinancingOfferAcceptedTerms AcceptedTerms { get; set; }

        /// <summary>
        /// The ID of the merchant associated with this financing object.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The time at which this financing offer was charged off, if applicable. Given in seconds
        /// since unix epoch.
        /// </summary>
        [JsonProperty("charged_off_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("charged_off_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ChargedOffAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the offer was created. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the offer expires. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("expires_after")]
        [STJS.JsonPropertyName("expires_after")]
        public decimal ExpiresAfter { get; set; }

        /// <summary>
        /// The type of financing being offered.
        /// One of: <c>cash_advance</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("financing_type")]
        [STJS.JsonPropertyName("financing_type")]
        public string FinancingType { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// This is an object representing the terms of an offer of financing from Stripe Capital to
        /// a Connected account. This resource represents both the terms offered to the Connected
        /// account.
        /// </summary>
        [JsonProperty("offered_terms")]
        [STJS.JsonPropertyName("offered_terms")]
        public FinancingOfferOfferedTerms OfferedTerms { get; set; }

        /// <summary>
        /// Financing product identifier.
        /// One of: <c>refill</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("product_type")]
        [STJS.JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// The ID of the financing offer that replaced this offer.
        /// </summary>
        [JsonProperty("replacement")]
        [STJS.JsonPropertyName("replacement")]
        public string Replacement { get; set; }

        /// <summary>
        /// The ID of the financing offer that this offer is a replacement for.
        /// </summary>
        [JsonProperty("replacement_for")]
        [STJS.JsonPropertyName("replacement_for")]
        public string ReplacementFor { get; set; }

        /// <summary>
        /// The current status of the offer.
        /// One of: <c>accepted</c>, <c>canceled</c>, <c>completed</c>, <c>delivered</c>,
        /// <c>expired</c>, <c>fully_repaid</c>, <c>paid_out</c>, <c>rejected</c>, <c>replaced</c>,
        /// or <c>undelivered</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// See <a
        /// href="https://docs.stripe.com/api/capital/connect_financing_object#financing_offer_object-financing_type">financing_type</a>.
        /// One of: <c>cash_advance</c>, <c>fixed_term_loan</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
