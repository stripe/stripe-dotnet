namespace Stripe
{
    public static class StripeTransferFailureCodes
    {
        public const string InsufficientFunds = "insufficient_funds";
        public const string AccountClosed = "account_closed";
        public const string NoAccount = "no_account";
        public const string InvalidAccountNumber = "invalid_account_number";
        public const string DebitNotAuthorized = "debit_not_authorized";
        public const string BankOwnershipChanged = "bank_ownership_changed";
        public const string AccountFrozen = "account_frozen";
        public const string CouldNotProcess = "could_not_process";
        public const string BankAccountRestricted = "bank_account_restricted";
        public const string InvalidCurrency = "invalid_currency";
    }
}