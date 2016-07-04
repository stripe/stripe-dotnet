
using System.Collections.Generic;

namespace Stripe
{
    public class StripeSkuService : StripeService
    {
        public StripeSkuService(string apiKey = null) : base(apiKey) { }

        public virtual StripeSku Get(string skuId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSku>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Skus}/{skuId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSku Create(StripeSkuCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSku>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Skus, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeSku Update(string skuId, StripeSkuUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSku>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Skus}/{skuId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeSku> List(StripeSkuListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeSku>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Skus, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual void Delete(string skuId, StripeRequestOptions requestOptions = null)
        {
            Requestor.Delete(this.ApplyAllParameters(null, $"{Urls.Skus}/{skuId}", false),
                SetupRequestOptions(requestOptions));
        }
    }
}
