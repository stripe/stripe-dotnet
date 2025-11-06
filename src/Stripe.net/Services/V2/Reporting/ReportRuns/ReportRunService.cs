// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportRunService : Service
    {
        internal ReportRunService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReportRunService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Initiates the generation of a <c>ReportRun</c> based on the specified report template
        /// and user-provided parameters. It's the starting point for obtaining report data, and
        /// returns a <c>ReportRun</c> object which can be used to track the progress and retrieve
        /// the results of the report.
        /// </summary>
        public virtual ReportRun Create(ReportRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/reporting/report_runs", options, requestOptions);
        }

        /// <summary>
        /// Initiates the generation of a <c>ReportRun</c> based on the specified report template
        /// and user-provided parameters. It's the starting point for obtaining report data, and
        /// returns a <c>ReportRun</c> object which can be used to track the progress and retrieve
        /// the results of the report.
        /// </summary>
        public virtual Task<ReportRun> CreateAsync(ReportRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/reporting/report_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Fetches the current state and details of a previously created <c>ReportRun</c>. If the
        /// <c>ReportRun</c> has succeeded, the endpoint will provide details for how to retrieve
        /// the results.
        /// </summary>
        public virtual ReportRun Get(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/reporting/report_runs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Fetches the current state and details of a previously created <c>ReportRun</c>. If the
        /// <c>ReportRun</c> has succeeded, the endpoint will provide details for how to retrieve
        /// the results.
        /// </summary>
        public virtual Task<ReportRun> GetAsync(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/reporting/report_runs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
