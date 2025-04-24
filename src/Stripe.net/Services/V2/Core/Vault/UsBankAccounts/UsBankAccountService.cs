// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class UsBankAccountService : Service
    {
        internal UsBankAccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal UsBankAccountService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Archive a USBankAccount object. USBankAccount objects will not be automatically archived
        /// by Stripe. Archived USBankAccount objects cannot be used as outbound destinations and
        /// will not appear in the outbound destination list.
        /// </summary>
        public virtual UsBankAccount Archive(string id, UsBankAccountArchiveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}/archive", options, requestOptions);
        }

        /// <summary>
        /// Archive a USBankAccount object. USBankAccount objects will not be automatically archived
        /// by Stripe. Archived USBankAccount objects cannot be used as outbound destinations and
        /// will not appear in the outbound destination list.
        /// </summary>
        public virtual Task<UsBankAccount> ArchiveAsync(string id, UsBankAccountArchiveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}/archive", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a USBankAccount object.
        /// </summary>
        public virtual UsBankAccount Create(UsBankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts", options, requestOptions);
        }

        /// <summary>
        /// Create a USBankAccount object.
        /// </summary>
        public virtual Task<UsBankAccount> CreateAsync(UsBankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a USBankAccount object.
        /// </summary>
        public virtual UsBankAccount Get(string id, UsBankAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<UsBankAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a USBankAccount object.
        /// </summary>
        public virtual Task<UsBankAccount> GetAsync(string id, UsBankAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsBankAccount>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a USBankAccount object. This is limited to supplying a previously empty
        /// routing_number field.
        /// </summary>
        public virtual UsBankAccount Update(string id, UsBankAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a USBankAccount object. This is limited to supplying a previously empty
        /// routing_number field.
        /// </summary>
        public virtual Task<UsBankAccount> UpdateAsync(string id, UsBankAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
