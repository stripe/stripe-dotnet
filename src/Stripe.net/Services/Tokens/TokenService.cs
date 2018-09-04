namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TokenService : StripeService,
        ICreatable<Token, TokenCreateOptions>,
        IRetrievable<Token>
    {
        public TokenService()
            : base(null)
        {
        }

        public TokenService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Token Create(TokenCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Token>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Token Get(string tokenId, RequestOptions requestOptions = null)
        {
            return Mapper<Token>.MapFromJson(
                Requestor.GetString(
                    $"{Urls.Tokens}/{tokenId}",
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Token> CreateAsync(TokenCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Token>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Token> GetAsync(string tokenId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Token>.MapFromJson(
                await Requestor.GetStringAsync(
                   $"{Urls.Tokens}/{tokenId}",
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
