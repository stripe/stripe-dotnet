// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterService : Service<Meter>,
        ICreatable<Meter, MeterCreateOptions>,
        IListable<Meter, MeterListOptions>,
        IRetrievable<Meter, MeterGetOptions>,
        IUpdatable<Meter, MeterUpdateOptions>
    {
        public MeterService()
            : base(null)
        {
        }

        public MeterService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/meters";

        public virtual Meter Create(MeterCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(HttpMethod.Post, $"/v1/billing/meters", options, requestOptions);
        }

        public virtual Task<Meter> CreateAsync(MeterCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(HttpMethod.Post, $"/v1/billing/meters", options, requestOptions, cancellationToken);
        }

        public virtual Meter Deactivate(string id, MeterDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(HttpMethod.Post, $"/v1/billing/meters/{id}/deactivate", options, requestOptions);
        }

        public virtual Task<Meter> DeactivateAsync(string id, MeterDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(HttpMethod.Post, $"/v1/billing/meters/{id}/deactivate", options, requestOptions, cancellationToken);
        }

        public virtual Meter Get(string id, MeterGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(HttpMethod.Get, $"/v1/billing/meters/{id}", options, requestOptions);
        }

        public virtual Task<Meter> GetAsync(string id, MeterGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(HttpMethod.Get, $"/v1/billing/meters/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Meter> List(MeterListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Meter>>(HttpMethod.Get, $"/v1/billing/meters", options, requestOptions);
        }

        public virtual Task<StripeList<Meter>> ListAsync(MeterListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Meter>>(HttpMethod.Get, $"/v1/billing/meters", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Meter> ListAutoPaging(MeterListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Meter>($"/v1/billing/meters", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Meter> ListAutoPagingAsync(MeterListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Meter>($"/v1/billing/meters", options, requestOptions, cancellationToken);
        }

        public virtual Meter Reactivate(string id, MeterReactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(HttpMethod.Post, $"/v1/billing/meters/{id}/reactivate", options, requestOptions);
        }

        public virtual Task<Meter> ReactivateAsync(string id, MeterReactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(HttpMethod.Post, $"/v1/billing/meters/{id}/reactivate", options, requestOptions, cancellationToken);
        }

        public virtual Meter Update(string id, MeterUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Meter>(HttpMethod.Post, $"/v1/billing/meters/{id}", options, requestOptions);
        }

        public virtual Task<Meter> UpdateAsync(string id, MeterUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Meter>(HttpMethod.Post, $"/v1/billing/meters/{id}", options, requestOptions, cancellationToken);
        }
    }
}
