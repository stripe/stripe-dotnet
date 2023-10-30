// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class InboundTransferService : Service<Stripe.Treasury.InboundTransfer>
    {
        public InboundTransferService()
            : base(null)
        {
        }

        public InboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/treasury/inbound_transfers";

        public virtual Stripe.Treasury.InboundTransfer Fail(string id, InboundTransferFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.InboundTransfer> FailAsync(string id, InboundTransferFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Treasury.InboundTransfer ReturnInboundTransfer(string id, InboundTransferReturnInboundTransferOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.InboundTransfer> ReturnInboundTransferAsync(string id, InboundTransferReturnInboundTransferOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Treasury.InboundTransfer Succeed(string id, InboundTransferSucceedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/succeed", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.InboundTransfer> SucceedAsync(string id, InboundTransferSucceedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/succeed", options, requestOptions, cancellationToken);
        }
    }
}
