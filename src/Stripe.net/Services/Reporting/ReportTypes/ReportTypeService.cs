namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ReportTypeService : Service<ReportType>,
        IListable<ReportType, ReportTypeListOptions>,
        IRetrievable<ReportType>
    {
        private static string classUrl = Urls.BaseUrl + "/reporting/report_types";

        public ReportTypeService()
            : base(null)
        {
        }

        public ReportTypeService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ReportType Get(string reportTypeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{reportTypeId}", requestOptions);
        }

        public virtual StripeList<ReportType> List(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Task<ReportType> GetAsync(string reportTypeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{reportTypeId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<ReportType>> ListAsync(ReportTypeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }
    }
}
