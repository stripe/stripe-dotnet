namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class AuthorizationService : Service<Authorization>,
        IListable<Authorization, AuthorizationListOptions>,
        IRetrievable<Authorization>,
        IUpdatable<Authorization, AuthorizationUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/authorizations";

        public AuthorizationService()
            : base(null)
        {
        }

        public AuthorizationService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Authorization Approve(string authorizationId, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{authorizationId}/approve", requestOptions, options);
        }

        public virtual Authorization Decline(string authorizationId, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{authorizationId}/decline", requestOptions, options);
        }

        public virtual Authorization Get(string authorizationId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{authorizationId}", requestOptions);
        }

        public virtual StripeList<Authorization> List(AuthorizationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Authorization Update(string authorizationId, AuthorizationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{authorizationId}", requestOptions, options);
        }

        public virtual Task<Authorization> ApproveAsync(string authorizationId, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{authorizationId}/approve", requestOptions, cancellationToken, options);
        }

        public virtual Task<Authorization> DeclineAsync(string authorizationId, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{authorizationId}/decline", requestOptions, cancellationToken, options);
        }

        public virtual Task<Authorization> GetAsync(string authorizationId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{authorizationId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Authorization>> ListAsync(AuthorizationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Authorization> UpdateAsync(string authorizationId, AuthorizationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{authorizationId}", requestOptions, cancellationToken, options);
        }
    }
}
