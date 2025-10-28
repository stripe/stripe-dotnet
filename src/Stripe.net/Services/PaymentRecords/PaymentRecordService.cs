// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentRecordService : Service,
        IRetrievable<PaymentRecord, PaymentRecordGetOptions>
    {
        public PaymentRecordService()
        {
        }

        internal PaymentRecordService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentRecordService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a Payment Record with the given ID</p>.
        /// </summary>
        public virtual PaymentRecord Get(string id, PaymentRecordGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_records/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Payment Record with the given ID</p>.
        /// </summary>
        public virtual Task<PaymentRecord> GetAsync(string id, PaymentRecordGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_records/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report a new Payment Record. You may report a Payment Record as it is initialized and
        /// later report updates through the other report_* methods, or report Payment Records in a
        /// terminal state directly, through this method.</p>.
        /// </summary>
        public virtual PaymentRecord ReportPayment(PaymentRecordReportPaymentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/report_payment", options, requestOptions);
        }

        /// <summary>
        /// <p>Report a new Payment Record. You may report a Payment Record as it is initialized and
        /// later report updates through the other report_* methods, or report Payment Records in a
        /// terminal state directly, through this method.</p>.
        /// </summary>
        public virtual Task<PaymentRecord> ReportPaymentAsync(PaymentRecordReportPaymentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/report_payment", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report a new payment attempt on the specified Payment Record. A new payment attempt
        /// can only be specified if all other payment attempts are canceled or failed.</p>.
        /// </summary>
        public virtual PaymentRecord ReportPaymentAttempt(string id, PaymentRecordReportPaymentAttemptOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt", options, requestOptions);
        }

        /// <summary>
        /// <p>Report a new payment attempt on the specified Payment Record. A new payment attempt
        /// can only be specified if all other payment attempts are canceled or failed.</p>.
        /// </summary>
        public virtual Task<PaymentRecord> ReportPaymentAttemptAsync(string id, PaymentRecordReportPaymentAttemptOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record was
        /// canceled.</p>.
        /// </summary>
        public virtual PaymentRecord ReportPaymentAttemptCanceled(string id, PaymentRecordReportPaymentAttemptCanceledOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_canceled", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record was
        /// canceled.</p>.
        /// </summary>
        public virtual Task<PaymentRecord> ReportPaymentAttemptCanceledAsync(string id, PaymentRecordReportPaymentAttemptCanceledOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_canceled", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record failed or
        /// errored.</p>.
        /// </summary>
        public virtual PaymentRecord ReportPaymentAttemptFailed(string id, PaymentRecordReportPaymentAttemptFailedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_failed", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record failed or
        /// errored.</p>.
        /// </summary>
        public virtual Task<PaymentRecord> ReportPaymentAttemptFailedAsync(string id, PaymentRecordReportPaymentAttemptFailedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_failed", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record was
        /// guaranteed.</p>.
        /// </summary>
        public virtual PaymentRecord ReportPaymentAttemptGuaranteed(string id, PaymentRecordReportPaymentAttemptGuaranteedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_guaranteed", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record was
        /// guaranteed.</p>.
        /// </summary>
        public virtual Task<PaymentRecord> ReportPaymentAttemptGuaranteedAsync(string id, PaymentRecordReportPaymentAttemptGuaranteedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_guaranteed", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report informational updates on the specified Payment Record.</p>.
        /// </summary>
        public virtual PaymentRecord ReportPaymentAttemptInformational(string id, PaymentRecordReportPaymentAttemptInformationalOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_informational", options, requestOptions);
        }

        /// <summary>
        /// <p>Report informational updates on the specified Payment Record.</p>.
        /// </summary>
        public virtual Task<PaymentRecord> ReportPaymentAttemptInformationalAsync(string id, PaymentRecordReportPaymentAttemptInformationalOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_payment_attempt_informational", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record was
        /// refunded.</p>.
        /// </summary>
        public virtual PaymentRecord ReportRefund(string id, PaymentRecordReportRefundOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_refund", options, requestOptions);
        }

        /// <summary>
        /// <p>Report that the most recent payment attempt on the specified Payment Record was
        /// refunded.</p>.
        /// </summary>
        public virtual Task<PaymentRecord> ReportRefundAsync(string id, PaymentRecordReportRefundOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentRecord>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_records/{WebUtility.UrlEncode(id)}/report_refund", options, requestOptions, cancellationToken);
        }
    }
}
