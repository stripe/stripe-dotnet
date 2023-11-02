// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class ReceivedDebitService : Service<Stripe.Treasury.ReceivedDebit>
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

        public virtual Stripe.Treasury.ReceivedDebit Create(ReceivedDebitCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.ReceivedDebit>(HttpMethod.Post, $"/v1/test_helpers/treasury/received_debits", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.ReceivedDebit> CreateAsync(ReceivedDebitCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.ReceivedDebit>(HttpMethod.Post, $"/v1/test_helpers/treasury/received_debits", options, requestOptions, cancellationToken);
        }
    }
}
