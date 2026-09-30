// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Collections.Generic;
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
        /// Retrieves metadata about a specific <c>Report</c>, including its name, description, and
        /// the parameters it accepts. It's useful for understanding the capabilities and
        /// requirements of a particular <c>Report</c> before requesting a <c>ReportRun</c>.
        /// </summary>
        public virtual Report Get(string id, ReportGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Report>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/reports/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves metadata about a specific <c>Report</c>, including its name, description, and
        /// the parameters it accepts. It's useful for understanding the capabilities and
        /// requirements of a particular <c>Report</c> before requesting a <c>ReportRun</c>.
        /// </summary>
        public virtual Task<Report> GetAsync(string id, ReportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Report>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/reports/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Stripe-defined reports that the caller can create a <c>ReportRun</c>
        /// for.
        /// </summary>
        public virtual V2.StripeList<Report> List(ReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Report>>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/reports", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Stripe-defined reports that the caller can create a <c>ReportRun</c>
        /// for.
        /// </summary>
        public virtual Task<V2.StripeList<Report>> ListAsync(ReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Report>>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/reports", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Stripe-defined reports that the caller can create a <c>ReportRun</c>
        /// for.
        /// </summary>
        public virtual IEnumerable<Report> ListAutoPaging(ReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Report>($"/v2/data/reports", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Stripe-defined reports that the caller can create a <c>ReportRun</c>
        /// for.
        /// </summary>
        public virtual IAsyncEnumerable<Report> ListAutoPagingAsync(ReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Report>($"/v2/data/reports", options, requestOptions, cancellationToken);
        }
    }
}
