// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VerificationReportService : Service<VerificationReport>,
        IListable<VerificationReport, VerificationReportListOptions>,
        IRetrievable<VerificationReport, VerificationReportGetOptions>
    {
        public VerificationReportService()
        {
        }

        public VerificationReportService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/identity/verification_reports";

        /// <summary>
        /// <p>Retrieves an existing VerificationReport</p>.
        /// </summary>
        public virtual VerificationReport Get(string id, VerificationReportGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationReport>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Retrieves an existing VerificationReport</p>.
        /// </summary>
        public virtual Task<VerificationReport> GetAsync(string id, VerificationReportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationReport>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual StripeList<VerificationReport> List(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<VerificationReport>>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual Task<StripeList<VerificationReport>> ListAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<VerificationReport>>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/verification_reports", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual IEnumerable<VerificationReport> ListAutoPaging(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<VerificationReport>($"/v1/identity/verification_reports", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>List all verification reports.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<VerificationReport> ListAutoPagingAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<VerificationReport>($"/v1/identity/verification_reports", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
