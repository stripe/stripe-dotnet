namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TokenService : StripeService
    {
        public TokenService()
            : base(null)
        {
        }

        public TokenService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeToken Create(TokenCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeToken Get(string tokenId, RequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                Requestor.GetString(
                    $"{Urls.Tokens}/{tokenId}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeToken> CreateAsync(TokenCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeToken> GetAsync(string tokenId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.GetStringAsync(
                   $"{Urls.Tokens}/{tokenId}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
