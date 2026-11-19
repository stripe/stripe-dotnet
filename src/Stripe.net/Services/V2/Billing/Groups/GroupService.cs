// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class GroupService : Service
    {
        private V2.Billing.Groups.InvoiceService invoices;
        private V2.Billing.Groups.SpendModifierRuleService spendModifierRules;

        internal GroupService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal GroupService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.Groups.InvoiceService Invoices => this.invoices ??= new V2.Billing.Groups.InvoiceService(
            this.Requestor);

        public virtual V2.Billing.Groups.SpendModifierRuleService SpendModifierRules => this.spendModifierRules ??= new V2.Billing.Groups.SpendModifierRuleService(
            this.Requestor);

        /// <summary>
        /// Cancel a BillingGroup.
        /// </summary>
        public virtual Group Cancel(string id, GroupCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Group>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel a BillingGroup.
        /// </summary>
        public virtual Task<Group> CancelAsync(string id, GroupCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Group>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a BillingGroup.
        /// </summary>
        public virtual Group Create(GroupCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Group>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups", options, requestOptions);
        }

        /// <summary>
        /// Create a BillingGroup.
        /// </summary>
        public virtual Task<Group> CreateAsync(GroupCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Group>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a BillingGroup.
        /// </summary>
        public virtual Group Get(string id, GroupGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Group>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a BillingGroup.
        /// </summary>
        public virtual Task<Group> GetAsync(string id, GroupGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Group>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Billing Groups.
        /// </summary>
        public virtual V2.StripeList<Group> List(GroupListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Group>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/groups", options, requestOptions);
        }

        /// <summary>
        /// List Billing Groups.
        /// </summary>
        public virtual Task<V2.StripeList<Group>> ListAsync(GroupListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Group>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/groups", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Billing Groups.
        /// </summary>
        public virtual IEnumerable<Group> ListAutoPaging(GroupListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Group>($"/v2/billing/groups", options, requestOptions);
        }

        /// <summary>
        /// List Billing Groups.
        /// </summary>
        public virtual IAsyncEnumerable<Group> ListAutoPagingAsync(GroupListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Group>($"/v2/billing/groups", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a BillingGroup.
        /// </summary>
        public virtual Group Update(string id, GroupUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Group>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a BillingGroup.
        /// </summary>
        public virtual Task<Group> UpdateAsync(string id, GroupUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Group>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
