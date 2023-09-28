// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
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

        public override string BasePath => "/v1/issuing/personalization_designs";

        public virtual PersonalizationDesign Create(PersonalizationDesignCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> CreateAsync(PersonalizationDesignCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PersonalizationDesign Get(string id, PersonalizationDesignGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> GetAsync(string id, PersonalizationDesignGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PersonalizationDesign> List(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<PersonalizationDesign>> ListAsync(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PersonalizationDesign> ListAutoPaging(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<PersonalizationDesign> ListAutoPagingAsync(PersonalizationDesignListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual PersonalizationDesign Update(string id, PersonalizationDesignUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> UpdateAsync(string id, PersonalizationDesignUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
