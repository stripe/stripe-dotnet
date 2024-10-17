namespace StripeTests
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe;

    public class DummyHttpClient : IHttpClient
    {
        public StripeResponse Response { get; set; }

        public StripeStreamedResponse StreamedResponse { get; set; }

        public StripeRequest LastRequest { get; set; }

        public Task<StripeResponse> MakeRequestAsync(
            StripeRequest request,
            CancellationToken cancellationToken = default)
        {
            this.LastRequest = request;

            if (this.Response == null)
            {
                throw new StripeTestException("Response is null");
            }

            return Task.FromResult<StripeResponse>(this.Response);
        }

        public Task<StripeStreamedResponse> MakeStreamingRequestAsync(
            StripeRequest request,
            CancellationToken cancellationToken = default)
        {
            this.LastRequest = request;

            if (this.StreamedResponse == null)
            {
                throw new StripeTestException("StreamedResponse is null");
            }

            return Task.FromResult(this.StreamedResponse);
        }
    }
}
