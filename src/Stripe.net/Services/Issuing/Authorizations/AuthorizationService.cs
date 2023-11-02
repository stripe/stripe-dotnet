// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AuthorizationService : Service<Authorization>,
        IListable<Authorization, AuthorizationListOptions>,
        IRetrievable<Authorization, AuthorizationGetOptions>,
        IUpdatable<Authorization, AuthorizationUpdateOptions>
    {
        public AuthorizationService()
            : base(null)
        {
        }

        public AuthorizationService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/authorizations";

        public virtual Authorization Approve(string id, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/approve", options, requestOptions);
        }

        public virtual Task<Authorization> ApproveAsync(string id, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/approve", options, requestOptions, cancellationToken);
        }

        public virtual Authorization Decline(string id, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/decline", options, requestOptions);
        }

        public virtual Task<Authorization> DeclineAsync(string id, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/decline", options, requestOptions, cancellationToken);
        }

        public virtual Authorization Get(string id, AuthorizationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Get, $"/v1/issuing/authorizations/{id}", options, requestOptions);
        }

        public virtual Task<Authorization> GetAsync(string id, AuthorizationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Get, $"/v1/issuing/authorizations/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Authorization> List(AuthorizationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Authorization>>(HttpMethod.Get, $"/v1/issuing/authorizations", options, requestOptions);
        }

        public virtual Task<StripeList<Authorization>> ListAsync(AuthorizationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Authorization>>(HttpMethod.Get, $"/v1/issuing/authorizations", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Authorization> ListAutoPaging(AuthorizationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Authorization>($"/v1/issuing/authorizations", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Authorization> ListAutoPagingAsync(AuthorizationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Authorization>($"/v1/issuing/authorizations", options, requestOptions, cancellationToken);
        }

        public virtual Authorization Update(string id, AuthorizationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}", options, requestOptions);
        }

        public virtual Task<Authorization> UpdateAsync(string id, AuthorizationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}", options, requestOptions, cancellationToken);
        }
    }
}
