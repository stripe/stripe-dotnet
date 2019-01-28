namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodService : Service<PaymentMethod>,
        ICreatable<PaymentMethod, PaymentMethodCreateOptions>,
        IListable<PaymentMethod, PaymentMethodListOptions>,
        IRetrievable<PaymentMethod>,
        IUpdatable<PaymentMethod, PaymentMethodUpdateOptions>
    {
        public PaymentMethodService()
            : base(null)
        {
        }

        public PaymentMethodService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/payment_methods";

        public bool ExpandCustomer { get; set; }

        public virtual PaymentMethod Attach(string paymentMethodId, PaymentMethodAttachOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/attach", options, requestOptions);
        }

        public virtual Task<PaymentMethod> AttachAsync(string paymentMethodId, PaymentMethodAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/attach", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethod Create(PaymentMethodCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PaymentMethod> CreateAsync(PaymentMethodCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethod Detach(string paymentMethodId, PaymentMethodDetachOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/detach", options, requestOptions);
        }

        public virtual Task<PaymentMethod> DetachAsync(string paymentMethodId, PaymentMethodDetachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentMethodId)}/detach", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethod Get(string paymentMethodId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(paymentMethodId, null, requestOptions);
        }

        public virtual Task<PaymentMethod> GetAsync(string paymentMethodId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(paymentMethodId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentMethod> List(PaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<PaymentMethod>> ListAsync(PaymentMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentMethod> ListAutoPaging(PaymentMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual PaymentMethod Update(string paymentMethodId, PaymentMethodUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(paymentMethodId, options, requestOptions);
        }

        public virtual Task<PaymentMethod> UpdateAsync(string paymentMethodId, PaymentMethodUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(paymentMethodId, options, requestOptions, cancellationToken);
        }
    }
}
