// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PersonalizationDesignService : Service<PersonalizationDesign>,
        ICreatable<PersonalizationDesign, PersonalizationDesignCreateOptions>,
        IListable<PersonalizationDesign, PersonalizationDesignListOptions>,
        IRetrievable<PersonalizationDesign, PersonalizationDesignGetOptions>,
        IUpdatable<PersonalizationDesign, PersonalizationDesignUpdateOptions>
    {
        public PersonalizationDesignService()
            : base(null)
        {
        }

        public PersonalizationDesignService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/personalization_designs";

        public virtual PersonalizationDesign Create(PersonalizationDesignCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PersonalizationDesign>(HttpMethod.Post, $"/v1/issuing/personalization_designs", options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> CreateAsync(PersonalizationDesignCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PersonalizationDesign>(HttpMethod.Post, $"/v1/issuing/personalization_designs", options, requestOptions, cancellationToken);
        }

        public virtual PersonalizationDesign Get(string id, PersonalizationDesignGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PersonalizationDesign>(HttpMethod.Get, $"/v1/issuing/personalization_designs/{id}", options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> GetAsync(string id, PersonalizationDesignGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PersonalizationDesign>(HttpMethod.Get, $"/v1/issuing/personalization_designs/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PersonalizationDesign> List(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PersonalizationDesign>>(HttpMethod.Get, $"/v1/issuing/personalization_designs", options, requestOptions);
        }

        public virtual Task<StripeList<PersonalizationDesign>> ListAsync(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PersonalizationDesign>>(HttpMethod.Get, $"/v1/issuing/personalization_designs", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PersonalizationDesign> ListAutoPaging(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PersonalizationDesign>($"/v1/issuing/personalization_designs", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PersonalizationDesign> ListAutoPagingAsync(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PersonalizationDesign>($"/v1/issuing/personalization_designs", options, requestOptions, cancellationToken);
        }

        public virtual PersonalizationDesign Update(string id, PersonalizationDesignUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PersonalizationDesign>(HttpMethod.Post, $"/v1/issuing/personalization_designs/{id}", options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> UpdateAsync(string id, PersonalizationDesignUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PersonalizationDesign>(HttpMethod.Post, $"/v1/issuing/personalization_designs/{id}", options, requestOptions, cancellationToken);
        }
    }
}
