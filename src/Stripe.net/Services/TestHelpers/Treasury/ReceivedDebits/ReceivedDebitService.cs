// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class ReceivedDebitService : Service<ReceivedDebit>
    {
        public ReceivedDebitService()
            : base(null)
        {
        }

        public ReceivedDebitService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/treasury/received_debits";

        public virtual ReceivedDebit Create(ReceivedDebitCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("undefined")}", options, requestOptions);
        }

        public virtual Task<ReceivedDebit> CreateAsync(ReceivedDebitCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("undefined")}", options, requestOptions, cancellationToken);
        }
    }
}
