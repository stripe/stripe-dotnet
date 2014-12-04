#if NET40
using System.Threading.Tasks;
#endif

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

#if NET40
        public virtual async Task<StripeAccount> GetAsync()
        {
            var response = await Requestor.GetStringAsync(Urls.Account, ApiKey);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
#endif
    }
}