// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RewardProgramService : Service
    {
        private V2.MoneyManagement.RewardPrograms.RuleService rules;

        internal RewardProgramService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RewardProgramService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.MoneyManagement.RewardPrograms.RuleService Rules => this.rules ??= new V2.MoneyManagement.RewardPrograms.RuleService(
            this.Requestor);

        /// <summary>
        /// Activates a RewardProgram, making it eligible for reward evaluation. Idempotent: calling
        /// this on a RewardProgram that is already active returns 200 with the current object
        /// unchanged.
        /// </summary>
        public virtual RewardProgram Activate(string id, RewardProgramActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/activate", options, requestOptions);
        }

        /// <summary>
        /// Activates a RewardProgram, making it eligible for reward evaluation. Idempotent: calling
        /// this on a RewardProgram that is already active returns 200 with the current object
        /// unchanged.
        /// </summary>
        public virtual Task<RewardProgram> ActivateAsync(string id, RewardProgramActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/activate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a new RewardProgram. RewardPrograms are inactive by default on creation; use
        /// ActivateRewardProgram to make them eligible for reward evaluation.
        /// </summary>
        public virtual RewardProgram Create(RewardProgramCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs", options, requestOptions);
        }

        /// <summary>
        /// Creates a new RewardProgram. RewardPrograms are inactive by default on creation; use
        /// ActivateRewardProgram to make them eligible for reward evaluation.
        /// </summary>
        public virtual Task<RewardProgram> CreateAsync(RewardProgramCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Deactivates a RewardProgram. Idempotent: calling this on a RewardProgram that is already
        /// inactive returns 200 with the current object unchanged.
        /// </summary>
        public virtual RewardProgram Deactivate(string id, RewardProgramDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// Deactivates a RewardProgram. Idempotent: calling this on a RewardProgram that is already
        /// inactive returns 200 with the current object unchanged.
        /// </summary>
        public virtual Task<RewardProgram> DeactivateAsync(string id, RewardProgramDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing RewardProgram.
        /// </summary>
        public virtual RewardProgram Get(string id, RewardProgramGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgram>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing RewardProgram.
        /// </summary>
        public virtual Task<RewardProgram> GetAsync(string id, RewardProgramGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgram>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of RewardPrograms.
        /// </summary>
        public virtual V2.StripeList<RewardProgram> List(RewardProgramListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<RewardProgram>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of RewardPrograms.
        /// </summary>
        public virtual Task<V2.StripeList<RewardProgram>> ListAsync(RewardProgramListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<RewardProgram>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of RewardPrograms.
        /// </summary>
        public virtual IEnumerable<RewardProgram> ListAutoPaging(RewardProgramListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RewardProgram>($"/v2/money_management/reward_programs", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of RewardPrograms.
        /// </summary>
        public virtual IAsyncEnumerable<RewardProgram> ListAutoPagingAsync(RewardProgramListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RewardProgram>($"/v2/money_management/reward_programs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the mutable fields of an existing RewardProgram. Use ActivateRewardProgram /
        /// DeactivateRewardProgram to change the RewardProgram's status.
        /// </summary>
        public virtual RewardProgram Update(string id, RewardProgramUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates the mutable fields of an existing RewardProgram. Use ActivateRewardProgram /
        /// DeactivateRewardProgram to change the RewardProgram's status.
        /// </summary>
        public virtual Task<RewardProgram> UpdateAsync(string id, RewardProgramUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RewardProgram>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
