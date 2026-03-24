// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
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
        /// Creates a new account evaluation to trigger signal evaluations on an account or account
        /// data.
        /// </summary>
        public virtual AccountEvaluation Create(AccountEvaluationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_evaluations", options, requestOptions);
        }

        /// <summary>
        /// Creates a new account evaluation to trigger signal evaluations on an account or account
        /// data.
        /// </summary>
        public virtual Task<AccountEvaluation> CreateAsync(AccountEvaluationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountEvaluation>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/account_evaluations", options, requestOptions, cancellationToken);
        }
    }
}
