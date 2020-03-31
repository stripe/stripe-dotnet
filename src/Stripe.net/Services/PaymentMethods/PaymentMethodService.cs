namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodService : Service<PaymentMethod>,
        ICreatable<PaymentMethod, PaymentMethodCreateOptions>,
        IListable<PaymentMethod, PaymentMethodListOptions>,
        IRetrievable<PaymentMethod, PaymentMethodGetOptions>,
        IUpdatable<PaymentMethod, PaymentMethodUpdateOptions>
    {
        public PaymentMethodService()
            : base(null)
        {
        }

        public PaymentMethodService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/payment_methods";

        public virtual PaymentMethod Attach(string paymentMethodId, PaymentMethodAttachOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/attach", options, requestOptions);
        }

        public virtual Task<PaymentMethod> AttachAsync(string paymentMethodId, PaymentMethodAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/attach", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethod Create(PaymentMethodCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PaymentMethod> CreateAsync(PaymentMethodCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethod Detach(string paymentMethodId, PaymentMethodDetachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/detach", options, requestOptions);
        }

        public virtual Task<PaymentMethod> DetachAsync(string paymentMethodId, PaymentMethodDetachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/detach", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethod Get(string paymentMethodId, PaymentMethodGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(paymentMethodId, options, requestOptions);
        }

        public virtual Task<PaymentMethod> GetAsync(string paymentMethodId, PaymentMethodGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(paymentMethodId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentMethod> List(PaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<PaymentMethod>> ListAsync(PaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentMethod> ListAutoPaging(PaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<PaymentMethod> ListAutoPagingAsync(PaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual PaymentMethod Update(string paymentMethodId, PaymentMethodUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(paymentMethodId, options, requestOptions);
        }

        public virtual Task<PaymentMethod> UpdateAsync(string paymentMethodId, PaymentMethodUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(paymentMethodId, options, requestOptions, cancellationToken);
        }
    }
}
