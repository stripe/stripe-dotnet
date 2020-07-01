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
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<SetupIntent> CancelAsync(string id, SetupIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Confirm(string id, SetupIntentConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/confirm", options, requestOptions);
        }

        public virtual Task<SetupIntent> ConfirmAsync(string id, SetupIntentConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Create(SetupIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<SetupIntent> CreateAsync(SetupIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Get(string id, SetupIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<SetupIntent> GetAsync(string id, SetupIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SetupIntent> List(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<SetupIntent>> ListAsync(SetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SetupIntent> ListAutoPaging(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<SetupIntent> ListAutoPagingAsync(SetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Update(string id, SetupIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<SetupIntent> UpdateAsync(string id, SetupIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
