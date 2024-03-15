// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FeatureService : Service<Feature>,
        ICreatable<Feature, FeatureCreateOptions>,
        IListable<Feature, FeatureListOptions>
    {
        public FeatureService()
            : base(null)
        {
        }

        public FeatureService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/entitlements/features";

        /// <summary>
        /// <p>Creates a feature</p>.
        /// </summary>
        public virtual Feature Create(FeatureCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Feature>(HttpMethod.Post, $"/v1/entitlements/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a feature</p>.
        /// </summary>
        public virtual Task<Feature> CreateAsync(FeatureCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Feature>(HttpMethod.Post, $"/v1/entitlements/features", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of features</p>.
        /// </summary>
        public virtual StripeList<Feature> List(FeatureListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Feature>>(HttpMethod.Get, $"/v1/entitlements/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of features</p>.
        /// </summary>
        public virtual Task<StripeList<Feature>> ListAsync(FeatureListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Feature>>(HttpMethod.Get, $"/v1/entitlements/features", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of features</p>.
        /// </summary>
        public virtual IEnumerable<Feature> ListAutoPaging(FeatureListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Feature>($"/v1/entitlements/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of features</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Feature> ListAutoPagingAsync(FeatureListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Feature>($"/v1/entitlements/features", options, requestOptions, cancellationToken);
        }
    }
}
