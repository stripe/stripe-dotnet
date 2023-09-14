// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class TransactionService : Service<Transaction>
    {
        public TransactionService()
            : base(null)
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/issuing/transactions";

        public virtual Transaction CreateForceCapture(TransactionCreateForceCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("create_force_capture")}", options, requestOptions);
        }

        public virtual Task<Transaction> CreateForceCaptureAsync(TransactionCreateForceCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("create_force_capture")}", options, requestOptions, cancellationToken);
        }

        public virtual Transaction CreateUnlinkedRefund(TransactionCreateUnlinkedRefundOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("create_unlinked_refund")}", options, requestOptions);
        }

        public virtual Task<Transaction> CreateUnlinkedRefundAsync(TransactionCreateUnlinkedRefundOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("create_unlinked_refund")}", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Refund(string id, TransactionRefundOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/refund", options, requestOptions);
        }

        public virtual Task<Transaction> RefundAsync(string id, TransactionRefundOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/refund", options, requestOptions, cancellationToken);
        }
    }
}
