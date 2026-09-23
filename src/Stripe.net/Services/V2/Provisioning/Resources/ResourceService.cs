// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ResourceService : Service
    {
        internal ResourceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ResourceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a new provider resource.
        /// </summary>
        public virtual Resource Create(ResourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources", options, requestOptions);
        }

        /// <summary>
        /// Creates a new provider resource.
        /// </summary>
        public virtual Task<Resource> CreateAsync(ResourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a provider resource.
        /// </summary>
        public virtual Resource Get(string id, ResourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a provider resource.
        /// </summary>
        public virtual Task<Resource> GetAsync(string id, ResourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Get, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Links an existing provider resource to a project or account.
        /// </summary>
        public virtual Resource Link(ResourceLinkOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/link", options, requestOptions);
        }

        /// <summary>
        /// Links an existing provider resource to a project or account.
        /// </summary>
        public virtual Task<Resource> LinkAsync(ResourceLinkOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/link", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Removes a resource.
        /// </summary>
        public virtual Resource Remove(string id, ResourceRemoveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/remove", options, requestOptions);
        }

        /// <summary>
        /// Removes a resource.
        /// </summary>
        public virtual Task<Resource> RemoveAsync(string id, ResourceRemoveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/remove", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Rotates a resource's credentials.
        /// </summary>
        public virtual Resource RotateCredentials(string id, ResourceRotateCredentialsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/rotate_credentials", options, requestOptions);
        }

        /// <summary>
        /// Rotates a resource's credentials.
        /// </summary>
        public virtual Task<Resource> RotateCredentialsAsync(string id, ResourceRotateCredentialsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/rotate_credentials", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Submits additional information requested by the provider for a resource.
        /// </summary>
        public virtual Resource SubmitInformation(string id, ResourceSubmitInformationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/submit_information", options, requestOptions);
        }

        /// <summary>
        /// Submits additional information requested by the provider for a resource.
        /// </summary>
        public virtual Task<Resource> SubmitInformationAsync(string id, ResourceSubmitInformationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/submit_information", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Unlinks a resource without removing it from the provider.
        /// </summary>
        public virtual Resource Unlink(string id, ResourceUnlinkOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/unlink", options, requestOptions);
        }

        /// <summary>
        /// Unlinks a resource without removing it from the provider.
        /// </summary>
        public virtual Task<Resource> UnlinkAsync(string id, ResourceUnlinkOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}/unlink", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates a resource's configuration or service.
        /// </summary>
        public virtual Resource Update(string id, ResourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates a resource's configuration or service.
        /// </summary>
        public virtual Task<Resource> UpdateAsync(string id, ResourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Resource>(BaseAddress.Api, HttpMethod.Post, $"/v2/provisioning/resources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
