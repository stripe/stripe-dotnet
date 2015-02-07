﻿#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeTokenService : StripeService
    {
        public StripeTokenService(string apiKey = null) : base(apiKey) { }

        public virtual StripeToken Create(StripeTokenCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Tokens, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeToken>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeToken> CreateAsync(StripeTokenCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Tokens, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeToken>.MapFromJson(response);
        }
#endif

        public virtual StripeToken Get(string tokenId)
        {
            var url = FormatGetUrl(tokenId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeToken>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeToken> GetAsync(string tokenId)
        {
            var url = FormatGetUrl(tokenId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeToken>.MapFromJson(response);
        }
#endif

        private static string FormatGetUrl(string tokenId)
        {
            var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);
            return url;
        }
    }
}