// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SetupIntentService : Service<SetupIntent>,
        ICreatable<SetupIntent, SetupIntentCreateOptions>,
        IListable<SetupIntent, SetupIntentListOptions>,
        IRetrievable<SetupIntent, SetupIntentGetOptions>,
        IUpdatable<SetupIntent, SetupIntentUpdateOptions>
    {
        public SetupIntentService()
            : base(null)
        {
        }

        public SetupIntentService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/setup_intents";

        public virtual SetupIntent Cancel(string id, SetupIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/cancel", options, requestOptions);
        }

        public virtual Task<SetupIntent> CancelAsync(string id, SetupIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Confirm(string id, SetupIntentConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/confirm", options, requestOptions);
        }

        public virtual Task<SetupIntent> ConfirmAsync(string id, SetupIntentConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Create(SetupIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents", options, requestOptions);
        }

        public virtual Task<SetupIntent> CreateAsync(SetupIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Get(string id, SetupIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Get, $"/v1/setup_intents/{id}", options, requestOptions);
        }

        public virtual Task<SetupIntent> GetAsync(string id, SetupIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Get, $"/v1/setup_intents/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SetupIntent> List(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SetupIntent>>(HttpMethod.Get, $"/v1/setup_intents", options, requestOptions);
        }

        public virtual Task<StripeList<SetupIntent>> ListAsync(SetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SetupIntent>>(HttpMethod.Get, $"/v1/setup_intents", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SetupIntent> ListAutoPaging(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SetupIntent>($"/v1/setup_intents", options, requestOptions);
        }

        public virtual IAsyncEnumerable<SetupIntent> ListAutoPagingAsync(SetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SetupIntent>($"/v1/setup_intents", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Update(string id, SetupIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}", options, requestOptions);
        }

        public virtual Task<SetupIntent> UpdateAsync(string id, SetupIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent VerifyMicrodeposits(string id, SetupIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/verify_microdeposits", options, requestOptions);
        }

        public virtual Task<SetupIntent> VerifyMicrodepositsAsync(string id, SetupIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/verify_microdeposits", options, requestOptions, cancellationToken);
        }
    }
}
