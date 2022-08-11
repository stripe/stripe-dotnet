// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
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

        public override string BasePath => "/v1/terminal/readers";

        public virtual Reader CancelAction(string id, ReaderCancelActionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel_action", options, requestOptions);
        }

        public virtual Task<Reader> CancelActionAsync(string id, ReaderCancelActionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel_action", options, requestOptions, cancellationToken);
        }

        public virtual Reader Create(ReaderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Reader> CreateAsync(ReaderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Reader Delete(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, options, requestOptions);
        }

        public virtual Task<Reader> DeleteAsync(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Reader Get(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Reader> GetAsync(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Reader> List(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Reader>> ListAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Reader> ListAutoPaging(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Reader> ListAutoPagingAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual Reader ProcessPaymentIntent(string id, ReaderProcessPaymentIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/process_payment_intent", options, requestOptions);
        }

        public virtual Task<Reader> ProcessPaymentIntentAsync(string id, ReaderProcessPaymentIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/process_payment_intent", options, requestOptions, cancellationToken);
        }

        public virtual Reader ProcessSetupIntent(string id, ReaderProcessSetupIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/process_setup_intent", options, requestOptions);
        }

        public virtual Task<Reader> ProcessSetupIntentAsync(string id, ReaderProcessSetupIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/process_setup_intent", options, requestOptions, cancellationToken);
        }

        public virtual Reader RefundPayment(string id, ReaderRefundPaymentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/refund_payment", options, requestOptions);
        }

        public virtual Task<Reader> RefundPaymentAsync(string id, ReaderRefundPaymentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/refund_payment", options, requestOptions, cancellationToken);
        }

        public virtual Reader SetReaderDisplay(string id, ReaderSetReaderDisplayOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/set_reader_display", options, requestOptions);
        }

        public virtual Task<Reader> SetReaderDisplayAsync(string id, ReaderSetReaderDisplayOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/set_reader_display", options, requestOptions, cancellationToken);
        }

        public virtual Reader Update(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Reader> UpdateAsync(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
