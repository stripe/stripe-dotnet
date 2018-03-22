using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService() : base(null) { }
        public StripeAccountService(string apiKey) : base(apiKey) { }

        public bool ExpandBusinessLogo { get; set; }



        //Sync
        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeAccount>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, $"{Urls.BaseUrl}/accounts", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeAccount> List(StripeAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var path = $"{Urls.BaseUrl}/accounts";

            return Mapper<StripeList<StripeAccount>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, path, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeAccount Get(StripeRequestOptions requestOptions = null)
        {
            return Get(string.Empty, requestOptions);
        }

        public virtual StripeAccount Get(string accountId, StripeRequestOptions requestOptions = null)
        {
            var path = string.IsNullOrEmpty(accountId) ? $"{Urls.BaseUrl}/account" : $"{Urls.BaseUrl}/accounts/{accountId}";

            return Mapper<StripeAccount>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, path, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeAccount Update(string accountId, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeAccount>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeAccount Reject(string accountId, StripeAccountRejectOptions rejectOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeAccount>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(rejectOptions, $"{Urls.BaseUrl}/accounts/{accountId}/reject", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string accountId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete(this.ApplyAllParameters(null, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeAccount> CreateAsync(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeAccount>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, $"{Urls.BaseUrl}/accounts", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeAccount>> ListAsync(StripeAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var path = $"{Urls.BaseUrl}/accounts";

            return Mapper<StripeList<StripeAccount>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, path, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual Task<StripeAccount> GetAsync(StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetAsync(string.Empty, requestOptions, cancellationToken);
        }

        public virtual async Task<StripeAccount> GetAsync(string accountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var path = string.IsNullOrEmpty(accountId) ? $"{Urls.BaseUrl}/account" : $"{Urls.BaseUrl}/accounts/{accountId}";

            return Mapper<StripeAccount>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, path, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeAccount> UpdateAsync(string accountId, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeAccount>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeAccount> RejectAsync(string accountId, StripeAccountRejectOptions rejectOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeAccount>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(rejectOptions, $"{Urls.BaseUrl}/accounts/{accountId}/reject", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string accountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync(this.ApplyAllParameters(null, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
