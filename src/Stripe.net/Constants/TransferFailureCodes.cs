namespace Stripe
{
    public static class TransferFailureCodes
    {
        public static string InsufficientFunds => "insufficient_funds";

        public static string AccountClosed => "account_closed";

        public static string NoAccount => "no_account";

        public static string InvalidAccountNumber => "invalid_account_number";

        public static string DebitNotAuthorized => "debit_not_authorized";

        public static string BankOwnershipChanged => "bank_ownership_changed";

        public static string AccountFrozen => "account_frozen";

        public static string CouldNotProcess => "could_not_process";

        public static string BankAccountRestricted => "bank_account_restricted";

        public static string InvalidCurrency => "invalid_currency";
    }
}
