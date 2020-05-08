namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ReportTypeService : Service<ReportType>,
        IListable<ReportType, ReportTypeListOptions>,
        IRetrievable<ReportType, ReportTypeGetOptions>
    {
        public ReportTypeService()
            : base(null)
        {
        }

        public ReportTypeService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/reporting/report_types";

        public virtual ReportType Get(string id, ReportTypeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ReportType> GetAsync(string id, ReportTypeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ReportType> List(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ReportType>> ListAsync(ReportTypeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ReportType> ListAutoPaging(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
