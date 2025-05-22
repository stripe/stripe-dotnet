// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OffSessionPaymentService : Service
    {
        internal OffSessionPaymentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OffSessionPaymentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancel OSP.
        /// </summary>
        public virtual OffSessionPayment Cancel(string id, OffSessionPaymentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OffSessionPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/off_session_payments/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel OSP.
        /// </summary>
        public virtual Task<OffSessionPayment> CancelAsync(string id, OffSessionPaymentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OffSessionPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/off_session_payments/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create OSP.
        /// </summary>
        public virtual OffSessionPayment Create(OffSessionPaymentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OffSessionPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/off_session_payments", options, requestOptions);
        }

        /// <summary>
        /// Create OSP.
        /// </summary>
        public virtual Task<OffSessionPayment> CreateAsync(OffSessionPaymentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OffSessionPayment>(BaseAddress.Api, HttpMethod.Post, $"/v2/payments/off_session_payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve OSP by ID.
        /// </summary>
        public virtual OffSessionPayment Get(string id, OffSessionPaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OffSessionPayment>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/off_session_payments/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve OSP by ID.
        /// </summary>
        public virtual Task<OffSessionPayment> GetAsync(string id, OffSessionPaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OffSessionPayment>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/off_session_payments/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List OSPs matching filter.
        /// </summary>
        public virtual V2.StripeList<OffSessionPayment> List(OffSessionPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<OffSessionPayment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/off_session_payments", options, requestOptions);
        }

        /// <summary>
        /// List OSPs matching filter.
        /// </summary>
        public virtual Task<V2.StripeList<OffSessionPayment>> ListAsync(OffSessionPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<OffSessionPayment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/payments/off_session_payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List OSPs matching filter.
        /// </summary>
        public virtual IEnumerable<OffSessionPayment> ListAutoPaging(OffSessionPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<OffSessionPayment>($"/v2/payments/off_session_payments", options, requestOptions);
        }

        /// <summary>
        /// List OSPs matching filter.
        /// </summary>
        public virtual IAsyncEnumerable<OffSessionPayment> ListAutoPagingAsync(OffSessionPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<OffSessionPayment>($"/v2/payments/off_session_payments", options, requestOptions, cancellationToken);
        }
    }
}
