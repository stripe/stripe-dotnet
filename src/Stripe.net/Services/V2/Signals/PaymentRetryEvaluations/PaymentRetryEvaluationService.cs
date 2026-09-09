// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentRetryEvaluationService : Service
    {
        internal PaymentRetryEvaluationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PaymentRetryEvaluationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels an active payment retry evaluation.
        /// </summary>
        public virtual PaymentRetryEvaluation Cancel(string id, PaymentRetryEvaluationCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/payment_retry_evaluations/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels an active payment retry evaluation.
        /// </summary>
        public virtual Task<PaymentRetryEvaluation> CancelAsync(string id, PaymentRetryEvaluationCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/payment_retry_evaluations/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a new payment retry evaluation for a failed payment.
        /// </summary>
        public virtual PaymentRetryEvaluation Create(PaymentRetryEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/payment_retry_evaluations", options, requestOptions);
        }

        /// <summary>
        /// Creates a new payment retry evaluation for a failed payment.
        /// </summary>
        public virtual Task<PaymentRetryEvaluation> CreateAsync(PaymentRetryEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/payment_retry_evaluations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a payment retry evaluation by ID.
        /// </summary>
        public virtual PaymentRetryEvaluation Get(string id, PaymentRetryEvaluationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/payment_retry_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a payment retry evaluation by ID.
        /// </summary>
        public virtual Task<PaymentRetryEvaluation> GetAsync(string id, PaymentRetryEvaluationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/payment_retry_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates an active payment retry evaluation with a replacement payment identifier.
        /// </summary>
        public virtual PaymentRetryEvaluation Update(string id, PaymentRetryEvaluationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/payment_retry_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates an active payment retry evaluation with a replacement payment identifier.
        /// </summary>
        public virtual Task<PaymentRetryEvaluation> UpdateAsync(string id, PaymentRetryEvaluationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRetryEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/payment_retry_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
