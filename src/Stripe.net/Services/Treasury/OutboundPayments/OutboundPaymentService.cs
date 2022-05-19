// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundPaymentService : Service<OutboundPayment>,
        ICreatable<OutboundPayment, OutboundPaymentCreateOptions>,
        IListable<OutboundPayment, OutboundPaymentListOptions>,
        IRetrievable<OutboundPayment, OutboundPaymentGetOptions>
    {
        public OutboundPaymentService()
            : base(null)
        {
        }

        public OutboundPaymentService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/treasury/outbound_payments";

        public virtual OutboundPayment Cancel(string id, OutboundPaymentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<OutboundPayment> CancelAsync(string id, OutboundPaymentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual OutboundPayment Create(OutboundPaymentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<OutboundPayment> CreateAsync(OutboundPaymentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual OutboundPayment Get(string id, OutboundPaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<OutboundPayment> GetAsync(string id, OutboundPaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<OutboundPayment> List(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<OutboundPayment>> ListAsync(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<OutboundPayment> ListAutoPaging(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<OutboundPayment> ListAutoPagingAsync(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
    }
}
