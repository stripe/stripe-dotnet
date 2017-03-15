using System.Collections.Generic;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSkuService : StripeBasicService<StripeSku>
    {
        public StripeSkuService(string apiKey = null) : base(apiKey) { }

        public virtual StripeSku Get(string skuId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.Skus}/{skuId}", requestOptions);
        }

        public virtual StripeSku Create(StripeSkuCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Post(Urls.Skus, requestOptions, createOptions);
        }

        public virtual StripeSku Update(string skuId, StripeSkuUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Skus}/{skuId}", requestOptions, updateOptions);
        }

        public virtual IEnumerable<StripeSku> List(StripeSkuListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList(Urls.Skus, requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string skuId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.Skus}/{skuId}", requestOptions);
        }
    }
}
