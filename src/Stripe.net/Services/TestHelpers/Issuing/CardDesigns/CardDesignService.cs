// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Issuing;

    public class CardDesignService : Service<CardDesign>
    {
        public CardDesignService()
            : base(null)
        {
        }

        public CardDesignService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/issuing/card_designs";

        public virtual CardDesign ActivateTestmode(string id, CardDesignActivateTestmodeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/status/activate", options, requestOptions);
        }

        public virtual Task<CardDesign> ActivateTestmodeAsync(string id, CardDesignActivateTestmodeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/status/activate", options, requestOptions, cancellationToken);
        }

        public virtual CardDesign DeactivateTestmode(string id, CardDesignDeactivateTestmodeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/status/deactivate", options, requestOptions);
        }

        public virtual Task<CardDesign> DeactivateTestmodeAsync(string id, CardDesignDeactivateTestmodeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/status/deactivate", options, requestOptions, cancellationToken);
        }
    }
}
