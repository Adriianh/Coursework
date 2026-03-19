namespace Actividad14.Exercise08
{
    public static class AccountExerciseRunner
    {
        public static void Run()
        {
            var accounts = new List<Account>();
            Console.Write("¿Cuántas cuentas desea registrar? ");
            int count = ReadInt();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nCuenta #{i + 1}");
                Console.Write("Titular: ");
                string holder = Console.ReadLine()!;
                
                Console.Write("Saldo inicial: Q");
                decimal initialBalance = ReadDecimal();
                
                accounts.Add(new Account(holder, initialBalance));
            }

            foreach (var account in accounts)
            {
                Console.WriteLine($"\nOperaciones para {account.Holder}");
                while (true)
                {
                    Console.Write("¿Desea realizar un depósito (d), retiro (r) o salir (s)? ");
                    string op = Console.ReadLine()!;
                    if (op == "s") break;
                    
                    switch (op)
                    {
                        case "d":
                        {
                            Console.Write("Monto a depositar: ");
                            decimal deposit = ReadDecimal();
                            
                            if (deposit > 0)
                            {
                                account.Deposit(deposit);
                                Console.WriteLine($"Depósito realizado. Saldo actual: Q{account.Balance:C}");
                            }
                            else
                            {
                                Console.WriteLine("Monto inválido.");
                            }
                            
                            break;
                        }
                        case "r":
                        {
                            Console.Write("Monto a retirar: ");
                            decimal withdrawal = ReadDecimal();
                            if (withdrawal > 0 && withdrawal <= account.Balance)
                            {
                                account.Withdraw(withdrawal);
                                Console.WriteLine($"Retiro realizado. Saldo actual: Q{account.Balance:C}");
                            }
                            else
                            {
                                Console.WriteLine("Monto inválido o saldo insuficiente.");
                            }
                            
                            break;
                        }
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }

            Console.WriteLine("\n--- Saldos finales de todas las cuentas ---");
            foreach (var account in accounts)
            {
                account.ShowBalance();
            }
        }
        
        private static int ReadInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                Console.WriteLine("Valor inválido, intente de nuevo:");
            }
        }

        private static decimal ReadDecimal()
        {
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal value))
                    return value;
            }
        }
    }
}