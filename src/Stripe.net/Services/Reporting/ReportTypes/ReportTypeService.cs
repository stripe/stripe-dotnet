// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportTypeService : Service<ReportType>,
        IListable<ReportType, ReportTypeListOptions>,
        IRetrievable<ReportType, ReportTypeGetOptions>
    {
        public ReportTypeService()
        {
        }

        public ReportTypeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/reporting/report_types";

        /// <summary>
        /// <p>Retrieves the details of a Report Type. (Certain report types require a <a
        /// href="https://stripe.com/docs/keys#test-live-modes">live-mode API key</a>.)</p>.
        /// </summary>
        public virtual ReportType Get(string id, ReportTypeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReportType>(HttpMethod.Get, $"/v1/reporting/report_types/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Report Type. (Certain report types require a <a
        /// href="https://stripe.com/docs/keys#test-live-modes">live-mode API key</a>.)</p>.
        /// </summary>
        public virtual Task<ReportType> GetAsync(string id, ReportTypeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReportType>(HttpMethod.Get, $"/v1/reporting/report_types/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a full list of Report Types.</p>.
        /// </summary>
        public virtual StripeList<ReportType> List(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ReportType>>(HttpMethod.Get, $"/v1/reporting/report_types", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a full list of Report Types.</p>.
        /// </summary>
        public virtual Task<StripeList<ReportType>> ListAsync(ReportTypeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ReportType>>(HttpMethod.Get, $"/v1/reporting/report_types", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a full list of Report Types.</p>.
        /// </summary>
        public virtual IEnumerable<ReportType> ListAutoPaging(ReportTypeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReportType>($"/v1/reporting/report_types", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a full list of Report Types.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ReportType> ListAutoPagingAsync(ReportTypeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReportType>($"/v1/reporting/report_types", options, requestOptions, cancellationToken);
        }
    }
}
