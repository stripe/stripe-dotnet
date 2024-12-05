// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// An institution represents a financial institution to which an end user can connect using
    /// the Financial Connections authentication flow.
    /// </summary>
    public class Institution : StripeEntity<Institution>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("features")]
        public InstitutionFeatures Features { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The name of this institution.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A list of routing numbers which are known to correspond to this institution. Due to the
        /// many to many relationship between institutions and routing numbers, this list may not be
        /// comprehensive and routing numbers may also be shared between institutions.
        /// </summary>
        [JsonProperty("routing_numbers")]
        public List<string> RoutingNumbers { get; set; }

        /// <summary>
        /// The status of this institution in the Financial Connections authentication flow.
        /// One of: <c>active</c>, <c>degraded</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A URL corresponding to this institution. This URL is also displayed in the
        /// authentication flow to help end users confirm that they are authenticating with the
        /// right institution.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
