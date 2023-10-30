// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class OutboundTransferService : Service<Stripe.Treasury.OutboundTransfer>
    {
        public OutboundTransferService()
            : base(null)
        {
        }

        public OutboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/treasury/outbound_transfers";

        public virtual Stripe.Treasury.OutboundTransfer Fail(string id, OutboundTransferFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.OutboundTransfer> FailAsync(string id, OutboundTransferFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Treasury.OutboundTransfer Post(string id, OutboundTransferPostOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/post", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.OutboundTransfer> PostAsync(string id, OutboundTransferPostOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/post", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Treasury.OutboundTransfer ReturnOutboundTransfer(string id, OutboundTransferReturnOutboundTransferOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.OutboundTransfer> ReturnOutboundTransferAsync(string id, OutboundTransferReturnOutboundTransferOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions, cancellationToken);
        }
    }
}
