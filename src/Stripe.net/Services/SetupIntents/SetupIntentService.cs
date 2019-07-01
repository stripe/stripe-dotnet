namespace Stripe
{
    using System;
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

        public virtual SetupIntent Cancel(string paymentIntentId, SetupIntentCancelOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/cancel", options, requestOptions);
        }

        public virtual Task<SetupIntent> CancelAsync(string paymentIntentId, SetupIntentCancelOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Confirm(string paymentIntentId, SetupIntentConfirmOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/confirm", options, requestOptions);
        }

        public virtual Task<SetupIntent> ConfirmAsync(string paymentIntentId, SetupIntentConfirmOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(paymentIntentId)}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Create(SetupIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<SetupIntent> CreateAsync(SetupIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual SetupIntent Get(string paymentIntentId, SetupIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(paymentIntentId, options, requestOptions);
        }

        public virtual Task<SetupIntent> GetAsync(string paymentIntentId, SetupIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(paymentIntentId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SetupIntent> List(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<SetupIntent>> ListAsync(SetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SetupIntent> ListAutoPaging(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual SetupIntent Update(string paymentIntentId, SetupIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(paymentIntentId, options, requestOptions);
        }

        public virtual Task<SetupIntent> UpdateAsync(string paymentIntentId, SetupIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(paymentIntentId, options, requestOptions, cancellationToken);
        }
    }
}
