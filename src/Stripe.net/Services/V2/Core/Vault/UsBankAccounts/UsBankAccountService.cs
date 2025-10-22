// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using System.Collections.Generic;
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
        /// Confirm microdeposits amounts or descriptor code that you have received from the Send
        /// Microdeposits request. Once you correctly confirm this, this US Bank Account will be
        /// verified and eligible to transfer funds with.
        /// </summary>
        public virtual UsBankAccount ConfirmMicrodeposits(string id, UsBankAccountConfirmMicrodepositsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}/confirm_microdeposits", options, requestOptions);
        }

        /// <summary>
        /// Confirm microdeposits amounts or descriptor code that you have received from the Send
        /// Microdeposits request. Once you correctly confirm this, this US Bank Account will be
        /// verified and eligible to transfer funds with.
        /// </summary>
        public virtual Task<UsBankAccount> ConfirmMicrodepositsAsync(string id, UsBankAccountConfirmMicrodepositsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}/confirm_microdeposits", options, requestOptions, cancellationToken);
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
        /// List USBankAccount objects. Optionally filter by verification status.
        /// </summary>
        public virtual V2.StripeList<UsBankAccount> List(UsBankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<UsBankAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/us_bank_accounts", options, requestOptions);
        }

        /// <summary>
        /// List USBankAccount objects. Optionally filter by verification status.
        /// </summary>
        public virtual Task<V2.StripeList<UsBankAccount>> ListAsync(UsBankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<UsBankAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/vault/us_bank_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List USBankAccount objects. Optionally filter by verification status.
        /// </summary>
        public virtual IEnumerable<UsBankAccount> ListAutoPaging(UsBankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<UsBankAccount>($"/v2/core/vault/us_bank_accounts", options, requestOptions);
        }

        /// <summary>
        /// List USBankAccount objects. Optionally filter by verification status.
        /// </summary>
        public virtual IAsyncEnumerable<UsBankAccount> ListAutoPagingAsync(UsBankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<UsBankAccount>($"/v2/core/vault/us_bank_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Send microdeposits in order to verify your US Bank Account so it is eligible to transfer
        /// funds. This will start the verification process and you must Confirm Microdeposits to
        /// successfully verify your US Bank Account.
        /// </summary>
        public virtual UsBankAccount SendMicrodeposits(string id, UsBankAccountSendMicrodepositsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}/send_microdeposits", options, requestOptions);
        }

        /// <summary>
        /// Send microdeposits in order to verify your US Bank Account so it is eligible to transfer
        /// funds. This will start the verification process and you must Confirm Microdeposits to
        /// successfully verify your US Bank Account.
        /// </summary>
        public virtual Task<UsBankAccount> SendMicrodepositsAsync(string id, UsBankAccountSendMicrodepositsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/us_bank_accounts/{WebUtility.UrlEncode(id)}/send_microdeposits", options, requestOptions, cancellationToken);
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
