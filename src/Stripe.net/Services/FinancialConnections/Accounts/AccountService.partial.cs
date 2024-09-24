namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class AccountService
    {
        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        [Obsolete("Use AccountOwnerService.List instead.")]
        public virtual StripeList<AccountOwner> ListOwners(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountOwner>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{id}/owners", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        [Obsolete("Use AccountOwnerService.ListASync instead.")]
        public virtual Task<StripeList<AccountOwner>> ListOwnersAsync(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountOwner>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{id}/owners", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        [Obsolete("Use AccountOwnerService.ListAutoPaging instead.")]
        public virtual IEnumerable<AccountOwner> ListOwnersAutoPaging(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountOwner>($"/v1/financial_connections/accounts/{id}/owners", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        [Obsolete("Use AccountOwnerService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<AccountOwner> ListOwnersAutoPagingAsync(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountOwner>($"/v1/financial_connections/accounts/{id}/owners", options, requestOptions, cancellationToken);
        }
    }
}
