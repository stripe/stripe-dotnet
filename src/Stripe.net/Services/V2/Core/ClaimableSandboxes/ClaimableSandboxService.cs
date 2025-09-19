// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ClaimableSandboxService : Service
    {
        internal ClaimableSandboxService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ClaimableSandboxService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create an anonymous, claimable sandbox. This sandbox can be prefilled with data. The
        /// response will include a claim URL that allow a user to claim the account.
        /// </summary>
        public virtual ClaimableSandbox Create(ClaimableSandboxCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ClaimableSandbox>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/claimable_sandboxes", options, requestOptions);
        }

        /// <summary>
        /// Create an anonymous, claimable sandbox. This sandbox can be prefilled with data. The
        /// response will include a claim URL that allow a user to claim the account.
        /// </summary>
        public virtual Task<ClaimableSandbox> CreateAsync(ClaimableSandboxCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ClaimableSandbox>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/claimable_sandboxes", options, requestOptions, cancellationToken);
        }
    }
}
