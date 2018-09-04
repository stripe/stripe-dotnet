namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class AccountService : StripeService,
        ICreatable<Account, AccountCreateOptions>,
        IDeletable<Account>,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account>,
        IUpdatable<Account, AccountUpdateOptions>
    {
        public AccountService()
            : base(null)
        {
        }

        public AccountService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBusinessLogo { get; set; }

        public virtual Account Create(AccountCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Account>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, $"{Urls.BaseUrl}/accounts", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Account> List(AccountListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            var path = $"{Urls.BaseUrl}/accounts";

            return Mapper<StripeList<Account>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, path, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Account Get(RequestOptions requestOptions = null)
        {
            return this.Get(string.Empty, requestOptions);
        }

        public virtual Account Get(string accountId, RequestOptions requestOptions = null)
        {
            var path = string.IsNullOrEmpty(accountId) ? $"{Urls.BaseUrl}/account" : $"{Urls.BaseUrl}/accounts/{accountId}";

            return Mapper<Account>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, path, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Account Update(string accountId, AccountUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Account>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Account Reject(string accountId, AccountRejectOptions rejectOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Account>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(rejectOptions, $"{Urls.BaseUrl}/accounts/{accountId}/reject", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Account Delete(string accountId, RequestOptions requestOptions = null)
        {
            return Mapper<Account>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(null, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Account> CreateAsync(AccountCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Account>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, $"{Urls.BaseUrl}/accounts", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Account>> ListAsync(AccountListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var path = $"{Urls.BaseUrl}/accounts";

            return Mapper<StripeList<Account>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, path, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual Task<Account> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetAsync(string.Empty, requestOptions, cancellationToken);
        }

        public virtual async Task<Account> GetAsync(string accountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var path = string.IsNullOrEmpty(accountId) ? $"{Urls.BaseUrl}/account" : $"{Urls.BaseUrl}/accounts/{accountId}";

            return Mapper<Account>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, path, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Account> UpdateAsync(string accountId, AccountUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Account>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Account> RejectAsync(string accountId, AccountRejectOptions rejectOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Account>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(rejectOptions, $"{Urls.BaseUrl}/accounts/{accountId}/reject", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Account> DeleteAsync(string accountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Account>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(null, $"{Urls.BaseUrl}/accounts/{accountId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
