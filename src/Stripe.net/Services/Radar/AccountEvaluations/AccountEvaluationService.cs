// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountEvaluationService : Service,
        ICreatable<AccountEvaluation, AccountEvaluationCreateOptions>,
        IRetrievable<AccountEvaluation, AccountEvaluationGetOptions>,
        IUpdatable<AccountEvaluation, AccountEvaluationUpdateOptions>
    {
        public AccountEvaluationService()
        {
        }

        internal AccountEvaluationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountEvaluationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new <c>AccountEvaluation</c> object.</p>.
        /// </summary>
        public virtual AccountEvaluation Create(AccountEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/account_evaluations", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>AccountEvaluation</c> object.</p>.
        /// </summary>
        public virtual Task<AccountEvaluation> CreateAsync(AccountEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/account_evaluations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an <c>AccountEvaluation</c> object.</p>.
        /// </summary>
        public virtual AccountEvaluation Get(string id, AccountEvaluationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AccountEvaluation>(BaseAddress.Api, HttpMethod.Get, $"/v1/radar/account_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an <c>AccountEvaluation</c> object.</p>.
        /// </summary>
        public virtual Task<AccountEvaluation> GetAsync(string id, AccountEvaluationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountEvaluation>(BaseAddress.Api, HttpMethod.Get, $"/v1/radar/account_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Reports an event on an <c>AccountEvaluation</c> object.</p>.
        /// </summary>
        public virtual AccountEvaluation Update(string id, AccountEvaluationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/account_evaluations/{WebUtility.UrlEncode(id)}/report_event", options, requestOptions);
        }

        /// <summary>
        /// <p>Reports an event on an <c>AccountEvaluation</c> object.</p>.
        /// </summary>
        public virtual Task<AccountEvaluation> UpdateAsync(string id, AccountEvaluationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v1/radar/account_evaluations/{WebUtility.UrlEncode(id)}/report_event", options, requestOptions, cancellationToken);
        }
    }
}
