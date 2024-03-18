// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
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
        {
        }

        public AuthorizationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/authorizations";

        /// <summary>
        /// <p>[Deprecated] Approves a pending Issuing <c>Authorization</c> object. This request
        /// should be made within the timeout window of the <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations">real-time
        /// authorization</a> flow. This method is deprecated. Instead, <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations#authorization-handling">respond
        /// directly to the webhook request to approve an authorization</a>.</p>.
        /// </summary>
        [Obsolete("This method is deprecated, please refer to the description for details.")]
        public virtual Authorization Approve(string id, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/approve", options, requestOptions);
        }

        /// <summary>
        /// <p>[Deprecated] Approves a pending Issuing <c>Authorization</c> object. This request
        /// should be made within the timeout window of the <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations">real-time
        /// authorization</a> flow. This method is deprecated. Instead, <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations#authorization-handling">respond
        /// directly to the webhook request to approve an authorization</a>.</p>.
        /// </summary>
        [Obsolete("This method is deprecated, please refer to the description for details.")]
        public virtual Task<Authorization> ApproveAsync(string id, AuthorizationApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/approve", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>[Deprecated] Declines a pending Issuing <c>Authorization</c> object. This request
        /// should be made within the timeout window of the <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations">real time
        /// authorization</a> flow. This method is deprecated. Instead, <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations#authorization-handling">respond
        /// directly to the webhook request to decline an authorization</a>.</p>.
        /// </summary>
        [Obsolete("This method is deprecated, please refer to the description for details.")]
        public virtual Authorization Decline(string id, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/decline", options, requestOptions);
        }

        /// <summary>
        /// <p>[Deprecated] Declines a pending Issuing <c>Authorization</c> object. This request
        /// should be made within the timeout window of the <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations">real time
        /// authorization</a> flow. This method is deprecated. Instead, <a
        /// href="https://stripe.com/docs/issuing/controls/real-time-authorizations#authorization-handling">respond
        /// directly to the webhook request to decline an authorization</a>.</p>.
        /// </summary>
        [Obsolete("This method is deprecated, please refer to the description for details.")]
        public virtual Task<Authorization> DeclineAsync(string id, AuthorizationDeclineOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}/decline", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>Authorization</c> object.</p>.
        /// </summary>
        public virtual Authorization Get(string id, AuthorizationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Get, $"/v1/issuing/authorizations/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>Authorization</c> object.</p>.
        /// </summary>
        public virtual Task<Authorization> GetAsync(string id, AuthorizationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Get, $"/v1/issuing/authorizations/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Authorization</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<Authorization> List(AuthorizationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Authorization>>(HttpMethod.Get, $"/v1/issuing/authorizations", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Authorization</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<Authorization>> ListAsync(AuthorizationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Authorization>>(HttpMethod.Get, $"/v1/issuing/authorizations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Authorization</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<Authorization> ListAutoPaging(AuthorizationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Authorization>($"/v1/issuing/authorizations", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>Authorization</c> objects. The objects are sorted in
        /// descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Authorization> ListAutoPagingAsync(AuthorizationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Authorization>($"/v1/issuing/authorizations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified Issuing <c>Authorization</c> object by setting the values of
        /// the parameters passed. Any parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Authorization Update(string id, AuthorizationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified Issuing <c>Authorization</c> object by setting the values of
        /// the parameters passed. Any parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Task<Authorization> UpdateAsync(string id, AuthorizationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authorization>(HttpMethod.Post, $"/v1/issuing/authorizations/{id}", options, requestOptions, cancellationToken);
        }
    }
}
