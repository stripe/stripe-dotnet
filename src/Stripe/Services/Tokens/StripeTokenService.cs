using System.Threading.Tasks;

﻿namespace Stripe
{
    public class StripeTokenService : StripeService
    {
        public StripeTokenService(string apiKey = null) : base(apiKey) { }

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

#if !PORTABLE
        public virtual async Task<StripeToken> CreateAsync(StripeTokenCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Tokens, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeToken> GetAsync(string tokenId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeToken>.MapFromJson(
                await Requestor.GetStringAsync($"{Urls.Tokens}/{tokenId}",
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}
