// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionScheduleService : Service<SubscriptionSchedule>,
        ICreatable<SubscriptionSchedule, SubscriptionScheduleCreateOptions>,
        IListable<SubscriptionSchedule, SubscriptionScheduleListOptions>,
        IRetrievable<SubscriptionSchedule, SubscriptionScheduleGetOptions>,
        IUpdatable<SubscriptionSchedule, SubscriptionScheduleUpdateOptions>
    {
        public SubscriptionScheduleService()
        {
        }

        public SubscriptionScheduleService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/subscription_schedules";

        /// <summary>
        /// <p>Cancels a subscription schedule and its associated subscription immediately (if the
        /// subscription schedule has an active subscription). A subscription schedule can only be
        /// canceled if its status is <c>not_started</c> or <c>active</c>.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Cancel(string id, SubscriptionScheduleCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels a subscription schedule and its associated subscription immediately (if the
        /// subscription schedule has an active subscription). A subscription schedule can only be
        /// canceled if its status is <c>not_started</c> or <c>active</c>.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> CancelAsync(string id, SubscriptionScheduleCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a new subscription schedule object. Each customer can have up to 500 active
        /// or scheduled subscriptions.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Create(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new subscription schedule object. Each customer can have up to 500 active
        /// or scheduled subscriptions.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> CreateAsync(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing subscription schedule. You only need to supply
        /// the unique subscription schedule identifier that was returned upon subscription schedule
        /// creation.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Get(string id, SubscriptionScheduleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(HttpMethod.Get, $"/v1/subscription_schedules/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing subscription schedule. You only need to supply
        /// the unique subscription schedule identifier that was returned upon subscription schedule
        /// creation.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> GetAsync(string id, SubscriptionScheduleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(HttpMethod.Get, $"/v1/subscription_schedules/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the list of your subscription schedules.</p>.
        /// </summary>
        public virtual StripeList<SubscriptionSchedule> List(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SubscriptionSchedule>>(HttpMethod.Get, $"/v1/subscription_schedules", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the list of your subscription schedules.</p>.
        /// </summary>
        public virtual Task<StripeList<SubscriptionSchedule>> ListAsync(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SubscriptionSchedule>>(HttpMethod.Get, $"/v1/subscription_schedules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the list of your subscription schedules.</p>.
        /// </summary>
        public virtual IEnumerable<SubscriptionSchedule> ListAutoPaging(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SubscriptionSchedule>($"/v1/subscription_schedules", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the list of your subscription schedules.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<SubscriptionSchedule> ListAutoPagingAsync(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SubscriptionSchedule>($"/v1/subscription_schedules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Releases the subscription schedule immediately, which will stop scheduling of its
        /// phases, but leave any existing subscription in place. A schedule can only be released if
        /// its status is <c>not_started</c> or <c>active</c>. If the subscription schedule is
        /// currently associated with a subscription, releasing it will remove its
        /// <c>subscription</c> property and set the subscription’s ID to the
        /// <c>released_subscription</c> property.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Release(string id, SubscriptionScheduleReleaseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules/{id}/release", options, requestOptions);
        }

        /// <summary>
        /// <p>Releases the subscription schedule immediately, which will stop scheduling of its
        /// phases, but leave any existing subscription in place. A schedule can only be released if
        /// its status is <c>not_started</c> or <c>active</c>. If the subscription schedule is
        /// currently associated with a subscription, releasing it will remove its
        /// <c>subscription</c> property and set the subscription’s ID to the
        /// <c>released_subscription</c> property.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> ReleaseAsync(string id, SubscriptionScheduleReleaseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules/{id}/release", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing subscription schedule.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Update(string id, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing subscription schedule.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> UpdateAsync(string id, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(HttpMethod.Post, $"/v1/subscription_schedules/{id}", options, requestOptions, cancellationToken);
        }
    }
}
