// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundTransferService : Service<OutboundTransfer>,
        ICreatable<OutboundTransfer, OutboundTransferCreateOptions>,
        IListable<OutboundTransfer, OutboundTransferListOptions>,
        IRetrievable<OutboundTransfer, OutboundTransferGetOptions>
    {
        public OutboundTransferService()
            : base(null)
        {
        }

        public OutboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/outbound_transfers";

        public virtual OutboundTransfer Cancel(string id, OutboundTransferCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<OutboundTransfer> CancelAsync(string id, OutboundTransferCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual OutboundTransfer Create(OutboundTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<OutboundTransfer> CreateAsync(OutboundTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual OutboundTransfer Get(string id, OutboundTransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<OutboundTransfer> GetAsync(string id, OutboundTransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<OutboundTransfer> List(OutboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<OutboundTransfer>> ListAsync(OutboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<OutboundTransfer> ListAutoPaging(OutboundTransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<OutboundTransfer> ListAutoPagingAsync(OutboundTransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
