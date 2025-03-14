// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The object type: financing_offer.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// This is an object representing the terms of an offer of financing from Stripe Capital to
        /// a Connected account. This resource represents the terms accepted by the Connected
        /// account, which may differ from those offered.
        /// </summary>
        [JsonProperty("accepted_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accepted_terms")]
#endif
        public FinancingOfferAcceptedTerms AcceptedTerms { get; set; }

        /// <summary>
        /// The ID of the merchant associated with this financing object.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The time at which this financing offer was charged off, if applicable. Given in seconds
        /// since unix epoch.
        /// </summary>
        [JsonProperty("charged_off_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charged_off_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ChargedOffAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the offer was created. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the offer expires. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("expires_after")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_after")]
#endif
        public decimal ExpiresAfter { get; set; }

        /// <summary>
        /// The type of financing being offered.
        /// One of: <c>cash_advance</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("financing_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_type")]
#endif
        public string FinancingType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// This is an object representing the terms of an offer of financing from Stripe Capital to
        /// a Connected account. This resource represents both the terms offered to the Connected
        /// account.
        /// </summary>
        [JsonProperty("offered_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offered_terms")]
#endif
        public FinancingOfferOfferedTerms OfferedTerms { get; set; }

        /// <summary>
        /// Financing product identifier.
        /// One of: <c>refill</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("product_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_type")]
#endif
        public string ProductType { get; set; }

        /// <summary>
        /// The ID of the financing offer that replaced this offer.
        /// </summary>
        [JsonProperty("replacement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("replacement")]
#endif
        public string Replacement { get; set; }

        /// <summary>
        /// The ID of the financing offer that this offer is a replacement for.
        /// </summary>
        [JsonProperty("replacement_for")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("replacement_for")]
#endif
        public string ReplacementFor { get; set; }

        /// <summary>
        /// The current status of the offer.
        /// One of: <c>accepted</c>, <c>canceled</c>, <c>completed</c>, <c>delivered</c>,
        /// <c>expired</c>, <c>fully_repaid</c>, <c>paid_out</c>, <c>rejected</c>, <c>replaced</c>,
        /// or <c>undelivered</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// See <a
        /// href="https://stripe.com/docs/api/capital/connect_financing_object#financing_offer_object-financing_type">financing_type</a>.
        /// One of: <c>cash_advance</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
