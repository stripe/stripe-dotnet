// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class OutboundPaymentService : Service<Stripe.Treasury.OutboundPayment>
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

        public virtual Stripe.Treasury.OutboundPayment Fail(string id, OutboundPaymentFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.OutboundPayment> FailAsync(string id, OutboundPaymentFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/fail", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Treasury.OutboundPayment Post(string id, OutboundPaymentPostOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/post", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.OutboundPayment> PostAsync(string id, OutboundPaymentPostOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/post", options, requestOptions, cancellationToken);
        }

        public virtual Stripe.Treasury.OutboundPayment ReturnOutboundPayment(string id, OutboundPaymentReturnOutboundPaymentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions);
        }

        public virtual Task<Stripe.Treasury.OutboundPayment> ReturnOutboundPaymentAsync(string id, OutboundPaymentReturnOutboundPaymentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/return", options, requestOptions, cancellationToken);
        }
    }
}
