// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class AuthorizationService : Service
    {
        public AuthorizationService()
        {
        }

        internal AuthorizationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AuthorizationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Capture a test-mode authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Capture(string id, AuthorizationCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/capture", options, requestOptions);
        }

        /// <summary>
        /// <p>Capture a test-mode authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> CaptureAsync(string id, AuthorizationCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/capture", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Create a test-mode authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Create(AuthorizationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a test-mode authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> CreateAsync(AuthorizationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Expire a test-mode Authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Expire(string id, AuthorizationExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/expire", options, requestOptions);
        }

        /// <summary>
        /// <p>Expire a test-mode Authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> ExpireAsync(string id, AuthorizationExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/expire", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Finalize the amount on an Authorization prior to capture, when the initial
        /// authorization was for an estimated amount.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization FinalizeAmount(string id, AuthorizationFinalizeAmountOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/finalize_amount", options, requestOptions);
        }

        /// <summary>
        /// <p>Finalize the amount on an Authorization prior to capture, when the initial
        /// authorization was for an estimated amount.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> FinalizeAmountAsync(string id, AuthorizationFinalizeAmountOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/finalize_amount", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Increment a test-mode Authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Increment(string id, AuthorizationIncrementOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/increment", options, requestOptions);
        }

        /// <summary>
        /// <p>Increment a test-mode Authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> IncrementAsync(string id, AuthorizationIncrementOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/increment", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Respond to a fraud challenge on a testmode Issuing authorization, simulating either a
        /// confirmation of fraud or a correction of legitimacy.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Respond(string id, AuthorizationRespondOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/fraud_challenges/respond", options, requestOptions);
        }

        /// <summary>
        /// <p>Respond to a fraud challenge on a testmode Issuing authorization, simulating either a
        /// confirmation of fraud or a correction of legitimacy.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> RespondAsync(string id, AuthorizationRespondOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/fraud_challenges/respond", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Reverse a test-mode Authorization.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Authorization Reverse(string id, AuthorizationReverseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/reverse", options, requestOptions);
        }

        /// <summary>
        /// <p>Reverse a test-mode Authorization.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Authorization> ReverseAsync(string id, AuthorizationReverseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Authorization>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/authorizations/{WebUtility.UrlEncode(id)}/reverse", options, requestOptions, cancellationToken);
        }
    }
}
