// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FeedbackOptionService : Service,
        ICreatable<FeedbackOption, FeedbackOptionCreateOptions>,
        IListable<FeedbackOption, FeedbackOptionListOptions>,
        IRetrievable<FeedbackOption, FeedbackOptionGetOptions>,
        IUpdatable<FeedbackOption, FeedbackOptionUpdateOptions>
    {
        public FeedbackOptionService()
        {
        }

        internal FeedbackOptionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FeedbackOptionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new feedback option.</p>.
        /// </summary>
        public virtual FeedbackOption Create(FeedbackOptionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FeedbackOption>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/feedback_options", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new feedback option.</p>.
        /// </summary>
        public virtual Task<FeedbackOption> CreateAsync(FeedbackOptionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FeedbackOption>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/feedback_options", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deactivates a feedback option. Deactivated feedback options cannot be used in portal
        /// configurations.</p>.
        /// </summary>
        public virtual FeedbackOption Deactivate(string id, FeedbackOptionDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FeedbackOption>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/feedback_options/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// <p>Deactivates a feedback option. Deactivated feedback options cannot be used in portal
        /// configurations.</p>.
        /// </summary>
        public virtual Task<FeedbackOption> DeactivateAsync(string id, FeedbackOptionDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FeedbackOption>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/feedback_options/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a feedback option object given an ID.</p>.
        /// </summary>
        public virtual FeedbackOption Get(string id, FeedbackOptionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FeedbackOption>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/feedback_options/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a feedback option object given an ID.</p>.
        /// </summary>
        public virtual Task<FeedbackOption> GetAsync(string id, FeedbackOptionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FeedbackOption>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/feedback_options/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your feedback options.</p>.
        /// </summary>
        public virtual StripeList<FeedbackOption> List(FeedbackOptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FeedbackOption>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/feedback_options", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your feedback options.</p>.
        /// </summary>
        public virtual Task<StripeList<FeedbackOption>> ListAsync(FeedbackOptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FeedbackOption>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/feedback_options", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your feedback options.</p>.
        /// </summary>
        public virtual IEnumerable<FeedbackOption> ListAutoPaging(FeedbackOptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FeedbackOption>($"/v1/billing/feedback_options", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your feedback options.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<FeedbackOption> ListAutoPagingAsync(FeedbackOptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FeedbackOption>($"/v1/billing/feedback_options", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the description of an existing feedback option.</p>.
        /// </summary>
        public virtual FeedbackOption Update(string id, FeedbackOptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FeedbackOption>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/feedback_options/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the description of an existing feedback option.</p>.
        /// </summary>
        public virtual Task<FeedbackOption> UpdateAsync(string id, FeedbackOptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FeedbackOption>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/feedback_options/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
