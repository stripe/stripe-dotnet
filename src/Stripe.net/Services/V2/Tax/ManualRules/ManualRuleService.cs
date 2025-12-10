// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ManualRuleService : Service
    {
        internal ManualRuleService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ManualRuleService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a ManualRule object.
        /// </summary>
        public virtual ManualRule Create(ManualRuleCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ManualRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/manual_rules", options, requestOptions);
        }

        /// <summary>
        /// Creates a ManualRule object.
        /// </summary>
        public virtual Task<ManualRule> CreateAsync(ManualRuleCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ManualRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/manual_rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Deactivates a ManualRule object.
        /// </summary>
        public virtual ManualRule Deactivate(string id, ManualRuleDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ManualRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/manual_rules/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// Deactivates a ManualRule object.
        /// </summary>
        public virtual Task<ManualRule> DeactivateAsync(string id, ManualRuleDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ManualRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/manual_rules/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a ManualRule object by ID.
        /// </summary>
        public virtual ManualRule Get(string id, ManualRuleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ManualRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/manual_rules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a ManualRule object by ID.
        /// </summary>
        public virtual Task<ManualRule> GetAsync(string id, ManualRuleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ManualRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/manual_rules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all ManualRule objects.
        /// </summary>
        public virtual V2.StripeList<ManualRule> List(ManualRuleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ManualRule>>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/manual_rules", options, requestOptions);
        }

        /// <summary>
        /// List all ManualRule objects.
        /// </summary>
        public virtual Task<V2.StripeList<ManualRule>> ListAsync(ManualRuleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ManualRule>>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/manual_rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all ManualRule objects.
        /// </summary>
        public virtual IEnumerable<ManualRule> ListAutoPaging(ManualRuleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ManualRule>($"/v2/tax/manual_rules", options, requestOptions);
        }

        /// <summary>
        /// List all ManualRule objects.
        /// </summary>
        public virtual IAsyncEnumerable<ManualRule> ListAutoPagingAsync(ManualRuleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ManualRule>($"/v2/tax/manual_rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the Tax configuration for a ManualRule object.
        /// </summary>
        public virtual ManualRule Update(string id, ManualRuleUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ManualRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/manual_rules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates the Tax configuration for a ManualRule object.
        /// </summary>
        public virtual Task<ManualRule> UpdateAsync(string id, ManualRuleUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ManualRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/manual_rules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
