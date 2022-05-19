// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class ReceivedCreditService : Service<ReceivedCredit>
    {
        public ReceivedCreditService()
            : base(null)
        {
        }

        public ReceivedCreditService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/treasury/received_credits";

        public virtual ReceivedCredit Create(ReceivedCreditCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ReceivedCredit> CreateAsync(ReceivedCreditCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}
