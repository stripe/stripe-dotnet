// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RefundService : Service<Refund>
    {
        public RefundService()
            : base(null)
        {
        }

        public RefundService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/refunds";

        public virtual Refund Expire(string id, RefundExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Post, $"/v1/test_helpers/refunds/{id}/expire", options, requestOptions);
        }

        public virtual Task<Refund> ExpireAsync(string id, RefundExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Post, $"/v1/test_helpers/refunds/{id}/expire", options, requestOptions, cancellationToken);
        }
    }
}
