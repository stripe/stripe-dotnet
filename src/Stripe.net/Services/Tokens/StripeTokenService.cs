namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeTokenService : StripeService
    {
        public StripeTokenService()
            : base(null)
        {
        }

        public StripeTokenService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeToken Create(StripeTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeToken Get(string tokenId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                Requestor.GetString(
                    $"{Urls.Tokens}/{tokenId}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeToken> CreateAsync(StripeTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeToken> GetAsync(string tokenId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.GetStringAsync(
                   $"{Urls.Tokens}/{tokenId}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
