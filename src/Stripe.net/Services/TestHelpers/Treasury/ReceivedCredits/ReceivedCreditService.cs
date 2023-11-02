// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class ReceivedCreditService : Service<Stripe.Treasury.ReceivedCredit>
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

        public virtual Stripe.Treasury.ReceivedCredit Create(ReceivedCreditCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.ReceivedCredit>(HttpMethod.Post, $"/v1/test_helpers/treasury/received_credits", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.ReceivedCredit> CreateAsync(ReceivedCreditCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.ReceivedCredit>(HttpMethod.Post, $"/v1/test_helpers/treasury/received_credits", options, requestOptions, cancellationToken);
        }
    }
}
