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
        /// <p>Test helper: closes a test-mode Issuing dispute as won or lost.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Dispute Close(string id, DisputeCloseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/close", options, requestOptions);
        }

        /// <summary>
        /// <p>Test helper: closes a test-mode Issuing dispute as won or lost.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Dispute> CloseAsync(string id, DisputeCloseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/close", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Test helper: overrides the <c>grant_deadline</c> and <c>revocable_after</c>
        /// timestamps on a test-mode Issuing dispute’s provisional credit, allowing tests to
        /// simulate timer-driven status transitions without waiting for real regulatory deadlines
        /// to pass.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Dispute ProvisionalCredit(string id, DisputeProvisionalCreditOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/provisional_credit", options, requestOptions);
        }

        /// <summary>
        /// <p>Test helper: overrides the <c>grant_deadline</c> and <c>revocable_after</c>
        /// timestamps on a test-mode Issuing dispute’s provisional credit, allowing tests to
        /// simulate timer-driven status transitions without waiting for real regulatory deadlines
        /// to pass.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Dispute> ProvisionalCreditAsync(string id, DisputeProvisionalCreditOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/provisional_credit", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Test helper: populates <c>network_lifecycle.dispute_response</c> on a test-mode Visa
        /// Issuing Dispute using placeholder file tokens. Only supported for Visa disputes.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Dispute SimulateNetworkLifecycleDisputeResponse(string id, DisputeSimulateNetworkLifecycleDisputeResponseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/simulate_network_lifecycle_dispute_response", options, requestOptions);
        }

        /// <summary>
        /// <p>Test helper: populates <c>network_lifecycle.dispute_response</c> on a test-mode Visa
        /// Issuing Dispute using placeholder file tokens. Only supported for Visa disputes.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Dispute> SimulateNetworkLifecycleDisputeResponseAsync(string id, DisputeSimulateNetworkLifecycleDisputeResponseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/simulate_network_lifecycle_dispute_response", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Test helper: populates <c>network_lifecycle.pre_arbitration_response</c> on a
        /// test-mode Visa Issuing Dispute using placeholder file tokens. Only supported for Visa
        /// disputes in the collaboration flow.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Dispute SimulateNetworkLifecyclePreArbitrationResponse(string id, DisputeSimulateNetworkLifecyclePreArbitrationResponseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/simulate_network_lifecycle_pre_arbitration_response", options, requestOptions);
        }

        /// <summary>
        /// <p>Test helper: populates <c>network_lifecycle.pre_arbitration_response</c> on a
        /// test-mode Visa Issuing Dispute using placeholder file tokens. Only supported for Visa
        /// disputes in the collaboration flow.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Dispute> SimulateNetworkLifecyclePreArbitrationResponseAsync(string id, DisputeSimulateNetworkLifecyclePreArbitrationResponseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/issuing/disputes/{WebUtility.UrlEncode(id)}/simulate_network_lifecycle_pre_arbitration_response", options, requestOptions, cancellationToken);
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
