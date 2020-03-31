namespace Stripe
{
    using System;
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

        public virtual Person Create(string accountId, PersonCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(accountId, options, requestOptions);
        }

        public virtual Task<Person> CreateAsync(string accountId, PersonCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual Person Delete(string accountId, string personId, PersonDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(accountId, personId, options, requestOptions);
        }

        public virtual Task<Person> DeleteAsync(string accountId, string personId, PersonDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteNestedEntityAsync(accountId, personId, options, requestOptions, cancellationToken);
        }

        public virtual Person Get(string accountId, string personId, PersonGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(accountId, personId, options, requestOptions);
        }

        public virtual Task<Person> GetAsync(string accountId, string personId, PersonGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(accountId, personId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Person> List(string accountId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(accountId, options, requestOptions);
        }

        public virtual Task<StripeList<Person>> ListAsync(string accountId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Person> ListAutoPaging(string accountId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(accountId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Person> ListAutoPagingAsync(string accountId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(accountId, options, requestOptions, cancellationToken);
        }
#endif

        public virtual Person Update(string accountId,  string personId, PersonUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(accountId, personId, options, requestOptions);
        }

        public virtual Task<Person> UpdateAsync(string accountId,  string personId, PersonUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(accountId, personId, options, requestOptions, cancellationToken);
        }
    }
}
