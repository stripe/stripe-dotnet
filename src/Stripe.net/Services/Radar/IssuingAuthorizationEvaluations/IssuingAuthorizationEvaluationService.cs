// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class IssuingAuthorizationEvaluationService : Service,
        ICreatable<IssuingAuthorizationEvaluation, IssuingAuthorizationEvaluationCreateOptions>
    {
        public IssuingAuthorizationEvaluationService()
        {
        }

        internal IssuingAuthorizationEvaluationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public IssuingAuthorizationEvaluationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Request a fraud risk assessment from Stripe for an Issuing card authorization.</p>.
        /// </summary>
        public virtual IssuingAuthorizationEvaluation Create(IssuingAuthorizationEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IssuingAuthorizationEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/issuing_authorization_evaluations", options, requestOptions);
        }

        /// <summary>
        /// <p>Request a fraud risk assessment from Stripe for an Issuing card authorization.</p>.
        /// </summary>
        public virtual Task<IssuingAuthorizationEvaluation> CreateAsync(IssuingAuthorizationEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IssuingAuthorizationEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/issuing_authorization_evaluations", options, requestOptions, cancellationToken);
        }
    }
}
