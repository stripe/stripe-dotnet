namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class PersonService : ServiceNested<Person>,
        INestedCreatable<Person, PersonCreateOptions>,
        INestedDeletable<Person, PersonDeleteOptions>,
        INestedListable<Person, PersonListOptions>,
        INestedRetrievable<Person, PersonGetOptions>,
        INestedUpdatable<Person, PersonUpdateOptions>
    {
        public PersonService()
            : base(null)
        {
        }

        public PersonService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts/{PARENT_ID}/persons";

        public virtual Person Create(string parentId, PersonCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<Person> CreateAsync(string parentId, PersonCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual Person Delete(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<Person> DeleteAsync(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual Person Get(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<Person> GetAsync(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Person> List(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<Person>> ListAsync(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Person> ListAutoPaging(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Person> ListAutoPagingAsync(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
#endif

        public virtual Person Update(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<Person> UpdateAsync(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }
    }
}
