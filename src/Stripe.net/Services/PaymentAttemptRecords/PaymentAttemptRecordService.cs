// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentAttemptRecordService : Service,
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

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was authenticated.</p>.
        /// </summary>
        public virtual PaymentAttemptRecord ReportAuthenticated(string id, PaymentAttemptRecordReportAuthenticatedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_authenticated", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was authenticated.</p>.
        /// </summary>
        public virtual Task<PaymentAttemptRecord> ReportAuthenticatedAsync(string id, PaymentAttemptRecordReportAuthenticatedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_authenticated", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was canceled.</p>.
        /// </summary>
        public virtual PaymentAttemptRecord ReportCanceled(string id, PaymentAttemptRecordReportCanceledOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_canceled", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was canceled.</p>.
        /// </summary>
        public virtual Task<PaymentAttemptRecord> ReportCanceledAsync(string id, PaymentAttemptRecordReportCanceledOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_canceled", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record failed.</p>.
        /// </summary>
        public virtual PaymentAttemptRecord ReportFailed(string id, PaymentAttemptRecordReportFailedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_failed", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record failed.</p>.
        /// </summary>
        public virtual Task<PaymentAttemptRecord> ReportFailedAsync(string id, PaymentAttemptRecordReportFailedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_failed", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was guaranteed.</p>.
        /// </summary>
        public virtual PaymentAttemptRecord ReportGuaranteed(string id, PaymentAttemptRecordReportGuaranteedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_guaranteed", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was guaranteed.</p>.
        /// </summary>
        public virtual Task<PaymentAttemptRecord> ReportGuaranteedAsync(string id, PaymentAttemptRecordReportGuaranteedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_guaranteed", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report informational updates on the specified Payment Attempt Record.</p>.
        /// </summary>
        public virtual PaymentAttemptRecord ReportInformational(string id, PaymentAttemptRecordReportInformationalOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_informational", options, requestOptions);
        }

        /// <summary>
        /// <p>Report informational updates on the specified Payment Attempt Record.</p>.
        /// </summary>
        public virtual Task<PaymentAttemptRecord> ReportInformationalAsync(string id, PaymentAttemptRecordReportInformationalOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_informational", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was refunded.</p>.
        /// </summary>
        public virtual PaymentAttemptRecord ReportRefund(string id, PaymentAttemptRecordReportRefundOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_refund", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the specified Payment Attempt Record was refunded.</p>.
        /// </summary>
        public virtual Task<PaymentAttemptRecord> ReportRefundAsync(string id, PaymentAttemptRecordReportRefundOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentAttemptRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_attempt_records/{WebUtility.UrlEncode(id)}/report_refund", options, requestOptions, cancellationToken);
        }
    }
}
