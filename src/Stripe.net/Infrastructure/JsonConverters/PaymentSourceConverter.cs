namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;

    internal class PaymentSourceConverter : AbstractStripeObjectConverter<IPaymentSource>
    {
        protected override Dictionary<string, Func<string, IPaymentSource>> ObjectsToMapperFuncs =>
            new Dictionary<string, Func<string, IPaymentSource>>
        {
            { "account", Mapper<Account>.MapFromJson },
            { "bank_account", Mapper<BankAccount>.MapFromJson },
            { "card", Mapper<Card>.MapFromJson },
            { "source", Mapper<Source>.MapFromJson },
        };
    }
}
