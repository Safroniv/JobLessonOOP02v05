using System;

namespace JobLessonOOP02v05Part03
{
    partial class BankAccount
    {
        private int _numberBankAccount;
        private decimal _ballanceBankAccount;
        private TypeBankAccount _typeBankAccount;

        private static int _generateNumberBankAccount=1;
        public static int GetgenerateNumberBankAccount(){ return _generateNumberBankAccount++; }
        public void GetNumberBankAccount() {; _numberBankAccount = GetgenerateNumberBankAccount(); }
        public int SetNumberBankAccount() { return _numberBankAccount; }
        public void GetBallanceBankAccount(decimal ballanceBankAccount) { _ballanceBankAccount = ballanceBankAccount; }
        public decimal SetBallanceBankAccount() { return _ballanceBankAccount; }
        public void GetTypeBankAccount(TypeBankAccount typeBankAccount) { _typeBankAccount = typeBankAccount; }
        public TypeBankAccount SetTypeBankAccount() { return _typeBankAccount; }

        public void Print()
        {
            Console.WriteLine(
                $"Банковский счёт пользователя: # {_numberBankAccount} " + "\n" +
                $"Количество средств на счёте пользователя: {_ballanceBankAccount} " + "\n" +
                $"Тип счёта: {_typeBankAccount}" + "\n" +
                $"======================================================== ");
            Console.ReadLine();
        }
    }
}
