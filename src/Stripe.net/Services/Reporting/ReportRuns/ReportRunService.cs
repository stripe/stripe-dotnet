namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportRunService : Service<ReportRun>,
        ICreatable<ReportRun, ReportRunCreateOptions>,
        IListable<ReportRun, ReportRunListOptions>,
        IRetrievable<ReportRun>
    {
        public ReportRunService()
            : base(null)
        {
        }

        public ReportRunService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/reporting/report_runs";

        public virtual ReportRun Create(ReportRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ReportRun> CreateAsync(ReportRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ReportRun Get(string reportRunId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(reportRunId, null, requestOptions);
        }

        public virtual Task<ReportRun> GetAsync(string reportRunId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(reportRunId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<ReportRun> List(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ReportRun>> ListAsync(ReportRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ReportRun> ListAutoPaging(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
