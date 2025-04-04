// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VerificationReportService : Service,
        IListable<VerificationReport, VerificationReportListOptions>,
        IRetrievable<VerificationReport, VerificationReportGetOptions>
    {
        public VerificationReportService()
        {
        }

        internal VerificationReportService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public VerificationReportService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves an existing VerificationReport</p>.
        /// </summary>
        public virtual VerificationReport Get(string id, VerificationReportGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationReport>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an existing VerificationReport</p>.
        /// </summary>
        public virtual Task<VerificationReport> GetAsync(string id, VerificationReportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationReport>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual StripeList<VerificationReport> List(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<VerificationReport>>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports", options, requestOptions);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual Task<StripeList<VerificationReport>> ListAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<VerificationReport>>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual IEnumerable<VerificationReport> ListAutoPaging(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<VerificationReport>($"/v1/identity/verification_reports", options, requestOptions);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<VerificationReport> ListAutoPagingAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<VerificationReport>($"/v1/identity/verification_reports", options, requestOptions, cancellationToken);
        }
    }
}
