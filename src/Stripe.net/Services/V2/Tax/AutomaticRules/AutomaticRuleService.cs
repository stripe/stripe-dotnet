// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AutomaticRuleService : Service
    {
        internal AutomaticRuleService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AutomaticRuleService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates an AutomaticRule object.
        /// </summary>
        public virtual AutomaticRule Create(AutomaticRuleCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AutomaticRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/automatic_rules", options, requestOptions);
        }

        /// <summary>
        /// Creates an AutomaticRule object.
        /// </summary>
        public virtual Task<AutomaticRule> CreateAsync(AutomaticRuleCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AutomaticRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/automatic_rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Deactivates an AutomaticRule object. Deactivated AutomaticRule objects are ignored in
        /// future tax calculations.
        /// </summary>
        public virtual AutomaticRule Deactivate(string id, AutomaticRuleDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AutomaticRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/automatic_rules/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// Deactivates an AutomaticRule object. Deactivated AutomaticRule objects are ignored in
        /// future tax calculations.
        /// </summary>
        public virtual Task<AutomaticRule> DeactivateAsync(string id, AutomaticRuleDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AutomaticRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/automatic_rules/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Finds an AutomaticRule object by BillableItem ID.
        /// </summary>
        public virtual AutomaticRule Find(AutomaticRuleFindOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AutomaticRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/automatic_rules/find", options, requestOptions);
        }

        /// <summary>
        /// Finds an AutomaticRule object by BillableItem ID.
        /// </summary>
        public virtual Task<AutomaticRule> FindAsync(AutomaticRuleFindOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AutomaticRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/automatic_rules/find", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves an AutomaticRule object by ID.
        /// </summary>
        public virtual AutomaticRule Get(string id, AutomaticRuleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AutomaticRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/automatic_rules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an AutomaticRule object by ID.
        /// </summary>
        public virtual Task<AutomaticRule> GetAsync(string id, AutomaticRuleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AutomaticRule>(BaseAddress.Api, HttpMethod.Get, $"/v2/tax/automatic_rules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the automatic Tax configuration for an AutomaticRule object.
        /// </summary>
        public virtual AutomaticRule Update(string id, AutomaticRuleUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AutomaticRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/automatic_rules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates the automatic Tax configuration for an AutomaticRule object.
        /// </summary>
        public virtual Task<AutomaticRule> UpdateAsync(string id, AutomaticRuleUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AutomaticRule>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/automatic_rules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
