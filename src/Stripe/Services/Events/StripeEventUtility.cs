using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stripe
{
    public static class StripeEventUtility
    {
        public static StripeEvent ParseEvent(string json)
        {
            return Mapper<StripeEvent>.MapFromJson(json);
        }

#if NET40
        public static T ParseEventDataItem<T>(dynamic dataItem)
#else
        public static T ParseEventDataItem<T>(object dataItem)
#endif
        {
            return JsonConvert.DeserializeObject<T>((dataItem as JObject).ToString());
        }
    }
}