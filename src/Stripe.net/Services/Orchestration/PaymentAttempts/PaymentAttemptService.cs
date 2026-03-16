// File generated from our OpenAPI spec
namespace Stripe.Orchestration
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentAttemptService : Service,
        IRetrievable<PaymentAttempt, PaymentAttemptGetOptions>
    {
        public PaymentAttemptService()
        {
        }

        internal PaymentAttemptService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentAttemptService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves orchestration information for the given payment attempt record (e.g. return
        /// url).</p>.
        /// </summary>
        public virtual PaymentAttempt Get(string id, PaymentAttemptGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttempt>(BaseAddress.Api, HttpMethod.Get, $"/v1/orchestration/payment_attempts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves orchestration information for the given payment attempt record (e.g. return
        /// url).</p>.
        /// </summary>
        public virtual Task<PaymentAttempt> GetAsync(string id, PaymentAttemptGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttempt>(BaseAddress.Api, HttpMethod.Get, $"/v1/orchestration/payment_attempts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
