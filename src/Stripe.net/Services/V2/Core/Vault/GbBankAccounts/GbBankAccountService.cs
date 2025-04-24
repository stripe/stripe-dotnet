// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
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
        /// Confirm that you have received the result of the Confirmation of Payee request, and that
        /// you are okay with proceeding to pay out to this bank account despite the account not
        /// matching, partially matching, or the service being unavailable. Once you confirm this,
        /// you will be able to send OutboundPayments, but this may lead to funds being sent to the
        /// wrong account, which we might not be able to recover.
        /// </summary>
        public virtual GbBankAccount AcknowledgeConfirmationOfPayee(string id, GbBankAccountAcknowledgeConfirmationOfPayeeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}/acknowledge_confirmation_of_payee", options, requestOptions);
        }

        /// <summary>
        /// Confirm that you have received the result of the Confirmation of Payee request, and that
        /// you are okay with proceeding to pay out to this bank account despite the account not
        /// matching, partially matching, or the service being unavailable. Once you confirm this,
        /// you will be able to send OutboundPayments, but this may lead to funds being sent to the
        /// wrong account, which we might not be able to recover.
        /// </summary>
        public virtual Task<GbBankAccount> AcknowledgeConfirmationOfPayeeAsync(string id, GbBankAccountAcknowledgeConfirmationOfPayeeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}/acknowledge_confirmation_of_payee", options, requestOptions, cancellationToken);
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
        /// Initiate Confirmation of Payee (CoP) in order to verify that the owner of a UK bank
        /// account matches who you expect. This must be done on all UK bank accounts before sending
        /// domestic OutboundPayments. If the result is a partial match or a non match, explicit
        /// acknowledgement using AcknowledgeConfirmationOfPayee is required before sending funds.
        /// </summary>
        public virtual GbBankAccount InitiateConfirmationOfPayee(string id, GbBankAccountInitiateConfirmationOfPayeeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}/initiate_confirmation_of_payee", options, requestOptions);
        }

        /// <summary>
        /// Initiate Confirmation of Payee (CoP) in order to verify that the owner of a UK bank
        /// account matches who you expect. This must be done on all UK bank accounts before sending
        /// domestic OutboundPayments. If the result is a partial match or a non match, explicit
        /// acknowledgement using AcknowledgeConfirmationOfPayee is required before sending funds.
        /// </summary>
        public virtual Task<GbBankAccount> InitiateConfirmationOfPayeeAsync(string id, GbBankAccountInitiateConfirmationOfPayeeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<GbBankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/vault/gb_bank_accounts/{WebUtility.UrlEncode(id)}/initiate_confirmation_of_payee", options, requestOptions, cancellationToken);
        }
    }
}
