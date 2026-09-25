// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AuthenticationService : Service,
        ICreatable<Authentication, AuthenticationCreateOptions>,
        IListable<Authentication, AuthenticationListOptions>,
        IRetrievable<Authentication, AuthenticationGetOptions>
    {
        public AuthenticationService()
        {
        }

        internal AuthenticationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AuthenticationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>This endpoint cancels a 3DS Authentication. You can cancel a 3DS Authentication
        /// object when it’s in a non-final status: <c>requires_submission</c> or
        /// <c>requires_challenge</c>.</p>.
        /// </summary>
        public virtual Authentication Cancel(string id, AuthenticationCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authentication>(BaseAddress.Api, HttpMethod.Post, $"/v1/three_d_secure/authentications/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>This endpoint cancels a 3DS Authentication. You can cancel a 3DS Authentication
        /// object when it’s in a non-final status: <c>requires_submission</c> or
        /// <c>requires_challenge</c>.</p>.
        /// </summary>
        public virtual Task<Authentication> CancelAsync(string id, AuthenticationCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authentication>(BaseAddress.Api, HttpMethod.Post, $"/v1/three_d_secure/authentications/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>This endpoint creates a 3DS Authentication. Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#create-a-3ds-authentication-object">Create
        /// a 3DS Authentication object section of the Standalone 3DS guide</a> for more
        /// information.</p>.
        ///
        /// <p>You can pass the submit parameter to automatically submit the 3DS Authentication
        /// object when you create it. Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#submit-at-creation">Submit
        /// at creation section of the Standalone 3DS guide</a> for more information.</p>.
        /// </summary>
        public virtual Authentication Create(AuthenticationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Authentication>(BaseAddress.Api, HttpMethod.Post, $"/v1/three_d_secure/authentications", options, requestOptions);
        }

        /// <summary>
        /// <p>This endpoint creates a 3DS Authentication. Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#create-a-3ds-authentication-object">Create
        /// a 3DS Authentication object section of the Standalone 3DS guide</a> for more
        /// information.</p>.
        ///
        /// <p>You can pass the submit parameter to automatically submit the 3DS Authentication
        /// object when you create it. Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#submit-at-creation">Submit
        /// at creation section of the Standalone 3DS guide</a> for more information.</p>.
        /// </summary>
        public virtual Task<Authentication> CreateAsync(AuthenticationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authentication>(BaseAddress.Api, HttpMethod.Post, $"/v1/three_d_secure/authentications", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>This endpoint retrieves a 3DS Authentication.</p>.
        /// </summary>
        public virtual Authentication Get(string id, AuthenticationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authentication>(BaseAddress.Api, HttpMethod.Get, $"/v1/three_d_secure/authentications/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>This endpoint retrieves a 3DS Authentication.</p>.
        /// </summary>
        public virtual Task<Authentication> GetAsync(string id, AuthenticationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authentication>(BaseAddress.Api, HttpMethod.Get, $"/v1/three_d_secure/authentications/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of 3D Secure Authentications.</p>.
        /// </summary>
        public virtual StripeList<Authentication> List(AuthenticationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Authentication>>(BaseAddress.Api, HttpMethod.Get, $"/v1/three_d_secure/authentications", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of 3D Secure Authentications.</p>.
        /// </summary>
        public virtual Task<StripeList<Authentication>> ListAsync(AuthenticationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Authentication>>(BaseAddress.Api, HttpMethod.Get, $"/v1/three_d_secure/authentications", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of 3D Secure Authentications.</p>.
        /// </summary>
        public virtual IEnumerable<Authentication> ListAutoPaging(AuthenticationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Authentication>($"/v1/three_d_secure/authentications", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of 3D Secure Authentications.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Authentication> ListAutoPagingAsync(AuthenticationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Authentication>($"/v1/three_d_secure/authentications", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>This endpoint submits a 3DS Authentication. You can submit a 3DS Authentication
        /// object when it has status <c>requires_submission</c>. Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#submit-the-3ds-authentication-object">Submit
        /// the 3DS Authentication object section of the Standalone 3DS guide</a> for more
        /// information.</p>.
        /// </summary>
        public virtual Authentication Submit(string id, AuthenticationSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Authentication>(BaseAddress.Api, HttpMethod.Post, $"/v1/three_d_secure/authentications/{WebUtility.UrlEncode(id)}/submit", options, requestOptions);
        }

        /// <summary>
        /// <p>This endpoint submits a 3DS Authentication. You can submit a 3DS Authentication
        /// object when it has status <c>requires_submission</c>. Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#submit-the-3ds-authentication-object">Submit
        /// the 3DS Authentication object section of the Standalone 3DS guide</a> for more
        /// information.</p>.
        /// </summary>
        public virtual Task<Authentication> SubmitAsync(string id, AuthenticationSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Authentication>(BaseAddress.Api, HttpMethod.Post, $"/v1/three_d_secure/authentications/{WebUtility.UrlEncode(id)}/submit", options, requestOptions, cancellationToken);
        }
    }
}
