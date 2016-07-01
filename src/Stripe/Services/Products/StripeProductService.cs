
using System.Collections.Generic;

namespace Stripe
{
    public class StripeProductService : StripeService
    {
        public StripeProductService(string apiKey = null) : base(apiKey) { }

        public virtual StripeProduct Get(string productId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeProduct>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Products}/{productId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeProduct Create(StripeProductCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeProduct>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Products, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeProduct Update(string productId, StripeProductUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeProduct>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Products}/{productId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeProduct> List(StripeProductListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeProduct>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Products, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual void Delete(string productId, StripeRequestOptions requestOptions = null)
        {
            Requestor.Delete(this.ApplyAllParameters(null, $"{Urls.Products}/{productId}", false),
                SetupRequestOptions(requestOptions));
        }
    }
}
