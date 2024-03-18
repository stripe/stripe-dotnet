// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class PersonalizationDesignService : Service<Stripe.Issuing.PersonalizationDesign>
    {
        public PersonalizationDesignService()
        {
        }

        public PersonalizationDesignService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/issuing/personalization_designs";

        /// <summary>
        /// <p>Updates the <c>status</c> of the specified testmode personalization design object to
        /// <c>active</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.PersonalizationDesign Activate(string id, PersonalizationDesignActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.PersonalizationDesign>(HttpMethod.Post, $"/v1/test_helpers/issuing/personalization_designs/{id}/activate", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the <c>status</c> of the specified testmode personalization design object to
        /// <c>active</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.PersonalizationDesign> ActivateAsync(string id, PersonalizationDesignActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.PersonalizationDesign>(HttpMethod.Post, $"/v1/test_helpers/issuing/personalization_designs/{id}/activate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the <c>status</c> of the specified testmode personalization design object to
        /// <c>inactive</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.PersonalizationDesign Deactivate(string id, PersonalizationDesignDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.PersonalizationDesign>(HttpMethod.Post, $"/v1/test_helpers/issuing/personalization_designs/{id}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the <c>status</c> of the specified testmode personalization design object to
        /// <c>inactive</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.PersonalizationDesign> DeactivateAsync(string id, PersonalizationDesignDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.PersonalizationDesign>(HttpMethod.Post, $"/v1/test_helpers/issuing/personalization_designs/{id}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the <c>status</c> of the specified testmode personalization design object to
        /// <c>rejected</c>.</p>.
        /// </summary>
        public virtual Stripe.Issuing.PersonalizationDesign Reject(string id, PersonalizationDesignRejectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Issuing.PersonalizationDesign>(HttpMethod.Post, $"/v1/test_helpers/issuing/personalization_designs/{id}/reject", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the <c>status</c> of the specified testmode personalization design object to
        /// <c>rejected</c>.</p>.
        /// </summary>
        public virtual Task<Stripe.Issuing.PersonalizationDesign> RejectAsync(string id, PersonalizationDesignRejectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Issuing.PersonalizationDesign>(HttpMethod.Post, $"/v1/test_helpers/issuing/personalization_designs/{id}/reject", options, requestOptions, cancellationToken);
        }
    }
}
