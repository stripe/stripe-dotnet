// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentIntentService : Service<PaymentIntent>,
        ICreatable<PaymentIntent, PaymentIntentCreateOptions>,
        IListable<PaymentIntent, PaymentIntentListOptions>,
        IRetrievable<PaymentIntent, PaymentIntentGetOptions>,
        ISearchable<PaymentIntent, PaymentIntentSearchOptions>,
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

        public virtual PaymentIntent ApplyCustomerBalance(string id, PaymentIntentApplyCustomerBalanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/apply_customer_balance", options, requestOptions);
        }

        public virtual Task<PaymentIntent> ApplyCustomerBalanceAsync(string id, PaymentIntentApplyCustomerBalanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/apply_customer_balance", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Cancel(string id, PaymentIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<PaymentIntent> CancelAsync(string id, PaymentIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Capture(string id, PaymentIntentCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/capture", options, requestOptions);
        }

        public virtual Task<PaymentIntent> CaptureAsync(string id, PaymentIntentCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/capture", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Confirm(string id, PaymentIntentConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/confirm", options, requestOptions);
        }

        public virtual Task<PaymentIntent> ConfirmAsync(string id, PaymentIntentConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Create(PaymentIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PaymentIntent> CreateAsync(PaymentIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Get(string id, PaymentIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<PaymentIntent> GetAsync(string id, PaymentIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
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

        public virtual IAsyncEnumerable<PaymentIntent> ListAutoPagingAsync(PaymentIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual StripeSearchResult<PaymentIntent> Search(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<PaymentIntent>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions);
        }

        public virtual Task<StripeSearchResult<PaymentIntent>> SearchAsync(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<PaymentIntent>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentIntent> SearchAutoPaging(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<PaymentIntent>($"{this.InstanceUrl("search")}", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PaymentIntent> SearchAutoPagingAsync(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<PaymentIntent>($"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent Update(string id, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<PaymentIntent> UpdateAsync(string id, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual PaymentIntent VerifyMicrodeposits(string id, PaymentIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify_microdeposits", options, requestOptions);
        }

        public virtual Task<PaymentIntent> VerifyMicrodepositsAsync(string id, PaymentIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify_microdeposits", options, requestOptions, cancellationToken);
        }
    }
}
