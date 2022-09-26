// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancingSummaryService : Service<FinancingSummary>,
        ISingletonRetrievable<FinancingSummary>
    {
        public FinancingSummaryService()
            : base(null)
        {
        }

        public FinancingSummaryService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/capital/financing_summary";

        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        public virtual FinancingSummary Get(RequestOptions requestOptions = null)
        {
            return this.GetEntity(null, null, requestOptions);
        }

        public virtual Task<FinancingSummary> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(null, null, requestOptions, cancellationToken);
        }
    }
}
