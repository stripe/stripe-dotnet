// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class TransactionService : Service<Stripe.Issuing.Transaction>
    {
        public TransactionService()
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/issuing/transactions";

        /// <summary>
        /// <p>Allows the user to capture an arbitrary amount, also known as a forced capture.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Transaction CreateForceCapture(TransactionCreateForceCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Transaction>(HttpMethod.Post, $"/v1/test_helpers/issuing/transactions/create_force_capture", options, requestOptions);
        }

        /// <summary>
        /// <p>Allows the user to capture an arbitrary amount, also known as a forced capture.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Transaction> CreateForceCaptureAsync(TransactionCreateForceCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Transaction>(HttpMethod.Post, $"/v1/test_helpers/issuing/transactions/create_force_capture", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Allows the user to refund an arbitrary amount, also known as a unlinked refund.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Transaction CreateUnlinkedRefund(TransactionCreateUnlinkedRefundOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Transaction>(HttpMethod.Post, $"/v1/test_helpers/issuing/transactions/create_unlinked_refund", options, requestOptions);
        }

        /// <summary>
        /// <p>Allows the user to refund an arbitrary amount, also known as a unlinked refund.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Transaction> CreateUnlinkedRefundAsync(TransactionCreateUnlinkedRefundOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Transaction>(HttpMethod.Post, $"/v1/test_helpers/issuing/transactions/create_unlinked_refund", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Refund a test-mode Transaction.</p>.
        /// </summary>
        public virtual Stripe.Issuing.Transaction Refund(string id, TransactionRefundOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.Transaction>(HttpMethod.Post, $"/v1/test_helpers/issuing/transactions/{id}/refund", options, requestOptions);
        }

        /// <summary>
        /// <p>Refund a test-mode Transaction.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.Transaction> RefundAsync(string id, TransactionRefundOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.Transaction>(HttpMethod.Post, $"/v1/test_helpers/issuing/transactions/{id}/refund", options, requestOptions, cancellationToken);
        }
    }
}
