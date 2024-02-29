// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReaderService : Service<Reader>,
        ICreatable<Reader, ReaderCreateOptions>,
        IDeletable<Reader, ReaderDeleteOptions>,
        IListable<Reader, ReaderListOptions>,
        IRetrievable<Reader, ReaderGetOptions>,
        IUpdatable<Reader, ReaderUpdateOptions>
    {
        public ReaderService()
            : base(null)
        {
        }

        public ReaderService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/terminal/readers";

        public virtual Reader CancelAction(string id, ReaderCancelActionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/cancel_action", options, requestOptions);
        }

        public virtual Task<Reader> CancelActionAsync(string id, ReaderCancelActionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/cancel_action", options, requestOptions, cancellationToken);
        }

        public virtual Reader CollectInputs(string id, ReaderCollectInputsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/collect_inputs", options, requestOptions);
        }

        public virtual Task<Reader> CollectInputsAsync(string id, ReaderCollectInputsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/collect_inputs", options, requestOptions, cancellationToken);
        }

        public virtual Reader CollectPaymentMethod(string id, ReaderCollectPaymentMethodOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/collect_payment_method", options, requestOptions);
        }

        public virtual Task<Reader> CollectPaymentMethodAsync(string id, ReaderCollectPaymentMethodOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/collect_payment_method", options, requestOptions, cancellationToken);
        }

        public virtual Reader ConfirmPaymentIntent(string id, ReaderConfirmPaymentIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/confirm_payment_intent", options, requestOptions);
        }

        public virtual Task<Reader> ConfirmPaymentIntentAsync(string id, ReaderConfirmPaymentIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/confirm_payment_intent", options, requestOptions, cancellationToken);
        }

        public virtual Reader Create(ReaderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers", options, requestOptions);
        }

        public virtual Task<Reader> CreateAsync(ReaderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers", options, requestOptions, cancellationToken);
        }

        public virtual Reader Delete(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Delete, $"/v1/terminal/readers/{id}", options, requestOptions);
        }

        public virtual Task<Reader> DeleteAsync(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Delete, $"/v1/terminal/readers/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Reader Get(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Get, $"/v1/terminal/readers/{id}", options, requestOptions);
        }

        public virtual Task<Reader> GetAsync(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Get, $"/v1/terminal/readers/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Reader> List(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Reader>>(HttpMethod.Get, $"/v1/terminal/readers", options, requestOptions);
        }

        public virtual Task<StripeList<Reader>> ListAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Reader>>(HttpMethod.Get, $"/v1/terminal/readers", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Reader> ListAutoPaging(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Reader>($"/v1/terminal/readers", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Reader> ListAutoPagingAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Reader>($"/v1/terminal/readers", options, requestOptions, cancellationToken);
        }

        public virtual Reader ProcessPaymentIntent(string id, ReaderProcessPaymentIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/process_payment_intent", options, requestOptions);
        }

        public virtual Task<Reader> ProcessPaymentIntentAsync(string id, ReaderProcessPaymentIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/process_payment_intent", options, requestOptions, cancellationToken);
        }

        public virtual Reader ProcessSetupIntent(string id, ReaderProcessSetupIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/process_setup_intent", options, requestOptions);
        }

        public virtual Task<Reader> ProcessSetupIntentAsync(string id, ReaderProcessSetupIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/process_setup_intent", options, requestOptions, cancellationToken);
        }

        public virtual Reader RefundPayment(string id, ReaderRefundPaymentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/refund_payment", options, requestOptions);
        }

        public virtual Task<Reader> RefundPaymentAsync(string id, ReaderRefundPaymentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/refund_payment", options, requestOptions, cancellationToken);
        }

        public virtual Reader SetReaderDisplay(string id, ReaderSetReaderDisplayOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/set_reader_display", options, requestOptions);
        }

        public virtual Task<Reader> SetReaderDisplayAsync(string id, ReaderSetReaderDisplayOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}/set_reader_display", options, requestOptions, cancellationToken);
        }

        public virtual Reader Update(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}", options, requestOptions);
        }

        public virtual Task<Reader> UpdateAsync(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(HttpMethod.Post, $"/v1/terminal/readers/{id}", options, requestOptions, cancellationToken);
        }
    }
}
