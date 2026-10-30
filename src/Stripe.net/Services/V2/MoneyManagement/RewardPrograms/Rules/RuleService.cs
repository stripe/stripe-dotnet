// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.RewardPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RuleService : Service
    {
        internal RuleService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RuleService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Activates a RewardProgramRule. At most one RewardProgramRule may be active per
        /// RewardProgram at a time. Idempotent: calling this on a RewardProgramRule that is already
        /// active returns 200 with the current object unchanged.
        /// </summary>
        public virtual V2.MoneyManagement.RewardProgramRule Activate(string parentId, string id, RuleActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}/activate", options, requestOptions);
        }

        /// <summary>
        /// Activates a RewardProgramRule. At most one RewardProgramRule may be active per
        /// RewardProgram at a time. Idempotent: calling this on a RewardProgramRule that is already
        /// active returns 200 with the current object unchanged.
        /// </summary>
        public virtual Task<V2.MoneyManagement.RewardProgramRule> ActivateAsync(string parentId, string id, RuleActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}/activate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a new RewardProgramRule under the given RewardProgram. RewardProgramRules are
        /// inactive by default on creation; use ActivateRewardProgramRule to make them eligible for
        /// reward evaluation.
        /// </summary>
        public virtual V2.MoneyManagement.RewardProgramRule Create(string id, RuleCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/rules", options, requestOptions);
        }

        /// <summary>
        /// Creates a new RewardProgramRule under the given RewardProgram. RewardProgramRules are
        /// inactive by default on creation; use ActivateRewardProgramRule to make them eligible for
        /// reward evaluation.
        /// </summary>
        public virtual Task<V2.MoneyManagement.RewardProgramRule> CreateAsync(string id, RuleCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Deactivates a RewardProgramRule. Idempotent: calling this on a RewardProgramRule that is
        /// already inactive returns 200 with the current object unchanged.
        /// </summary>
        public virtual V2.MoneyManagement.RewardProgramRule Deactivate(string parentId, string id, RuleDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// Deactivates a RewardProgramRule. Idempotent: calling this on a RewardProgramRule that is
        /// already inactive returns 200 with the current object unchanged.
        /// </summary>
        public virtual Task<V2.MoneyManagement.RewardProgramRule> DeactivateAsync(string parentId, string id, RuleDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing RewardProgramRule.
        /// </summary>
        public virtual V2.MoneyManagement.RewardProgramRule Get(string parentId, string id, RuleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing RewardProgramRule.
        /// </summary>
        public virtual Task<V2.MoneyManagement.RewardProgramRule> GetAsync(string parentId, string id, RuleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of RewardProgramRules for a RewardProgram.
        /// </summary>
        public virtual V2.StripeList<V2.MoneyManagement.RewardProgramRule> List(string id, RuleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.MoneyManagement.RewardProgramRule>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/rules", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of RewardProgramRules for a RewardProgram.
        /// </summary>
        public virtual Task<V2.StripeList<V2.MoneyManagement.RewardProgramRule>> ListAsync(string id, RuleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.MoneyManagement.RewardProgramRule>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of RewardProgramRules for a RewardProgram.
        /// </summary>
        public virtual IEnumerable<V2.MoneyManagement.RewardProgramRule> ListAutoPaging(string id, RuleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.MoneyManagement.RewardProgramRule>($"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/rules", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of RewardProgramRules for a RewardProgram.
        /// </summary>
        public virtual IAsyncEnumerable<V2.MoneyManagement.RewardProgramRule> ListAutoPagingAsync(string id, RuleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.MoneyManagement.RewardProgramRule>($"/v2/money_management/reward_programs/{WebUtility.UrlEncode(id)}/rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the mutable fields of an existing RewardProgramRule. Use
        /// ActivateRewardProgramRule / DeactivateRewardProgramRule to change the
        /// RewardProgramRule's status.
        /// </summary>
        public virtual V2.MoneyManagement.RewardProgramRule Update(string parentId, string id, RuleUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates the mutable fields of an existing RewardProgramRule. Use
        /// ActivateRewardProgramRule / DeactivateRewardProgramRule to change the
        /// RewardProgramRule's status.
        /// </summary>
        public virtual Task<V2.MoneyManagement.RewardProgramRule> UpdateAsync(string parentId, string id, RuleUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.RewardProgramRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/reward_programs/{WebUtility.UrlEncode(parentId)}/rules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
