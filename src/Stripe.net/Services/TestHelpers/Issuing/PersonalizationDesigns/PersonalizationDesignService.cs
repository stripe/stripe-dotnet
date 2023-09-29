// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class PersonalizationDesignService : Service<PersonalizationDesign>
    {
        public PersonalizationDesignService()
            : base(null)
        {
        }

        public PersonalizationDesignService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/issuing/personalization_designs";

        public virtual PersonalizationDesign Activate(string id, PersonalizationDesignActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/activate", options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> ActivateAsync(string id, PersonalizationDesignActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/activate", options, requestOptions, cancellationToken);
        }

        public virtual PersonalizationDesign Deactivate(string id, PersonalizationDesignDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/deactivate", options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> DeactivateAsync(string id, PersonalizationDesignDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/deactivate", options, requestOptions, cancellationToken);
        }

        public virtual PersonalizationDesign Reject(string id, PersonalizationDesignRejectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/reject", options, requestOptions);
        }

        public virtual Task<PersonalizationDesign> RejectAsync(string id, PersonalizationDesignRejectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/reject", options, requestOptions, cancellationToken);
        }
    }
}
