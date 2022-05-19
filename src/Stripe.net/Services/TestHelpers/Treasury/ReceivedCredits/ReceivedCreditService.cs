// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
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

        public virtual ReceivedCredit Create(ReceivedCreditCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("undefined")}", options, requestOptions);
        }

        public virtual Task<ReceivedCredit> CreateAsync(ReceivedCreditCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("undefined")}", options, requestOptions, cancellationToken);
        }
    }
}
