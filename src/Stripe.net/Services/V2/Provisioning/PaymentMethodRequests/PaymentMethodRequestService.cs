// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodRequestService : Service
    {
        internal PaymentMethodRequestService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PaymentMethodRequestService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a request for a customer to authorize a new payment method.
        /// </summary>
        public virtual PaymentMethodRequest Create(PaymentMethodRequestCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/payment_method_requests", options, requestOptions);
        }

        /// <summary>
        /// Creates a request for a customer to authorize a new payment method.
        /// </summary>
        public virtual Task<PaymentMethodRequest> CreateAsync(PaymentMethodRequestCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/payment_method_requests", options, requestOptions, cancellationToken);
        }
    }
}
