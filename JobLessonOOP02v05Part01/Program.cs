﻿namespace JobLessonOOP02v05Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.GetNumberBankAccount(1);
            bankAccount.GetBallanceBankAccount(100.1m);
            bankAccount.GetTypeBankAccount(TypeBankAccount.DEBET);
            bankAccount.Print();
        }
    }
}
