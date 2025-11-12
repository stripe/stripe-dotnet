// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProgramService : Service,
        ICreatable<Program, ProgramCreateOptions>,
        IListable<Program, ProgramListOptions>,
        IRetrievable<Program, ProgramGetOptions>,
        IUpdatable<Program, ProgramUpdateOptions>
    {
        public ProgramService()
        {
        }

        internal ProgramService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ProgramService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create a <c>Program</c> object.</p>.
        /// </summary>
        public virtual Program Create(ProgramCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Program>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/programs", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a <c>Program</c> object.</p>.
        /// </summary>
        public virtual Task<Program> CreateAsync(ProgramCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Program>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/programs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the program specified by the given id.</p>.
        /// </summary>
        public virtual Program Get(string id, ProgramGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Program>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/programs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the program specified by the given id.</p>.
        /// </summary>
        public virtual Task<Program> GetAsync(string id, ProgramGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Program>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/programs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all of the programs the given Issuing user has access to.</p>.
        /// </summary>
        public virtual StripeList<Program> List(ProgramListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Program>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/programs", options, requestOptions);
        }

        /// <summary>
        /// <p>List all of the programs the given Issuing user has access to.</p>.
        /// </summary>
        public virtual Task<StripeList<Program>> ListAsync(ProgramListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Program>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/programs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List all of the programs the given Issuing user has access to.</p>.
        /// </summary>
        public virtual IEnumerable<Program> ListAutoPaging(ProgramListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Program>($"/v1/issuing/programs", options, requestOptions);
        }

        /// <summary>
        /// <p>List all of the programs the given Issuing user has access to.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Program> ListAutoPagingAsync(ProgramListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Program>($"/v1/issuing/programs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a <c>Program</c> object.</p>.
        /// </summary>
        public virtual Program Update(string id, ProgramUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Program>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/programs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a <c>Program</c> object.</p>.
        /// </summary>
        public virtual Task<Program> UpdateAsync(string id, ProgramUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Program>(BaseAddress.Api, HttpMethod.Post, $"/v1/issuing/programs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
