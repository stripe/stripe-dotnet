// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PhysicalBundleService : Service<PhysicalBundle>,
        IListable<PhysicalBundle, PhysicalBundleListOptions>,
        IRetrievable<PhysicalBundle, PhysicalBundleGetOptions>
    {
        public PhysicalBundleService()
        {
        }

        public PhysicalBundleService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/physical_bundles";

        /// <summary>
        /// <p>Retrieves a physical bundle object.</p>.
        /// </summary>
        public virtual PhysicalBundle Get(string id, PhysicalBundleGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PhysicalBundle>(HttpMethod.Get, $"/v1/issuing/physical_bundles/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a physical bundle object.</p>.
        /// </summary>
        public virtual Task<PhysicalBundle> GetAsync(string id, PhysicalBundleGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PhysicalBundle>(HttpMethod.Get, $"/v1/issuing/physical_bundles/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of physical bundle objects. The objects are sorted in descending order
        /// by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual StripeList<PhysicalBundle> List(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PhysicalBundle>>(HttpMethod.Get, $"/v1/issuing/physical_bundles", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of physical bundle objects. The objects are sorted in descending order
        /// by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<PhysicalBundle>> ListAsync(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PhysicalBundle>>(HttpMethod.Get, $"/v1/issuing/physical_bundles", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of physical bundle objects. The objects are sorted in descending order
        /// by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<PhysicalBundle> ListAutoPaging(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PhysicalBundle>($"/v1/issuing/physical_bundles", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of physical bundle objects. The objects are sorted in descending order
        /// by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PhysicalBundle> ListAutoPagingAsync(PhysicalBundleListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PhysicalBundle>($"/v1/issuing/physical_bundles", options, requestOptions, cancellationToken);
        }
    }
}
