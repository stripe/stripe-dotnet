namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class AuthorizationService : Service<Authorization>,
        IListable<Authorization, AuthorizationListOptions>,
        IRetrievable<Authorization>,
        IUpdatable<Authorization, AuthorizationUpdateOptions>
    {
        public AuthorizationService()
            : base(null)
        {
        }

        public AuthorizationService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/issuing/authorizations";

        public virtual Authorization Approve(string authorizationId, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.PostRequest<Authorization>($"{this.InstanceUrl(authorizationId)}/approve", options, requestOptions);
        }

        public virtual Task<Authorization> ApproveAsync(string authorizationId, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<Authorization>($"{this.InstanceUrl(authorizationId)}/approve", options, requestOptions, cancellationToken);
        }

        public virtual Authorization Decline(string authorizationId, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null)
        {
            return this.PostRequest<Authorization>($"{this.InstanceUrl(authorizationId)}/decline", options, requestOptions);
        }

        public virtual Task<Authorization> DeclineAsync(string authorizationId, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<Authorization>($"{this.InstanceUrl(authorizationId)}/decline", options, requestOptions, cancellationToken);
        }

        public virtual Authorization Get(string authorizationId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(authorizationId, null, requestOptions);
        }

        public virtual Task<Authorization> GetAsync(string authorizationId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(authorizationId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Authorization> List(AuthorizationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Authorization>> ListAsync(AuthorizationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Authorization> ListAutoPaging(AuthorizationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Authorization Update(string authorizationId, AuthorizationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(authorizationId, options, requestOptions);
        }

        public virtual Task<Authorization> UpdateAsync(string authorizationId, AuthorizationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(authorizationId, options, requestOptions, cancellationToken);
        }
    }
}
