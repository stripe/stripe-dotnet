using System.Collections.Generic;

namespace Stripe
{
    public class StripeBankAccountService : StripeService
    {
        public StripeBankAccountService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }

        public virtual StripeBankAccount Create(string customerId, StripeBankAccountCreateOptions createOptions)
        {
            var url = string.Format(Urls.BankAccounts, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeBankAccount>.MapFromJson(response);
        }

        public virtual StripeBankAccount Get(string customerId, string bankAccountId)
        {
            var customerUrl = string.Format(Urls.BankAccounts, customerId);
            var url = string.Format("{0}/{1}", customerUrl, bankAccountId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeBankAccount>.MapFromJson(response);
        }

        public virtual StripeBankAccount Update(string customerId, string bankAccountId, StripeBankAccountUpdateOptions updateOptions)
        {
            var customerUrl = string.Format(Urls.BankAccounts, customerId);
            var url = string.Format("{0}/{1}", customerUrl, bankAccountId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeBankAccount>.MapFromJson(response);
        }

        public virtual StripeBankAccount Verify(string customerId, string bankAccountId, StripeBankAccountVerifyOptions verifyOptions)
        {
            var customerUrl = string.Format(Urls.BankAccounts, customerId);
            var url = string.Format("{0}/{1}/verify", customerUrl, bankAccountId);
            url = this.ApplyAllParameters(verifyOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeBankAccount>.MapFromJson(response);
        }

        public virtual void Delete(string customerId, string bankAccountId)
        {
            var customerUrl = string.Format(Urls.BankAccounts, customerId);
            var url = string.Format("{0}/{1}", customerUrl, bankAccountId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeBankAccount> List(string customerId, StripeListOptions listOptions = null)
        {
            var url = string.Format(Urls.BankAccounts, customerId);
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeBankAccount>.MapCollectionFromJson(response);
        }
    }
}