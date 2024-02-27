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

        public virtual Feature Create(FeatureCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Feature>(HttpMethod.Post, $"/v1/entitlements/features", options, requestOptions);
        }

        public virtual Task<Feature> CreateAsync(FeatureCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Feature>(HttpMethod.Post, $"/v1/entitlements/features", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Feature> List(FeatureListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Feature>>(HttpMethod.Get, $"/v1/entitlements/features", options, requestOptions);
        }

        public virtual Task<StripeList<Feature>> ListAsync(FeatureListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Feature>>(HttpMethod.Get, $"/v1/entitlements/features", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Feature> ListAutoPaging(FeatureListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Feature>($"/v1/entitlements/features", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Feature> ListAutoPagingAsync(FeatureListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Feature>($"/v1/entitlements/features", options, requestOptions, cancellationToken);
        }
    }
}
