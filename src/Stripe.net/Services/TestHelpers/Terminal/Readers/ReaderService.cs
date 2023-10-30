// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Terminal;

    public class ReaderService : Service<Stripe.Terminal.Reader>
    {
        public ReaderService()
            : base(null)
        {
        }

        public ReaderService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/terminal/readers";

        public virtual Stripe.Terminal.Reader PresentPaymentMethod(string id, ReaderPresentPaymentMethodOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/present_payment_method", options, requestOptions);
        }

        public virtual Task<Stripe.Terminal.Reader> PresentPaymentMethodAsync(string id, ReaderPresentPaymentMethodOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/present_payment_method", options, requestOptions, cancellationToken);
        }
    }
}
