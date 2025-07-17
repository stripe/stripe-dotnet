// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OnboardingLinkService : Service,
        ICreatable<OnboardingLink, OnboardingLinkCreateOptions>
    {
        public OnboardingLinkService()
        {
        }

        internal OnboardingLinkService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public OnboardingLinkService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new <c>OnboardingLink</c> object that contains a redirect_url used for
        /// onboarding onto Tap to Pay on iPhone.</p>.
        /// </summary>
        public virtual OnboardingLink Create(OnboardingLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OnboardingLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/onboarding_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>OnboardingLink</c> object that contains a redirect_url used for
        /// onboarding onto Tap to Pay on iPhone.</p>.
        /// </summary>
        public virtual Task<OnboardingLink> CreateAsync(OnboardingLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OnboardingLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/onboarding_links", options, requestOptions, cancellationToken);
        }
    }
}
