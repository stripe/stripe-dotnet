// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RecipientVerificationService : Service
    {
        internal RecipientVerificationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RecipientVerificationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Acknowledges an existing RecipientVerification. Only RecipientVerification awaiting
        /// acknowledgement can be acknowledged.
        /// </summary>
        public virtual RecipientVerification Acknowledge(string id, RecipientVerificationAcknowledgeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RecipientVerification>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/recipient_verifications/{WebUtility.UrlEncode(id)}/acknowledge", options, requestOptions);
        }

        /// <summary>
        /// Acknowledges an existing RecipientVerification. Only RecipientVerification awaiting
        /// acknowledgement can be acknowledged.
        /// </summary>
        public virtual Task<RecipientVerification> AcknowledgeAsync(string id, RecipientVerificationAcknowledgeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RecipientVerification>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/recipient_verifications/{WebUtility.UrlEncode(id)}/acknowledge", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a RecipientVerification to verify the recipient you intend to send funds to.
        /// </summary>
        public virtual RecipientVerification Create(RecipientVerificationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RecipientVerification>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/recipient_verifications", options, requestOptions);
        }

        /// <summary>
        /// Creates a RecipientVerification to verify the recipient you intend to send funds to.
        /// </summary>
        public virtual Task<RecipientVerification> CreateAsync(RecipientVerificationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RecipientVerification>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/recipient_verifications", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing RecipientVerification by passing the unique
        /// RecipientVerification ID.
        /// </summary>
        public virtual RecipientVerification Get(string id, RecipientVerificationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RecipientVerification>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/recipient_verifications/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing RecipientVerification by passing the unique
        /// RecipientVerification ID.
        /// </summary>
        public virtual Task<RecipientVerification> GetAsync(string id, RecipientVerificationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RecipientVerification>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/recipient_verifications/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
