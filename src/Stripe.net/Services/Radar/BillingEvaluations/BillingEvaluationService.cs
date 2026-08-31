// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BillingEvaluationService : Service,
        ICreatable<BillingEvaluation, BillingEvaluationCreateOptions>
    {
        public BillingEvaluationService()
        {
        }

        internal BillingEvaluationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public BillingEvaluationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Request Stripe Radar’s assessment of the non-payment abuse risk of an upcoming
        /// charge, before the payment is attempted.</p>.
        /// </summary>
        public virtual BillingEvaluation Create(BillingEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BillingEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/billing_evaluations", options, requestOptions);
        }

        /// <summary>
        /// <p>Request Stripe Radar’s assessment of the non-payment abuse risk of an upcoming
        /// charge, before the payment is attempted.</p>.
        /// </summary>
        public virtual Task<BillingEvaluation> CreateAsync(BillingEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BillingEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/billing_evaluations", options, requestOptions, cancellationToken);
        }
    }
}
