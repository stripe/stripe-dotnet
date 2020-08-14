namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BankAccountVerifyOptions : BaseOptions
    {
        /// <summary>
        /// Two positive integers, in <em>cents</em>, equal to the values of the microdeposits sent
        /// to the bank account.
        /// </summary>
        [JsonProperty("amounts")]
        public List<long> Amounts { get; set; }
    }
}
