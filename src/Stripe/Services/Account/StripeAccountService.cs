using Stripe.Entities;

namespace Stripe
{
    public class StripeAccountService
    {
        public StripeAccountService(string apiKey = null)
        {
            ApiKey = apiKey;
        }

        private string ApiKey { get; set; }

        public StripeAccount Get()
        {
            string url = ParameterBuilder.ApplyAllParameters(null, Urls.Account);

            string response = Requestor.GetStringBearer(url, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
    }
}