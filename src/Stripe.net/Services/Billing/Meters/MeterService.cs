// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterService : Service<Meter>,
        ICreatable<Meter, MeterCreateOptions>,
        IListable<Meter, MeterListOptions>,
        IRetrievable<Meter, MeterGetOptions>,
        IUpdatable<Meter, MeterUpdateOptions>
    {
        private MeterEventSummaryService eventSummaries;

        public MeterService()
        {
        }

        internal MeterService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public MeterService(IStripeClient client)
            : base(client)
        {
        }

        public virtual MeterEventSummaryService EventSummaries => this.eventSummaries ??= new MeterEventSummaryService(
            this.Requestor);

        /// <summary>
        /// <p>Creates a billing meter.</p>.
        /// </summary>
        public virtual Meter Create(MeterCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a billing meter.</p>.
        /// </summary>
        public virtual Task<Meter> CreateAsync(MeterCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When a meter is deactivated, no more meter events will be accepted for this meter.
        /// You can’t attach a deactivated meter to a price.</p>.
        /// </summary>
        public virtual Meter Deactivate(string id, MeterDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// <p>When a meter is deactivated, no more meter events will be accepted for this meter.
        /// You can’t attach a deactivated meter to a price.</p>.
        /// </summary>
        public virtual Task<Meter> DeactivateAsync(string id, MeterDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a billing meter given an ID.</p>.
        /// </summary>
        public virtual Meter Get(string id, MeterGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a billing meter given an ID.</p>.
        /// </summary>
        public virtual Task<Meter> GetAsync(string id, MeterGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of billing meters.</p>.
        /// </summary>
        public virtual StripeList<Meter> List(MeterListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Meter>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/meters", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of billing meters.</p>.
        /// </summary>
        public virtual Task<StripeList<Meter>> ListAsync(MeterListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Meter>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/meters", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of billing meters.</p>.
        /// </summary>
        public virtual IEnumerable<Meter> ListAutoPaging(MeterListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Meter>($"/v1/billing/meters", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of billing meters.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Meter> ListAutoPagingAsync(MeterListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Meter>($"/v1/billing/meters", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When a meter is reactivated, events for this meter can be accepted and you can attach
        /// the meter to a price.</p>.
        /// </summary>
        public virtual Meter Reactivate(string id, MeterReactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}/reactivate", options, requestOptions);
        }

        /// <summary>
        /// <p>When a meter is reactivated, events for this meter can be accepted and you can attach
        /// the meter to a price.</p>.
        /// </summary>
        public virtual Task<Meter> ReactivateAsync(string id, MeterReactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}/reactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a billing meter.</p>.
        /// </summary>
        public virtual Meter Update(string id, MeterUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a billing meter.</p>.
        /// </summary>
        public virtual Task<Meter> UpdateAsync(string id, MeterUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/meters/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
