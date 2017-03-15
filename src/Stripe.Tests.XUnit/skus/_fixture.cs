using System;

namespace Stripe.Tests.Xunit
{
    public class sku_fixture : IDisposable
    {
        public StripeSku Sku { get; }
        public StripeSku SkuUpdated { get; }
        public StripeSkuCreateOptions SkuCreateOptions { get; }
        public StripeSkuUpdateOptions SkuUpdateOptions { get; }

        public sku_fixture()
        {
            Sku = Cache.GetSku();
            SkuCreateOptions = Cache.GetSkuCreateOptions();
            SkuUpdateOptions = Cache.GetSkuUpdateOptions();

            var skuToUpdate = Cache.GetSkuToUpdate();
            var service = new StripeSkuService(Cache.ApiKey);
            SkuUpdated = service.Update(skuToUpdate.Id, Cache.GetSkuUpdateOptions());
        }

        public void Dispose()
        {
            new StripeSkuService(Cache.ApiKey).Delete(Sku.Id);
        }
    }
}
