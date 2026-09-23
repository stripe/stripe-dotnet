// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EligibilityService : Service
    {
        internal EligibilityService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal EligibilityService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Checks whether a project is eligible to provision resources with a provider, including
        /// any outstanding KYC requirements that must be satisfied first.
        /// </summary>
        public virtual Eligibility Get(EligibilityGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Eligibility>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/eligibility", options, requestOptions);
        }

        /// <summary>
        /// Checks whether a project is eligible to provision resources with a provider, including
        /// any outstanding KYC requirements that must be satisfied first.
        /// </summary>
        public virtual Task<Eligibility> GetAsync(EligibilityGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Eligibility>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/eligibility", options, requestOptions, cancellationToken);
        }
    }
}
