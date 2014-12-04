using System.Threading.Tasks;

namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }

        public virtual StripeAccount Get()
        {
            var response = Requestor.GetString(Urls.Account, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual async Task<StripeAccount> GetAsync()
        {
            var response = await Requestor.GetStringAsync(Urls.Account, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
    }
}