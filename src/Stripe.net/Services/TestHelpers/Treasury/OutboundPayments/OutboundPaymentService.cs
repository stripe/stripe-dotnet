// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class OutboundPaymentService : Service<OutboundPayment>
    {
        public OutboundPaymentService()
            : base(null)
        {
        }

        public OutboundPaymentService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/treasury/outbound_payments";

        public virtual OutboundPayment Fail(string id, OutboundPaymentFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions);
        }

        public virtual Task<OutboundPayment> FailAsync(string id, OutboundPaymentFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions, cancellationToken);
        }

        public virtual OutboundPayment Post(string id, OutboundPaymentPostOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/post", options, requestOptions);
        }

        public virtual Task<OutboundPayment> PostAsync(string id, OutboundPaymentPostOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/post", options, requestOptions, cancellationToken);
        }

        public virtual OutboundPayment ReturnOutboundPayment(string id, OutboundPaymentReturnOutboundPaymentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions);
        }

        public virtual Task<OutboundPayment> ReturnOutboundPaymentAsync(string id, OutboundPaymentReturnOutboundPaymentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions, cancellationToken);
        }
    }
}
