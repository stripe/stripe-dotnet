using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeAccount>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Accounts, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeAccount Get(string accountId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeAccount>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Accounts}/{accountId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeAccount Update(string accountId, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeAccount>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Accounts}/{accountId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string accountId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete(this.ApplyAllParameters(null, $"{Urls.Accounts}/{accountId}", false),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeAccount> CreateAsync(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeAccount>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Accounts, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeAccount> GetAsync(string accountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeAccount>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Accounts}/{accountId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeAccount> UpdateAsync(string accountId, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeAccount>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Accounts}/{accountId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string accountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync(this.ApplyAllParameters(null, $"{Urls.Accounts}/{accountId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}
