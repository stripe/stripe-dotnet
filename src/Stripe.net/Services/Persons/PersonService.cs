// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
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
        {
        }

        public PersonService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/accounts/{PARENT_ID}/persons";

        /// <summary>
        /// <p>Creates a new person.</p>.
        /// </summary>
        public virtual Person Create(string parentId, PersonCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Person>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/persons", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Creates a new person.</p>.
        /// </summary>
        public virtual Task<Person> CreateAsync(string parentId, PersonCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/persons", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes an existing person’s relationship to the account’s legal entity. Any person
        /// with a relationship for an account can be deleted through the API, except if the person
        /// is the <c>account_opener</c>. If your integration is using the <c>executive</c>
        /// parameter, you cannot delete the only verified <c>executive</c> on file.</p>.
        /// </summary>
        public virtual Person Delete(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Person>(BaseAddress.Api, HttpMethod.Delete, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Deletes an existing person’s relationship to the account’s legal entity. Any person
        /// with a relationship for an account can be deleted through the API, except if the person
        /// is the <c>account_opener</c>. If your integration is using the <c>executive</c>
        /// parameter, you cannot delete the only verified <c>executive</c> on file.</p>.
        /// </summary>
        public virtual Task<Person> DeleteAsync(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(BaseAddress.Api, HttpMethod.Delete, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an existing person.</p>.
        /// </summary>
        public virtual Person Get(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Person>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Retrieves an existing person.</p>.
        /// </summary>
        public virtual Task<Person> GetAsync(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of people associated with the account’s legal entity. The people are
        /// returned sorted by creation date, with the most recent people appearing first.</p>.
        /// </summary>
        public virtual StripeList<Person> List(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Person>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/persons", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Returns a list of people associated with the account’s legal entity. The people are
        /// returned sorted by creation date, with the most recent people appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Person>> ListAsync(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Person>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/persons", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of people associated with the account’s legal entity. The people are
        /// returned sorted by creation date, with the most recent people appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Person> ListAutoPaging(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Person>($"/v1/accounts/{parentId}/persons", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Returns a list of people associated with the account’s legal entity. The people are
        /// returned sorted by creation date, with the most recent people appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Person> ListAutoPagingAsync(string parentId, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Person>($"/v1/accounts/{parentId}/persons", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing person.</p>.
        /// </summary>
        public virtual Person Update(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Person>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Updates an existing person.</p>.
        /// </summary>
        public virtual Task<Person> UpdateAsync(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Person>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/persons/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
