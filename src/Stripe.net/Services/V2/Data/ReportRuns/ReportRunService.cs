// File generated from our OpenAPI spec
namespace Stripe.V2.Data
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
        /// Initiates the generation of a <c>ReportRun</c> based on the specified <c>Report</c> and
        /// caller-provided parameters. Returns a <c>ReportRun</c> object which can be used to track
        /// the progress and retrieve the results of the report.
        /// </summary>
        public virtual ReportRun Create(ReportRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/report_runs", options, requestOptions);
        }

        /// <summary>
        /// Initiates the generation of a <c>ReportRun</c> based on the specified <c>Report</c> and
        /// caller-provided parameters. Returns a <c>ReportRun</c> object which can be used to track
        /// the progress and retrieve the results of the report.
        /// </summary>
        public virtual Task<ReportRun> CreateAsync(ReportRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/report_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Fetches the current state and details of a previously created <c>ReportRun</c>. If the
        /// <c>ReportRun</c> has succeeded, the endpoint provides details for how to retrieve the
        /// results.
        /// </summary>
        public virtual ReportRun Get(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/report_runs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Fetches the current state and details of a previously created <c>ReportRun</c>. If the
        /// <c>ReportRun</c> has succeeded, the endpoint provides details for how to retrieve the
        /// results.
        /// </summary>
        public virtual Task<ReportRun> GetAsync(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/report_runs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
