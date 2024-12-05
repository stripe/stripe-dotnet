// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// The Report Run object represents an instance of a report type generated with specific
    /// run parameters. Once the object is created, Stripe begins processing the report. When
    /// the report has finished running, it will give you a reference to a file where you can
    /// retrieve your results. For an overview, see <a
    /// href="https://stripe.com/docs/reporting/statements/api">API Access to Reports</a>.
    ///
    /// Note that certain report types can only be run based on your live-mode data (not
    /// test-mode data), and will error when queried without a <a
    /// href="https://stripe.com/docs/keys#test-live-modes">live-mode API key</a>.
    /// </summary>
    public class ReportRun : StripeEntity<ReportRun>, IHasId, IHasObject
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

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If something should go wrong during the run, a message about the failure (populated when
        /// <c>status=failed</c>).
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// <c>true</c> if the report is run on live mode data and <c>false</c> if it is run on test
        /// mode data.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("parameters")]
        public ReportRunParameters Parameters { get; set; }

        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/reports/report-types">report type</a> to
        /// run, such as <c>"balance.summary.1"</c>.
        /// </summary>
        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// The file object representing the result of the report run (populated when
        /// <c>status=succeeded</c>).
        /// </summary>
        [JsonProperty("result")]
        public File Result { get; set; }

        /// <summary>
        /// Status of this report run. This will be <c>pending</c> when the run is initially
        /// created. When the run finishes, this will be set to <c>succeeded</c> and the
        /// <c>result</c> field will be populated. Rarely, we may encounter an error, at which point
        /// this will be set to <c>failed</c> and the <c>error</c> field will be populated.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timestamp at which this run successfully finished (populated when
        /// <c>status=succeeded</c>). Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SucceededAt { get; set; }
    }
}
