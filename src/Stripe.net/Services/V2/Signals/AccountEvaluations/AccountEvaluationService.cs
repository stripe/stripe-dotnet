// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountEvaluationService : Service
    {
        internal AccountEvaluationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountEvaluationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a new account evaluation to request signal evaluations on an account, customer,
        /// or inline account data.
        /// </summary>
        public virtual AccountEvaluation Create(AccountEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/account_evaluations", options, requestOptions);
        }

        /// <summary>
        /// Creates a new account evaluation to request signal evaluations on an account, customer,
        /// or inline account data.
        /// </summary>
        public virtual Task<AccountEvaluation> CreateAsync(AccountEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/account_evaluations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves an AccountEvaluation by its ID.
        /// </summary>
        public virtual AccountEvaluation Get(string id, AccountEvaluationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AccountEvaluation>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an AccountEvaluation by its ID.
        /// </summary>
        public virtual Task<AccountEvaluation> GetAsync(string id, AccountEvaluationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountEvaluation>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_evaluations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
