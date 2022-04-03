namespace JobLessonOOP02v05Part03
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.GetNumberBankAccount();
            bankAccount.GetBallanceBankAccount(100.1m);
            bankAccount.GetTypeBankAccount(TypeBankAccount.DEBET);
            bankAccount.Print();
        }
    }
}
