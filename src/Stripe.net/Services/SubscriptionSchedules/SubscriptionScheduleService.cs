// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionScheduleService : Service,
        ICreatable<SubscriptionSchedule, SubscriptionScheduleCreateOptions>,
        IListable<SubscriptionSchedule, SubscriptionScheduleListOptions>,
        IRetrievable<SubscriptionSchedule, SubscriptionScheduleGetOptions>,
        IUpdatable<SubscriptionSchedule, SubscriptionScheduleUpdateOptions>
    {
        public SubscriptionScheduleService()
        {
        }

        internal SubscriptionScheduleService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SubscriptionScheduleService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Amends an existing subscription schedule.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Amend(string id, SubscriptionScheduleAmendOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}/amend", options, requestOptions);
        }

        /// <summary>
        /// <p>Amends an existing subscription schedule.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> AmendAsync(string id, SubscriptionScheduleAmendOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}/amend", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Cancels a subscription schedule and its associated subscription immediately (if the
        /// subscription schedule has an active subscription). A subscription schedule can only be
        /// canceled if its status is <c>not_started</c> or <c>active</c>.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Cancel(string id, SubscriptionScheduleCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels a subscription schedule and its associated subscription immediately (if the
        /// subscription schedule has an active subscription). A subscription schedule can only be
        /// canceled if its status is <c>not_started</c> or <c>active</c>.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> CancelAsync(string id, SubscriptionScheduleCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a new subscription schedule object. Each customer can have up to 500 active
        /// or scheduled subscriptions.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Create(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new subscription schedule object. Each customer can have up to 500 active
        /// or scheduled subscriptions.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> CreateAsync(SubscriptionScheduleCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing subscription schedule. You only need to supply
        /// the unique subscription schedule identifier that was returned upon subscription schedule
        /// creation.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Get(string id, SubscriptionScheduleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing subscription schedule. You only need to supply
        /// the unique subscription schedule identifier that was returned upon subscription schedule
        /// creation.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> GetAsync(string id, SubscriptionScheduleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the list of your subscription schedules.</p>.
        /// </summary>
        public virtual StripeList<SubscriptionSchedule> List(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SubscriptionSchedule>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscription_schedules", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the list of your subscription schedules.</p>.
        /// </summary>
        public virtual Task<StripeList<SubscriptionSchedule>> ListAsync(SubscriptionScheduleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SubscriptionSchedule>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscription_schedules", options, requestOptions, cancellationToken);
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
            return this.Request<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}/release", options, requestOptions);
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
            return this.RequestAsync<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}/release", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes a SubscriptionSchedule cancel request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchCancel(string schedule, SubscriptionScheduleCancelOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", new Dictionary<string, string> { { "schedule", schedule } } },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(item, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// Serializes a SubscriptionSchedule create request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchCreate(SubscriptionScheduleCreateOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", null },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(item, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// Serializes a SubscriptionSchedule update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchUpdate(string schedule, SubscriptionScheduleUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", new Dictionary<string, string> { { "schedule", schedule } } },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(item, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// <p>Updates an existing subscription schedule.</p>.
        /// </summary>
        public virtual SubscriptionSchedule Update(string id, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing subscription schedule.</p>.
        /// </summary>
        public virtual Task<SubscriptionSchedule> UpdateAsync(string id, SubscriptionScheduleUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionSchedule>(BaseAddress.Api, HttpMethod.Post, $"/v1/subscription_schedules/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
