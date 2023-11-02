// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
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
            return this.Request<Person>(HttpMethod.Post, $"/v1/accounts/{parentId}/persons", options, requestOptions);
        }

        public virtual Task<Person> CreateAsync(string parentId, PersonCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(HttpMethod.Post, $"/v1/accounts/{parentId}/persons", options, requestOptions, cancellationToken);
        }

        public virtual Person Delete(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Person>(HttpMethod.Delete, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions);
        }

        public virtual Task<Person> DeleteAsync(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(HttpMethod.Delete, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Person Get(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Person>(HttpMethod.Get, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions);
        }

        public virtual Task<Person> GetAsync(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(HttpMethod.Get, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Person> List(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Person>>(HttpMethod.Get, $"/v1/accounts/{parentId}/persons", options, requestOptions);
        }

        public virtual Task<StripeList<Person>> ListAsync(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Person>>(HttpMethod.Get, $"/v1/accounts/{parentId}/persons", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Person> ListAutoPaging(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Person>($"/v1/accounts/{parentId}/persons", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Person> ListAutoPagingAsync(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Person>($"/v1/accounts/{parentId}/persons", options, requestOptions, cancellationToken);
        }

        public virtual Person Update(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Person>(HttpMethod.Post, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions);
        }

        public virtual Task<Person> UpdateAsync(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(HttpMethod.Post, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, cancellationToken);
        }
    }
}
