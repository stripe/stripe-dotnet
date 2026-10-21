// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListData : StripeEntity<SearchResultListData>, IHasId
    {
        /// <summary>
        /// What the canonical resource contains.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// How to execute this result.
        /// </summary>
        [JsonProperty("execution_spec")]
        [STJS.JsonPropertyName("execution_spec")]
        public SearchResultListDataExecutionSpec ExecutionSpec { get; set; }

        /// <summary>
        /// Per-result additional context: constraints, interpretation rules, and gotchas.
        /// </summary>
        [JsonProperty("extended_description")]
        [STJS.JsonPropertyName("extended_description")]
        public string ExtendedDescription { get; set; }

        /// <summary>
        /// Canonical resource identity.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Human-readable name of the canonical resource.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The canonical resource type this result points at, e.g. "v2.data.schema" or
        /// "v2.data.report". May name a resource that is not yet publicly retrievable, in which
        /// case <c>reference_url</c> is omitted. Distinct from <c>object</c>, which identifies this
        /// result itself.
        /// </summary>
        [JsonProperty("object_type")]
        [STJS.JsonPropertyName("object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Canonical API path for retrieving the complete resource, e.g.
        /// "/v2/data/reports/report_123".
        /// </summary>
        [JsonProperty("reference_url")]
        [STJS.JsonPropertyName("reference_url")]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// Present for schemas when known; omitted for resource types without data freshness.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [STJS.JsonPropertyName("refreshed_at")]
        public DateTime RefreshedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Relative ordering signal from the search service (0-1). Not a calibrated guarantee;
        /// callers must not use it as a configurable cutoff.
        /// </summary>
        [JsonProperty("relevance_score")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("relevance_score")]
        public decimal RelevanceScore { get; set; }

        /// <summary>
        /// One of: <c>metrics</c>, <c>reports</c>, or <c>schemas</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("catalog")]
        [STJS.JsonPropertyName("catalog")]
        public string Catalog { get; set; }

        /// <summary>
        /// A pre-defined measure queryable through the metric query endpoint.
        /// </summary>
        [JsonProperty("metrics")]
        [STJS.JsonPropertyName("metrics")]
        public SearchResultListDataMetrics Metrics { get; set; }

        /// <summary>
        /// A Stripe-defined report exposed by <c>/v2/data/reports</c>.
        /// </summary>
        [JsonProperty("reports")]
        [STJS.JsonPropertyName("reports")]
        public SearchResultListDataReports Reports { get; set; }

        /// <summary>
        /// A queryable table exposed by <c>/v2/data/schemas</c>.
        /// </summary>
        [JsonProperty("schemas")]
        [STJS.JsonPropertyName("schemas")]
        public SearchResultListDataSchemas Schemas { get; set; }
    }
}
