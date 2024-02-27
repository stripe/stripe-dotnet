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
            : base(null)
        {
        }

        public AuthorizationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/issuing/authorizations";

        public virtual Stripe.Issuing.Authorization Capture(string id, AuthorizationCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/capture", options, requestOptions);
        }

        public virtual Task<Stripe.Issuing.Authorization> CaptureAsync(string id, AuthorizationCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/capture", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Issuing.Authorization Create(AuthorizationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations", options, requestOptions);
        }

        public virtual Task<Stripe.Issuing.Authorization> CreateAsync(AuthorizationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Issuing.Authorization Expire(string id, AuthorizationExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/expire", options, requestOptions);
        }

        public virtual Task<Stripe.Issuing.Authorization> ExpireAsync(string id, AuthorizationExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/expire", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Issuing.Authorization Increment(string id, AuthorizationIncrementOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/increment", options, requestOptions);
        }

        public virtual Task<Stripe.Issuing.Authorization> IncrementAsync(string id, AuthorizationIncrementOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/increment", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Issuing.Authorization Reverse(string id, AuthorizationReverseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/reverse", options, requestOptions);
        }

        public virtual Task<Stripe.Issuing.Authorization> ReverseAsync(string id, AuthorizationReverseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{id}/reverse", options, requestOptions, cancellationToken);
        }
    }
}
