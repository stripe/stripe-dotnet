// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundPaymentService : Service<OutboundPayment>,
        ICreatable<OutboundPayment, OutboundPaymentCreateOptions>,
        IListable<OutboundPayment, OutboundPaymentListOptions>,
        IRetrievable<OutboundPayment, OutboundPaymentGetOptions>
    {
        public OutboundPaymentService()
        {
        }

        public OutboundPaymentService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/outbound_payments";

        /// <summary>
        /// <p>Cancel an OutboundPayment.</p>.
        /// </summary>
        public virtual OutboundPayment Cancel(string id, OutboundPaymentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPayment>(HttpMethod.Post, $"/v1/treasury/outbound_payments/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancel an OutboundPayment.</p>.
        /// </summary>
        public virtual Task<OutboundPayment> CancelAsync(string id, OutboundPaymentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPayment>(HttpMethod.Post, $"/v1/treasury/outbound_payments/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates an OutboundPayment.</p>.
        /// </summary>
        public virtual OutboundPayment Create(OutboundPaymentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPayment>(HttpMethod.Post, $"/v1/treasury/outbound_payments", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an OutboundPayment.</p>.
        /// </summary>
        public virtual Task<OutboundPayment> CreateAsync(OutboundPaymentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPayment>(HttpMethod.Post, $"/v1/treasury/outbound_payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing OutboundPayment by passing the unique
        /// OutboundPayment ID from either the OutboundPayment creation request or OutboundPayment
        /// list.</p>.
        /// </summary>
        public virtual OutboundPayment Get(string id, OutboundPaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundPayment>(HttpMethod.Get, $"/v1/treasury/outbound_payments/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing OutboundPayment by passing the unique
        /// OutboundPayment ID from either the OutboundPayment creation request or OutboundPayment
        /// list.</p>.
        /// </summary>
        public virtual Task<OutboundPayment> GetAsync(string id, OutboundPaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundPayment>(HttpMethod.Get, $"/v1/treasury/outbound_payments/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of OutboundPayments sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual StripeList<OutboundPayment> List(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<OutboundPayment>>(HttpMethod.Get, $"/v1/treasury/outbound_payments", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of OutboundPayments sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual Task<StripeList<OutboundPayment>> ListAsync(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<OutboundPayment>>(HttpMethod.Get, $"/v1/treasury/outbound_payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of OutboundPayments sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual IEnumerable<OutboundPayment> ListAutoPaging(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<OutboundPayment>($"/v1/treasury/outbound_payments", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of OutboundPayments sent from the specified FinancialAccount.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<OutboundPayment> ListAutoPagingAsync(OutboundPaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<OutboundPayment>($"/v1/treasury/outbound_payments", options, requestOptions, cancellationToken);
        }
    }
}
