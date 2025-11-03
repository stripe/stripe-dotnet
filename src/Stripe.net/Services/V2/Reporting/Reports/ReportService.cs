// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportService : Service
    {
        internal ReportService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReportService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves metadata about a specific <c>Report</c> template, including its name,
        /// description, and the parameters it accepts. It's useful for understanding the
        /// capabilities and requirements of a particular <c>Report</c> before requesting a
        /// <c>ReportRun</c>.
        /// </summary>
        public virtual Report Get(string id, ReportGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Report>(BaseAddress.Api, HttpMethod.Get, $"/v2/reporting/reports/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves metadata about a specific <c>Report</c> template, including its name,
        /// description, and the parameters it accepts. It's useful for understanding the
        /// capabilities and requirements of a particular <c>Report</c> before requesting a
        /// <c>ReportRun</c>.
        /// </summary>
        public virtual Task<Report> GetAsync(string id, ReportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Report>(BaseAddress.Api, HttpMethod.Get, $"/v2/reporting/reports/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
