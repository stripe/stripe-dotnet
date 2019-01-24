namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportTypeService : Service<ReportType>,
        IListable<ReportType, ReportTypeListOptions>,
        IRetrievable<ReportType>
    {
        public ReportTypeService()
            : base(null)
        {
        }

        public ReportTypeService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/reporting/report_types";

        public virtual ReportType Get(string reportTypeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(reportTypeId, null, requestOptions);
        }

        public virtual Task<ReportType> GetAsync(string reportTypeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(reportTypeId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<ReportType> List(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ReportType>> ListAsync(ReportTypeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ReportType> ListAutoPaging(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
