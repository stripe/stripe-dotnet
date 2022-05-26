// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe;

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

        public override string BasePath => "/v1/test_helpers/refunds";

        public virtual Refund Expire(string id, RefundExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/expire", options, requestOptions);
        }

        public virtual Task<Refund> ExpireAsync(string id, RefundExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/expire", options, requestOptions, cancellationToken);
        }
    }
}
