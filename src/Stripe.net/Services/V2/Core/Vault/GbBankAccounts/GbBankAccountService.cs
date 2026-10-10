// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class GbBankAccountService : Service
    {
        internal GbBankAccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal GbBankAccountService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Archive a GBBankAccount object. Archived GBBankAccount objects cannot be used as
        /// outbound destinations and will not appear in the outbound destination list.
        /// </summary>
        public virtual GbBankAccount Archive(string id, GbBankAccountArchiveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}/archive", options, requestOptions);
        }

        /// <summary>
        /// Archive a GBBankAccount object. Archived GBBankAccount objects cannot be used as
        /// outbound destinations and will not appear in the outbound destination list.
        /// </summary>
        public virtual Task<GbBankAccount> ArchiveAsync(string id, GbBankAccountArchiveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}/archive", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a GB bank account.
        /// </summary>
        public virtual GbBankAccount Create(GbBankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts", options, requestOptions);
        }

        /// <summary>
        /// Create a GB bank account.
        /// </summary>
        public virtual Task<GbBankAccount> CreateAsync(GbBankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a GB bank account.
        /// </summary>
        public virtual GbBankAccount Get(string id, GbBankAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GbBankAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a GB bank account.
        /// </summary>
        public virtual Task<GbBankAccount> GetAsync(string id, GbBankAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GbBankAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List objects that can be used as destinations for outbound money movement via
        /// OutboundPayment.
        /// </summary>
        public virtual V2.StripeList<GbBankAccount> List(GbBankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<GbBankAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/gb_bank_accounts", options, requestOptions);
        }

        /// <summary>
        /// List objects that can be used as destinations for outbound money movement via
        /// OutboundPayment.
        /// </summary>
        public virtual Task<V2.StripeList<GbBankAccount>> ListAsync(GbBankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<GbBankAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/gb_bank_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List objects that can be used as destinations for outbound money movement via
        /// OutboundPayment.
        /// </summary>
        public virtual IEnumerable<GbBankAccount> ListAutoPaging(GbBankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<GbBankAccount>($"/v2/core/vault/gb_bank_accounts", options, requestOptions);
        }

        /// <summary>
        /// List objects that can be used as destinations for outbound money movement via
        /// OutboundPayment.
        /// </summary>
        public virtual IAsyncEnumerable<GbBankAccount> ListAutoPagingAsync(GbBankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<GbBankAccount>($"/v2/core/vault/gb_bank_accounts", options, requestOptions, cancellationToken);
        }
    }
}
