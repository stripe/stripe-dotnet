using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Stripe {
    public  class StripeDiscountDelete 
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}
