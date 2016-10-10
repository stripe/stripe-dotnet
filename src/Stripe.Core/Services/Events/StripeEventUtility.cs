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
        
        public static T ParseEventDataItem<T>(dynamic dataItem)
        {
            return JsonConvert.DeserializeObject<T>((dataItem as JObject).ToString());
        }
    }
}