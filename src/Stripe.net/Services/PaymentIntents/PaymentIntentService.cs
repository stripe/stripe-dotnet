namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class PaymentIntentService : StripeBasicService<PaymentIntent>
    {
        public PaymentIntentService()
            : base(null)
        {
        }

        public PaymentIntentService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandApplication { get; set; }

        public bool ExpandCustomer { get; set; }

        public bool ExpandSource { get; set; }

        // Sync
        public virtual PaymentIntent Create(PaymentIntentCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payment_intents", requestOptions, options);
        }

        public virtual PaymentIntent Get(string paymentIntentId, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}", requestOptions);
        }

        public virtual PaymentIntent Update(string paymentIntentId, PaymentIntentUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}", requestOptions, options);
        }

        public virtual StripeList<PaymentIntent> List(PaymentIntentListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/payment_intents", requestOptions, listOptions);
        }

        public virtual PaymentIntent Cancel(string paymentIntentId, PaymentIntentCancelOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}/cancel", requestOptions, options);
        }

        public virtual PaymentIntent Capture(string paymentIntentId, PaymentIntentCaptureOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}/capture", requestOptions, options);
        }

        public virtual PaymentIntent Confirm(string paymentIntentId, PaymentIntentConfirmOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}/confirm", requestOptions, options);
        }

        // Async
        public virtual Task<PaymentIntent> CreateAsync(PaymentIntentCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payment_intents", requestOptions, cancellationToken, options);
        }

        public virtual Task<PaymentIntent> GetAsync(string paymentIntentId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}", requestOptions, cancellationToken);
        }

        public virtual Task<PaymentIntent> UpdateAsync(string paymentIntentId, PaymentIntentUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<PaymentIntent>> ListAsync(PaymentIntentListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/payment_intents", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<PaymentIntent> CancelAsync(string paymentIntentId, PaymentIntentCancelOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}/cancel", requestOptions, cancellationToken, options);
        }

        public virtual Task<PaymentIntent> CaptureAsync(string paymentIntentId, PaymentIntentCaptureOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}/capture", requestOptions, cancellationToken, options);
        }

        public virtual Task<PaymentIntent> ConfirmAsync(string paymentIntentId, PaymentIntentConfirmOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payment_intents/{paymentIntentId}/confirm", requestOptions, cancellationToken, options);
        }
    }
}
