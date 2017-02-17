using System.Collections.Generic;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeOrderService : StripeBasicService<StripeOrder>
    {
        public StripeOrderService(string apiKey = null) : base(apiKey) { }

        public virtual StripeOrder Get(string orderId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.Orders}/{orderId}", requestOptions);
        }

        public virtual StripeOrder Create(StripeOrderCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Post(Urls.Orders, requestOptions, createOptions);
        }

        public virtual StripeOrder Update(string orderId, StripeOrderUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Orders}/{orderId}", requestOptions, updateOptions);
        }

        public virtual StripeOrder Pay(string orderId, StripeOrderPayOptions payOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Orders}/{orderId}/pay", requestOptions, payOptions);
        }

        public virtual StripeReturn Return(string orderId, StripeOrderReturnOptions returnOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeReturn>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(returnOptions, $"{Urls.Orders}/{orderId}/returns", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeOrder> List(StripeOrderListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList(Urls.Orders, requestOptions, listOptions);
        }
    }
}
