using System.Threading.Tasks;
namespace Stripe
{
    public class StripeOAuthTokenService : StripeService
    {
        public StripeOAuthTokenService(string apiKey = null) : base(apiKey) { }

        public virtual StripeOAuthToken Create(StripeOAuthTokenCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.OAuthToken, false);

            var response = Requestor.PostStringBearer(url, ApiKey);

            return Mapper<StripeOAuthToken>.MapFromJson(response);
        }

        public virtual async Task<StripeOAuthToken> CreateAsync(StripeOAuthTokenCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.OAuthToken, false);

            var response = await Requestor.PostStringBearerAsync(url, ApiKey);

            return Mapper<StripeOAuthToken>.MapFromJson(response);
        }
    }
}
