// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
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
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<VerificationReport> GetAsync(string id, VerificationReportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<VerificationReport> List(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<VerificationReport>> ListAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<VerificationReport> ListAutoPaging(VerificationReportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<VerificationReport> ListAutoPagingAsync(VerificationReportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
