// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EvaluationOutcomeService : Service
    {
        internal EvaluationOutcomeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal EvaluationOutcomeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves an evaluation outcome by its ID.
        /// </summary>
        public virtual EvaluationOutcome Get(string id, EvaluationOutcomeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<EvaluationOutcome>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/evaluation_outcomes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an evaluation outcome by its ID.
        /// </summary>
        public virtual Task<EvaluationOutcome> GetAsync(string id, EvaluationOutcomeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<EvaluationOutcome>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/evaluation_outcomes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists all matching historical evaluation outcomes, newest first.
        /// </summary>
        public virtual V2.StripeList<EvaluationOutcome> List(EvaluationOutcomeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<EvaluationOutcome>>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/evaluation_outcomes", options, requestOptions);
        }

        /// <summary>
        /// Lists all matching historical evaluation outcomes, newest first.
        /// </summary>
        public virtual Task<V2.StripeList<EvaluationOutcome>> ListAsync(EvaluationOutcomeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<EvaluationOutcome>>(BaseAddress.Api, HttpMethod.Get, $"/v2/risk/evaluation_outcomes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists all matching historical evaluation outcomes, newest first.
        /// </summary>
        public virtual IEnumerable<EvaluationOutcome> ListAutoPaging(EvaluationOutcomeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<EvaluationOutcome>($"/v2/risk/evaluation_outcomes", options, requestOptions);
        }

        /// <summary>
        /// Lists all matching historical evaluation outcomes, newest first.
        /// </summary>
        public virtual IAsyncEnumerable<EvaluationOutcome> ListAutoPagingAsync(EvaluationOutcomeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<EvaluationOutcome>($"/v2/risk/evaluation_outcomes", options, requestOptions, cancellationToken);
        }
    }
}
