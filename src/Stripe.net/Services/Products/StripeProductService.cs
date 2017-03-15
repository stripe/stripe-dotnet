using System.Collections.Generic;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeProductService : StripeBasicService<StripeProduct>
    {
        public StripeProductService(string apiKey = null) : base(apiKey) { }

        public virtual StripeProduct Get(string productId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.Products}/{productId}", requestOptions);
        }

        public virtual StripeProduct Create(StripeProductCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Post(Urls.Products, requestOptions, createOptions);
        }

        public virtual StripeProduct Update(string productId, StripeProductUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Products}/{productId}", requestOptions, updateOptions);
        }

        public virtual IEnumerable<StripeProduct> List(StripeProductListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList(Urls.Products, requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string productId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.Products}/{productId}", requestOptions);
        }
    }
}
