namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ReportRunService : Service<ReportRun>,
        ICreatable<ReportRun, ReportRunCreateOptions>,
        IListable<ReportRun, ReportRunListOptions>,
        IRetrievable<ReportRun>
    {
        private static string classUrl = Urls.BaseUrl + "/reporting/report_runs";

        public ReportRunService()
            : base(null)
        {
        }

        public ReportRunService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ReportRun Create(ReportRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}", requestOptions, options);
        }

        public virtual ReportRun Get(string reportRunId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{reportRunId}", requestOptions);
        }

        public virtual StripeList<ReportRun> List(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Task<ReportRun> CreateAsync(ReportRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<ReportRun> GetAsync(string reportRunId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{reportRunId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<ReportRun>> ListAsync(ReportRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }
    }
}
