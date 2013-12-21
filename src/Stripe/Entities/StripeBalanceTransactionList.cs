using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
    public class StripeBalanceTransactionList :StripeBase
    {
        [JsonProperty("data")]
        public List<StripeBalanceTransaction> StripeBalanceTransactions { get; set; }
    }
}
