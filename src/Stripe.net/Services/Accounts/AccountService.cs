// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountService : Service<Account>,
        ICreatable<Account, AccountCreateOptions>,
        IDeletable<Account, AccountDeleteOptions>,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account, AccountGetOptions>,
        IUpdatable<Account, AccountUpdateOptions>
    {
        public AccountService()
        {
        }

        public AccountService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/accounts";

        /// <summary>
        /// <p>With <a href="https://stripe.com/docs/connect">Connect</a>, you can create Stripe
        /// accounts for your users. To do this, you’ll first need to <a
        /// href="https://dashboard.stripe.com/account/applications/settings">register your
        /// platform</a>.</p>.
        ///
        /// <p>If you’ve already collected information for your connected accounts, you <a
        /// href="https://stripe.com/docs/connect/best-practices#onboarding">can prefill that
        /// information</a> when creating the account. Connect Onboarding won’t ask for the
        /// prefilled information during account onboarding. You can prefill any information on the
        /// account.</p>.
        /// </summary>
        public virtual Account Create(AccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>With <a href="https://stripe.com/docs/connect">Connect</a>, you can create Stripe
        /// accounts for your users. To do this, you’ll first need to <a
        /// href="https://dashboard.stripe.com/account/applications/settings">register your
        /// platform</a>.</p>.
        ///
        /// <p>If you’ve already collected information for your connected accounts, you <a
        /// href="https://stripe.com/docs/connect/best-practices#onboarding">can prefill that
        /// information</a> when creating the account. Connect Onboarding won’t ask for the
        /// prefilled information during account onboarding. You can prefill any information on the
        /// account.</p>.
        /// </summary>
        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>With <a href="https://stripe.com/connect">Connect</a>, you can delete accounts you
        /// manage.</p>.
        ///
        /// <p>Test-mode accounts can be deleted at any time.</p>.
        ///
        /// <p>Live-mode accounts where Stripe is responsible for negative account balances cannot
        /// be deleted, which includes Standard accounts. Live-mode accounts where your platform is
        /// liable for negative account balances, which includes Custom and Express accounts, can be
        /// deleted when all <a href="https://stripe.com/api/balance/balance_object">balances</a>
        /// are zero.</p>.
        ///
        /// <p>If you want to delete your own account, use the <a
        /// href="https://dashboard.stripe.com/settings/account">account information tab in your
        /// account settings</a> instead.</p>.
        /// </summary>
        public virtual Account Delete(string id, AccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Delete, $"/v1/accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>With <a href="https://stripe.com/connect">Connect</a>, you can delete accounts you
        /// manage.</p>.
        ///
        /// <p>Test-mode accounts can be deleted at any time.</p>.
        ///
        /// <p>Live-mode accounts where Stripe is responsible for negative account balances cannot
        /// be deleted, which includes Standard accounts. Live-mode accounts where your platform is
        /// liable for negative account balances, which includes Custom and Express accounts, can be
        /// deleted when all <a href="https://stripe.com/api/balance/balance_object">balances</a>
        /// are zero.</p>.
        ///
        /// <p>If you want to delete your own account, use the <a
        /// href="https://dashboard.stripe.com/settings/account">account information tab in your
        /// account settings</a> instead.</p>.
        /// </summary>
        public virtual Task<Account> DeleteAsync(string id, AccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Delete, $"/v1/accounts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an account.</p>.
        /// </summary>
        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Get, $"/v1/accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an account.</p>.
        /// </summary>
        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Get, $"/v1/accounts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of accounts connected to your platform via <a
        /// href="https://stripe.com/docs/connect">Connect</a>. If you’re not a platform, the list
        /// is empty.</p>.
        /// </summary>
        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Account>>(HttpMethod.Get, $"/v1/accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of accounts connected to your platform via <a
        /// href="https://stripe.com/docs/connect">Connect</a>. If you’re not a platform, the list
        /// is empty.</p>.
        /// </summary>
        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Account>>(HttpMethod.Get, $"/v1/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of accounts connected to your platform via <a
        /// href="https://stripe.com/docs/connect">Connect</a>. If you’re not a platform, the list
        /// is empty.</p>.
        /// </summary>
        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Account>($"/v1/accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of accounts connected to your platform via <a
        /// href="https://stripe.com/docs/connect">Connect</a>. If you’re not a platform, the list
        /// is empty.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Account> ListAutoPagingAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Account>($"/v1/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>With <a href="https://stripe.com/connect">Connect</a>, you can reject accounts that
        /// you have flagged as suspicious.</p>.
        ///
        /// <p>Only accounts where your platform is liable for negative account balances, which
        /// includes Custom and Express accounts, can be rejected. Test-mode accounts can be
        /// rejected at any time. Live-mode accounts can only be rejected after all balances are
        /// zero.</p>.
        /// </summary>
        public virtual Account Reject(string id, AccountRejectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/accounts/{id}/reject", options, requestOptions);
        }

        /// <summary>
        /// <p>With <a href="https://stripe.com/connect">Connect</a>, you can reject accounts that
        /// you have flagged as suspicious.</p>.
        ///
        /// <p>Only accounts where your platform is liable for negative account balances, which
        /// includes Custom and Express accounts, can be rejected. Test-mode accounts can be
        /// rejected at any time. Live-mode accounts can only be rejected after all balances are
        /// zero.</p>.
        /// </summary>
        public virtual Task<Account> RejectAsync(string id, AccountRejectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/accounts/{id}/reject", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a <a href="https://stripe.com/connect/accounts">connected account</a> by
        /// setting the values of the parameters passed. Any parameters not provided are left
        /// unchanged.</p>.
        ///
        /// <p>For accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts, you can update any information on
        /// the account.</p>.
        ///
        /// <p>For accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>, which includes Standard and Express accounts, you can update all
        /// information until you create an <a href="https://stripe.com/api/account_links">Account
        /// Link</a> or <a href="https://stripe.com/api/account_sessions">Account Session</a> to
        /// start Connect onboarding, after which some properties can no longer be updated.</p>.
        ///
        /// <p>To update your own account, use the <a
        /// href="https://dashboard.stripe.com/settings/account">Dashboard</a>. Refer to our <a
        /// href="https://stripe.com/docs/connect/updating-accounts">Connect</a> documentation to
        /// learn more about updating accounts.</p>.
        /// </summary>
        public virtual Account Update(string id, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a <a href="https://stripe.com/connect/accounts">connected account</a> by
        /// setting the values of the parameters passed. Any parameters not provided are left
        /// unchanged.</p>.
        ///
        /// <p>For accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts, you can update any information on
        /// the account.</p>.
        ///
        /// <p>For accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>stripe</c>, which includes Standard and Express accounts, you can update all
        /// information until you create an <a href="https://stripe.com/api/account_links">Account
        /// Link</a> or <a href="https://stripe.com/api/account_sessions">Account Session</a> to
        /// start Connect onboarding, after which some properties can no longer be updated.</p>.
        ///
        /// <p>To update your own account, use the <a
        /// href="https://dashboard.stripe.com/settings/account">Dashboard</a>. Refer to our <a
        /// href="https://stripe.com/docs/connect/updating-accounts">Connect</a> documentation to
        /// learn more about updating accounts.</p>.
        /// </summary>
        public virtual Task<Account> UpdateAsync(string id, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Account GetSelf(RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Get, "/v1/account", null, requestOptions);
        }

        public virtual Task<Account> GetSelfAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Get, "/v1/account", null, requestOptions, cancellationToken);
        }
    }
}
