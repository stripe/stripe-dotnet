namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentIntentService : Service<PaymentIntent>,
        ICreatable<PaymentIntent, PaymentIntentCreateOptions>,
        IListable<PaymentIntent, PaymentIntentListOptions>,
        IRetrievable<PaymentIntent>,
        IUpdatable<PaymentIntent, PaymentIntentUpdateOptions>
    {
        public PaymentIntentService()
            : base(null)
        {
        }

        public PaymentIntentService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/payment_intents";

        public bool ExpandApplication { get; set; }

        public bool ExpandCustomer { get; set; }

        public bool ExpandOnBehalfOf { get; set; }

        public bool ExpandPaymentMethod { get; set; }

        public bool ExpandReview { get; set; }

        public bool ExpandSource { get; set; }

        public virtual PaymentIntent Cancel(string paymentIntentId, PaymentIntentCancelOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/cancel", options, requestOptions);
        }

        public virtual Task<PaymentIntent> CancelAsync(string paymentIntentId, PaymentIntentCancelOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Capture(string paymentIntentId, PaymentIntentCaptureOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/capture", options, requestOptions);
        }

        public virtual Task<PaymentIntent> CaptureAsync(string paymentIntentId, PaymentIntentCaptureOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/capture", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Confirm(string paymentIntentId, PaymentIntentConfirmOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/confirm", options, requestOptions);
        }

        public virtual Task<PaymentIntent> ConfirmAsync(string paymentIntentId, PaymentIntentConfirmOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Create(PaymentIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PaymentIntent> CreateAsync(PaymentIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Get(string paymentIntentId, RequestOptions requestOptions = null)
        {
            return this.Get(paymentIntentId, null, requestOptions);
        }

        public virtual Task<PaymentIntent> GetAsync(string paymentIntentId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetAsync(paymentIntentId, null, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Get(string paymentIntentId, PaymentIntentGetOptions options, RequestOptions requestOptions = null)
        {
            return this.GetEntity(paymentIntentId, options, requestOptions);
        }

        public virtual Task<PaymentIntent> GetAsync(string paymentIntentId, PaymentIntentGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(paymentIntentId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentIntent> List(PaymentIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<PaymentIntent>> ListAsync(PaymentIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentIntent> ListAutoPaging(PaymentIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual PaymentIntent Update(string paymentIntentId, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(paymentIntentId, options, requestOptions);
        }

        public virtual Task<PaymentIntent> UpdateAsync(string paymentIntentId, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(paymentIntentId, options, requestOptions, cancellationToken);
        }
    }
}
