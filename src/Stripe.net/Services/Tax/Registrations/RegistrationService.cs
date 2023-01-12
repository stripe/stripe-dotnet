// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class RegistrationService : Service<Registration>,
        ICreatable<Registration, RegistrationCreateOptions>,
        IListable<Registration, RegistrationListOptions>,
        IUpdatable<Registration, RegistrationUpdateOptions>
    {
        public RegistrationService()
            : base(null)
        {
        }

        public RegistrationService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tax/registrations";

        public virtual Registration Create(RegistrationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Registration> CreateAsync(RegistrationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Registration> List(RegistrationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Registration>> ListAsync(RegistrationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Registration> ListAutoPaging(RegistrationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Registration> ListAutoPagingAsync(RegistrationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual Registration Update(string id, RegistrationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Registration> UpdateAsync(string id, RegistrationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
