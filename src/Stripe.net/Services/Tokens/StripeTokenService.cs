using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTokenService : StripeService
    {
        public StripeTokenService() : base(null) { }
        public StripeTokenService(string apiKey) : base(apiKey) { }



        //Sync
        public virtual StripeToken Create(StripeTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeToken Get(string tokenId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                Requestor.GetString($"{Urls.Tokens}/{tokenId}",
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeToken> CreateAsync(StripeTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeToken> GetAsync(string tokenId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.GetStringAsync($"{Urls.Tokens}/{tokenId}",
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
