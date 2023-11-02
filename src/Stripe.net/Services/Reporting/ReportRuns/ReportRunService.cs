// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportRunService : Service<ReportRun>,
        ICreatable<ReportRun, ReportRunCreateOptions>,
        IListable<ReportRun, ReportRunListOptions>,
        IRetrievable<ReportRun, ReportRunGetOptions>
    {
        public ReportRunService()
            : base(null)
        {
        }

        public ReportRunService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/reporting/report_runs";

        public virtual ReportRun Create(ReportRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(HttpMethod.Post, $"/v1/reporting/report_runs", options, requestOptions);
        }

        public virtual Task<ReportRun> CreateAsync(ReportRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(HttpMethod.Post, $"/v1/reporting/report_runs", options, requestOptions, cancellationToken);
        }

        public virtual ReportRun Get(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReportRun>(HttpMethod.Get, $"/v1/reporting/report_runs/{id}", options, requestOptions);
        }

        public virtual Task<ReportRun> GetAsync(string id, ReportRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportRun>(HttpMethod.Get, $"/v1/reporting/report_runs/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ReportRun> List(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ReportRun>>(HttpMethod.Get, $"/v1/reporting/report_runs", options, requestOptions);
        }

        public virtual Task<StripeList<ReportRun>> ListAsync(ReportRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ReportRun>>(HttpMethod.Get, $"/v1/reporting/report_runs", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ReportRun> ListAutoPaging(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReportRun>($"/v1/reporting/report_runs", options, requestOptions);
        }

        public virtual IAsyncEnumerable<ReportRun> ListAutoPagingAsync(ReportRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReportRun>($"/v1/reporting/report_runs", options, requestOptions, cancellationToken);
        }
    }
}
