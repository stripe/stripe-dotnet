// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The Report Type resource corresponds to a particular type of report, such as the
    /// "Activity summary" or "Itemized payouts" reports. These objects are identified by an ID
    /// belonging to a set of enumerated values. See <a
    /// href="https://docs.stripe.com/reporting/statements/api">API Access to Reports
    /// documentation</a> for those Report Type IDs, along with required and optional
    /// parameters.
    ///
    /// Note that certain report types can only be run based on your live-mode data (not
    /// test-mode data), and will error when queried without a <a
    /// href="https://docs.stripe.com/keys#test-live-modes">live-mode API key</a>.
    /// </summary>
    public class ReportType : StripeEntity<ReportType>, IHasId, IHasObject
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/reporting/statements/api#available-report-types">ID
        /// of the Report Type</a>, such as <c>balance.summary.1</c>.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Most recent time for which this Report Type is available. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("data_available_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data_available_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime DataAvailableEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Earliest time for which this Report Type is available. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("data_available_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data_available_start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime DataAvailableStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// List of column names that are included by default when this Report Type gets run. (If
        /// the Report Type doesn't support the <c>columns</c> parameter, this will be null.).
        /// </summary>
        [JsonProperty("default_columns")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_columns")]
#endif
        public List<string> DefaultColumns { get; set; }

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
        /// Human-readable name of the Report Type.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// When this Report Type was latest updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Version of the Report Type. Different versions report with the same ID will have the
        /// same purpose, but may take different run parameters or have different result schemas.
        /// </summary>
        [JsonProperty("version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("version")]
#endif
        public long Version { get; set; }
    }
}
