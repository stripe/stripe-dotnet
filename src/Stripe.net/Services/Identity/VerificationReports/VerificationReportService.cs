// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VerificationReportService : Service<VerificationReport>,
        IListable<VerificationReport, VerificationReportListOptions>,
        IRetrievable<VerificationReport, VerificationReportGetOptions>
    {
        public VerificationReportService()
            : base(null)
        {
        }

        public VerificationReportService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/identity/verification_reports";

        public virtual VerificationReport Get(string id, VerificationReportGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationReport>(HttpMethod.Get, $"/v1/identity/verification_reports/{id}", options, requestOptions);
        }

        public virtual Task<VerificationReport> GetAsync(string id, VerificationReportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationReport>(HttpMethod.Get, $"/v1/identity/verification_reports/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<VerificationReport> List(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<VerificationReport>>(HttpMethod.Get, $"/v1/identity/verification_reports", options, requestOptions);
        }

        public virtual Task<StripeList<VerificationReport>> ListAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<VerificationReport>>(HttpMethod.Get, $"/v1/identity/verification_reports", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<VerificationReport> ListAutoPaging(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<VerificationReport>($"/v1/identity/verification_reports", options, requestOptions);
        }

        public virtual IAsyncEnumerable<VerificationReport> ListAutoPagingAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<VerificationReport>($"/v1/identity/verification_reports", options, requestOptions, cancellationToken);
        }
    }
}
