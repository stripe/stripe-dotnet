// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class UsageRecordService : ServiceNested<UsageRecord>,
        INestedCreatable<UsageRecord, UsageRecordCreateOptions>
    {
        public UsageRecordService()
        {
        }

        public UsageRecordService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/subscription_items/{PARENT_ID}/usage_records";

        /// <summary>
        /// <p>Creates a usage record for a specified subscription item and date, and fills it with
        /// a quantity.</p>.
        ///
        /// <p>Usage records provide <c>quantity</c> information that Stripe uses to track how much
        /// a customer is using your service. With usage information and the pricing model set up by
        /// the <a href="https://stripe.com/docs/billing/subscriptions/metered-billing">metered
        /// billing</a> plan, Stripe helps you send accurate invoices to your customers.</p>.
        ///
        /// <p>The default calculation for usage is to add up all the <c>quantity</c> values of the
        /// usage records within a billing period. You can change this default behavior with the
        /// billing plan’s <c>aggregate_usage</c> <a
        /// href="https://stripe.com/docs/api/plans/create#create_plan-aggregate_usage">parameter</a>.
        /// When there is more than one usage record with the same timestamp, Stripe adds the
        /// <c>quantity</c> values together. In most cases, this is the desired resolution, however,
        /// you can change this behavior with the <c>action</c> parameter.</p>.
        ///
        /// <p>The default pricing model for metered billing is <a
        /// href="https://stripe.com/docs/api/plans/object#plan_object-billing_scheme">per-unit
        /// pricing</a>. For finer granularity, you can configure metered billing to have a <a
        /// href="https://stripe.com/docs/billing/subscriptions/tiers">tiered pricing</a> model.</p>.
        /// </summary>
        public virtual UsageRecord Create(string parentId, UsageRecordCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<UsageRecord>(HttpMethod.Post, $"/v1/subscription_items/{parentId}/usage_records", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a usage record for a specified subscription item and date, and fills it with
        /// a quantity.</p>.
        ///
        /// <p>Usage records provide <c>quantity</c> information that Stripe uses to track how much
        /// a customer is using your service. With usage information and the pricing model set up by
        /// the <a href="https://stripe.com/docs/billing/subscriptions/metered-billing">metered
        /// billing</a> plan, Stripe helps you send accurate invoices to your customers.</p>.
        ///
        /// <p>The default calculation for usage is to add up all the <c>quantity</c> values of the
        /// usage records within a billing period. You can change this default behavior with the
        /// billing plan’s <c>aggregate_usage</c> <a
        /// href="https://stripe.com/docs/api/plans/create#create_plan-aggregate_usage">parameter</a>.
        /// When there is more than one usage record with the same timestamp, Stripe adds the
        /// <c>quantity</c> values together. In most cases, this is the desired resolution, however,
        /// you can change this behavior with the <c>action</c> parameter.</p>.
        ///
        /// <p>The default pricing model for metered billing is <a
        /// href="https://stripe.com/docs/api/plans/object#plan_object-billing_scheme">per-unit
        /// pricing</a>. For finer granularity, you can configure metered billing to have a <a
        /// href="https://stripe.com/docs/billing/subscriptions/tiers">tiered pricing</a> model.</p>.
        /// </summary>
        public virtual Task<UsageRecord> CreateAsync(string parentId, UsageRecordCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<UsageRecord>(HttpMethod.Post, $"/v1/subscription_items/{parentId}/usage_records", options, requestOptions, cancellationToken);
        }
    }
}
