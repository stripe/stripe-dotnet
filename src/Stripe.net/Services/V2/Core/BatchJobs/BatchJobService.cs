// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BatchJobService : Service
    {
        internal BatchJobService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal BatchJobService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a new batch job.
        /// </summary>
        public virtual BatchJob Create(BatchJobCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BatchJob>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/batch_jobs", options, requestOptions);
        }

        /// <summary>
        /// Creates a new batch job.
        /// </summary>
        public virtual Task<BatchJob> CreateAsync(BatchJobCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BatchJob>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/batch_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes a Customer update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeV1CustomerUpdate(string customer, CustomerUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = requestOptions?.StripeVersion ?? StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", new Dictionary<string, string> { { "customer", customer } } },
                { "params", options?.ToMap() },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return System.Text.Json.JsonSerializer.Serialize(item);
        }

        /// <summary>
        /// Serializes a SubscriptionSchedule create request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeV1SubscriptionScheduleCreate(SubscriptionScheduleCreateOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = requestOptions?.StripeVersion ?? StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", null },
                { "params", options?.ToMap() },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return System.Text.Json.JsonSerializer.Serialize(item);
        }

        /// <summary>
        /// Serializes a Subscription update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeV1SubscriptionUpdate(string subscriptionExposedId, SubscriptionUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            var itemId = Guid.NewGuid().ToString();
            var stripeVersion = requestOptions?.StripeVersion ?? StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var item = new Dictionary<string, object>
            {
                { "id", itemId },
                { "path_params", new Dictionary<string, string> { { "subscription_exposed_id", subscriptionExposedId } } },
                { "params", options?.ToMap() },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                item["context"] = stripeContext;
            }

            return System.Text.Json.JsonSerializer.Serialize(item);
        }
    }
}
