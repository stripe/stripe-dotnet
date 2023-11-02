// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

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
            return this.Request<ReportType>(HttpMethod.Get, $"/v1/reporting/report_types/{id}", options, requestOptions);
        }

        public virtual Task<ReportType> GetAsync(string id, ReportTypeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportType>(HttpMethod.Get, $"/v1/reporting/report_types/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ReportType> List(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ReportType>>(HttpMethod.Get, $"/v1/reporting/report_types", options, requestOptions);
        }

        public virtual Task<StripeList<ReportType>> ListAsync(ReportTypeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ReportType>>(HttpMethod.Get, $"/v1/reporting/report_types", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ReportType> ListAutoPaging(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReportType>($"/v1/reporting/report_types", options, requestOptions);
        }

        public virtual IAsyncEnumerable<ReportType> ListAutoPagingAsync(ReportTypeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReportType>($"/v1/reporting/report_types", options, requestOptions, cancellationToken);
        }
    }
}
