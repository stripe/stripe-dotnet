// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class AuthorizationService : Service<Stripe.Issuing.Authorization>
    {
        public AuthorizationService()
        {
        }

        public AuthorizationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/issuing/authorizations";

        /// <summary>
        /// <p>Capture a test-mode authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Capture(string id, AuthorizationCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/capture", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Capture a test-mode authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> CaptureAsync(string id, AuthorizationCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/capture", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Create a test-mode authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Create(AuthorizationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Create a test-mode authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> CreateAsync(AuthorizationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Expire a test-mode Authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Expire(string id, AuthorizationExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/expire", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Expire a test-mode Authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> ExpireAsync(string id, AuthorizationExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/expire", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Increment a test-mode Authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Increment(string id, AuthorizationIncrementOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/increment", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Increment a test-mode Authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> IncrementAsync(string id, AuthorizationIncrementOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/increment", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Reverse a test-mode Authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Reverse(string id, AuthorizationReverseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/reverse", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Reverse a test-mode Authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> ReverseAsync(string id, AuthorizationReverseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/reverse", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
