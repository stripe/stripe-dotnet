// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class DisputeService : Service
    {
        public DisputeService()
        {
        }

        internal DisputeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public DisputeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Test helper: populates <c>network_lifecycle.pre_arbitration_submission</c> on a
        /// test-mode Visa Issuing Dispute using placeholder file tokens. Only supported for Visa
        /// disputes.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Dispute SimulateNetworkLifecyclePreArbitrationSubmission(string id, DisputeSimulateNetworkLifecyclePreArbitrationSubmissionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/simulate_network_lifecycle_pre_arbitration_submission", options, requestOptions);
        }

        /// <summary>
        /// <p>Test helper: populates <c>network_lifecycle.pre_arbitration_submission</c> on a
        /// test-mode Visa Issuing Dispute using placeholder file tokens. Only supported for Visa
        /// disputes.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Dispute> SimulateNetworkLifecyclePreArbitrationSubmissionAsync(string id, DisputeSimulateNetworkLifecyclePreArbitrationSubmissionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/simulate_network_lifecycle_pre_arbitration_submission", options, requestOptions, cancellationToken);
        }
    }
}
