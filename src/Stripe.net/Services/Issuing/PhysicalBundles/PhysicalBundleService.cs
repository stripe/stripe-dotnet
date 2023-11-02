// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PhysicalBundleService : Service<PhysicalBundle>,
        IListable<PhysicalBundle, PhysicalBundleListOptions>,
        IRetrievable<PhysicalBundle, PhysicalBundleGetOptions>
    {
        public PhysicalBundleService()
            : base(null)
        {
        }

        public PhysicalBundleService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/physical_bundles";

        public virtual PhysicalBundle Get(string id, PhysicalBundleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PhysicalBundle>(HttpMethod.Get, $"/v1/issuing/physical_bundles/{id}", options, requestOptions);
        }

        public virtual Task<PhysicalBundle> GetAsync(string id, PhysicalBundleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PhysicalBundle>(HttpMethod.Get, $"/v1/issuing/physical_bundles/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PhysicalBundle> List(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PhysicalBundle>>(HttpMethod.Get, $"/v1/issuing/physical_bundles", options, requestOptions);
        }

        public virtual Task<StripeList<PhysicalBundle>> ListAsync(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PhysicalBundle>>(HttpMethod.Get, $"/v1/issuing/physical_bundles", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PhysicalBundle> ListAutoPaging(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PhysicalBundle>($"/v1/issuing/physical_bundles", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PhysicalBundle> ListAutoPagingAsync(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PhysicalBundle>($"/v1/issuing/physical_bundles", options, requestOptions, cancellationToken);
        }
    }
}
