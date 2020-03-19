namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentIntentService : Service<PaymentIntent>,
        ICreatable<PaymentIntent, PaymentIntentCreateOptions>,
        IListable<PaymentIntent, PaymentIntentListOptions>,
        IRetrievable<PaymentIntent, PaymentIntentGetOptions>,
        IUpdatable<PaymentIntent, PaymentIntentUpdateOptions>
    {
        public PaymentIntentService()
            : base(null)
        {
        }

        public PaymentIntentService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/payment_intents";

        public virtual PaymentIntent Cancel(string paymentIntentId, PaymentIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/cancel", options, requestOptions);
        }

        public virtual Task<PaymentIntent> CancelAsync(string paymentIntentId, PaymentIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Capture(string paymentIntentId, PaymentIntentCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/capture", options, requestOptions);
        }

        public virtual Task<PaymentIntent> CaptureAsync(string paymentIntentId, PaymentIntentCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/capture", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Confirm(string paymentIntentId, PaymentIntentConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/confirm", options, requestOptions);
        }

        public virtual Task<PaymentIntent> ConfirmAsync(string paymentIntentId, PaymentIntentConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Create(PaymentIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PaymentIntent> CreateAsync(PaymentIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Get(string paymentIntentId, PaymentIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(paymentIntentId, options, requestOptions);
        }

        public virtual Task<PaymentIntent> GetAsync(string paymentIntentId, PaymentIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(paymentIntentId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentIntent> List(PaymentIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<PaymentIntent>> ListAsync(PaymentIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentIntent> ListAutoPaging(PaymentIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<PaymentIntent> ListAutoPagingAsync(PaymentIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual PaymentIntent Update(string paymentIntentId, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(paymentIntentId, options, requestOptions);
        }

        public virtual Task<PaymentIntent> UpdateAsync(string paymentIntentId, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(paymentIntentId, options, requestOptions, cancellationToken);
        }
    }
}
