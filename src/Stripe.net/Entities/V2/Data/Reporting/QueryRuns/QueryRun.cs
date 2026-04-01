// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>QueryRun</c> object represents an ad-hoc SQL execution. Once created, Stripe
    /// processes the query. When the query has finished running, the object provides a
    /// reference to the results.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRun : StripeEntity<QueryRun>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>QueryRun</c> object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Details how to retrieve the results of a successfully completed <c>QueryRun</c>.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public QueryRunResult Result { get; set; }

        /// <summary>
        /// The options specified for customizing the output of the <c>QueryRun</c>.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public QueryRunResultOptions ResultOptions { get; set; }

        /// <summary>
        /// The SQL that was executed.
        /// </summary>
        [JsonProperty("sql")]
        [STJS.JsonPropertyName("sql")]
        public string Sql { get; set; }

        /// <summary>
        /// The current status of the <c>QueryRun</c>.
        /// One of: <c>failed</c>, <c>running</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current state of the <c>QueryRun</c>. Populated when the
        /// <c>QueryRun</c> is in the <c>failed</c> state, providing more information about why the
        /// query failed.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public Dictionary<string, QueryRunStatusDetails> StatusDetails { get; set; }
    }
}
