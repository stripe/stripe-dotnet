// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplicationFeeService : Service<ApplicationFee>,
        IListable<ApplicationFee, ApplicationFeeListOptions>,
        IRetrievable<ApplicationFee, ApplicationFeeGetOptions>
    {
        public ApplicationFeeService()
            : base(null)
        {
        }

        public ApplicationFeeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/application_fees";

        public virtual ApplicationFee Get(string id, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApplicationFee>(HttpMethod.Get, $"/v1/application_fees/{id}", options, requestOptions);
        }

        public virtual Task<ApplicationFee> GetAsync(string id, ApplicationFeeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplicationFee>(HttpMethod.Get, $"/v1/application_fees/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ApplicationFee> List(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ApplicationFee>>(HttpMethod.Get, $"/v1/application_fees", options, requestOptions);
        }

        public virtual Task<StripeList<ApplicationFee>> ListAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ApplicationFee>>(HttpMethod.Get, $"/v1/application_fees", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ApplicationFee> ListAutoPaging(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ApplicationFee>($"/v1/application_fees", options, requestOptions);
        }

        public virtual IAsyncEnumerable<ApplicationFee> ListAutoPagingAsync(ApplicationFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ApplicationFee>($"/v1/application_fees", options, requestOptions, cancellationToken);
        }
    }
}
