// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountOwnerService : Service,
        INestedListable<AccountOwner, AccountOwnerListOptions>
    {
        public AccountOwnerService()
        {
        }

        internal AccountOwnerService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountOwnerService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual StripeList<AccountOwner> List(string parentId, AccountOwnerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountOwner>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/owners", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual Task<StripeList<AccountOwner>> ListAsync(string parentId, AccountOwnerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountOwner>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/owners", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual IEnumerable<AccountOwner> ListAutoPaging(string parentId, AccountOwnerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountOwner>($"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/owners", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual IAsyncEnumerable<AccountOwner> ListAutoPagingAsync(string parentId, AccountOwnerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountOwner>($"/v1/financial_connections/accounts/{WebUtility.UrlEncode(parentId)}/owners", options, requestOptions, cancellationToken);
        }
    }
}
