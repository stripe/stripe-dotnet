namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class ExternalAccountConverter : AbstractStripeObjectConverter<IExternalAccount>
    {
        protected override Dictionary<string, Func<string, IExternalAccount>> ObjectsToMapperFuncs => new Dictionary<string, Func<string, IExternalAccount>>()
        {
            { "bank_account", Mapper<BankAccount>.MapFromJson },
            { "card", Mapper<Card>.MapFromJson },
        };
    }
}
