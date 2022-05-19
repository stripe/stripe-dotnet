// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InboundTransferService : Service<InboundTransfer>,
        ICreatable<InboundTransfer, InboundTransferCreateOptions>,
        IListable<InboundTransfer, InboundTransferListOptions>,
        IRetrievable<InboundTransfer, InboundTransferGetOptions>
    {
        public InboundTransferService()
            : base(null)
        {
        }

        public InboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/inbound_transfers";

        public virtual InboundTransfer Cancel(string id, InboundTransferCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<InboundTransfer> CancelAsync(string id, InboundTransferCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual InboundTransfer Create(InboundTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<InboundTransfer> CreateAsync(InboundTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual InboundTransfer Get(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<InboundTransfer> GetAsync(string id, InboundTransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InboundTransfer> List(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<InboundTransfer>> ListAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InboundTransfer> ListAutoPaging(InboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<InboundTransfer> ListAutoPagingAsync(InboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
