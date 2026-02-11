// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Cadences
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SpendModifierRuleService : Service
    {
        internal SpendModifierRuleService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SpendModifierRuleService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a Spend Modifier associated with a Billing Cadence.
        /// </summary>
        public virtual V2.Billing.CadenceSpendModifier Get(string parentId, string id, SpendModifierRuleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.CadenceSpendModifier>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences/{WebUtility.UrlEncode(parentId)}/spend_modifier_rules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Spend Modifier associated with a Billing Cadence.
        /// </summary>
        public virtual Task<V2.Billing.CadenceSpendModifier> GetAsync(string parentId, string id, SpendModifierRuleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.CadenceSpendModifier>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences/{WebUtility.UrlEncode(parentId)}/spend_modifier_rules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Spend Modifiers associated with a Billing Cadence.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.CadenceSpendModifier> List(string id, SpendModifierRuleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.CadenceSpendModifier>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}/spend_modifier_rules", options, requestOptions);
        }

        /// <summary>
        /// List all Spend Modifiers associated with a Billing Cadence.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.CadenceSpendModifier>> ListAsync(string id, SpendModifierRuleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.CadenceSpendModifier>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/cadences/{WebUtility.UrlEncode(id)}/spend_modifier_rules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Spend Modifiers associated with a Billing Cadence.
        /// </summary>
        public virtual IEnumerable<V2.Billing.CadenceSpendModifier> ListAutoPaging(string id, SpendModifierRuleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.CadenceSpendModifier>($"/v2/billing/cadences/{WebUtility.UrlEncode(id)}/spend_modifier_rules", options, requestOptions);
        }

        /// <summary>
        /// List all Spend Modifiers associated with a Billing Cadence.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.CadenceSpendModifier> ListAutoPagingAsync(string id, SpendModifierRuleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.CadenceSpendModifier>($"/v2/billing/cadences/{WebUtility.UrlEncode(id)}/spend_modifier_rules", options, requestOptions, cancellationToken);
        }
    }
}
