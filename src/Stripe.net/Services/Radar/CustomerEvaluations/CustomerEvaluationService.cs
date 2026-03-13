// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerEvaluationService : Service,
        ICreatable<CustomerEvaluation, CustomerEvaluationCreateOptions>,
        IUpdatable<CustomerEvaluation, CustomerEvaluationUpdateOptions>
    {
        public CustomerEvaluationService()
        {
        }

        internal CustomerEvaluationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerEvaluationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new <c>CustomerEvaluation</c> object.</p>.
        /// </summary>
        public virtual CustomerEvaluation Create(CustomerEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/customer_evaluations", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>CustomerEvaluation</c> object.</p>.
        /// </summary>
        public virtual Task<CustomerEvaluation> CreateAsync(CustomerEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/customer_evaluations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Reports an event on a <c>CustomerEvaluation</c> object.</p>.
        /// </summary>
        public virtual CustomerEvaluation Update(string id, CustomerEvaluationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/customer_evaluations/{WebUtility.UrlEncode(id)}/report", options, requestOptions);
        }

        /// <summary>
        /// <p>Reports an event on a <c>CustomerEvaluation</c> object.</p>.
        /// </summary>
        public virtual Task<CustomerEvaluation> UpdateAsync(string id, CustomerEvaluationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/customer_evaluations/{WebUtility.UrlEncode(id)}/report", options, requestOptions, cancellationToken);
        }
    }
}
