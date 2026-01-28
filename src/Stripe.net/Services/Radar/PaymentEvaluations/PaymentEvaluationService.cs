// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentEvaluationService : Service,
        ICreatable<PaymentEvaluation, PaymentEvaluationCreateOptions>
    {
        public PaymentEvaluationService()
        {
        }

        internal PaymentEvaluationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentEvaluationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Request a Radar API fraud risk score from Stripe for a payment before sending it for
        /// external processor authorization.</p>.
        /// </summary>
        public virtual PaymentEvaluation Create(PaymentEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/payment_evaluations", options, requestOptions);
        }

        /// <summary>
        /// <p>Request a Radar API fraud risk score from Stripe for a payment before sending it for
        /// external processor authorization.</p>.
        /// </summary>
        public virtual Task<PaymentEvaluation> CreateAsync(PaymentEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/payment_evaluations", options, requestOptions, cancellationToken);
        }
    }
}
