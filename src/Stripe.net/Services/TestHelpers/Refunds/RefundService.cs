// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RefundService : Service
    {
        public RefundService()
        {
        }

        internal RefundService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public RefundService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Expire a refund with a status of <c>requires_action</c>.</p>.
        /// </summary>
        public virtual Refund Expire(string id, RefundExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/refunds/{WebUtility.UrlEncode(id)}/expire", options, requestOptions);
        }

        /// <summary>
        /// <p>Expire a refund with a status of <c>requires_action</c>.</p>.
        /// </summary>
        public virtual Task<Refund> ExpireAsync(string id, RefundExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/refunds/{WebUtility.UrlEncode(id)}/expire", options, requestOptions, cancellationToken);
        }
    }
}
