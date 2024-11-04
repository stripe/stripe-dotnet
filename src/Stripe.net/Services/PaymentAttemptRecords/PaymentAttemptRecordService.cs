// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentAttemptRecordService : Service<PaymentAttemptRecord>,
        IListable<PaymentAttemptRecord, PaymentAttemptRecordListOptions>,
        IRetrievable<PaymentAttemptRecord, PaymentAttemptRecordGetOptions>
    {
        public PaymentAttemptRecordService()
        {
        }

        internal PaymentAttemptRecordService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentAttemptRecordService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a Payment Attempt Record with the given ID</p>.
        /// </summary>
        public virtual PaymentAttemptRecord Get(string id, PaymentAttemptRecordGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Payment Attempt Record with the given ID</p>.
        /// </summary>
        public virtual Task<PaymentAttemptRecord> GetAsync(string id, PaymentAttemptRecordGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all the Payment Attempt Records attached to the specified Payment Record.</p>.
        /// </summary>
        public virtual StripeList<PaymentAttemptRecord> List(PaymentAttemptRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentAttemptRecord>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_attempt_records", options, requestOptions);
        }

        /// <summary>
        /// <p>List all the Payment Attempt Records attached to the specified Payment Record.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentAttemptRecord>> ListAsync(PaymentAttemptRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentAttemptRecord>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_attempt_records", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all the Payment Attempt Records attached to the specified Payment Record.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentAttemptRecord> ListAutoPaging(PaymentAttemptRecordListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentAttemptRecord>($"/v1/payment_attempt_records", options, requestOptions);
        }

        /// <summary>
        /// <p>List all the Payment Attempt Records attached to the specified Payment Record.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentAttemptRecord> ListAutoPagingAsync(PaymentAttemptRecordListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentAttemptRecord>($"/v1/payment_attempt_records", options, requestOptions, cancellationToken);
        }
    }
}
