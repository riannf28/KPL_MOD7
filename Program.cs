using System;

namespace modul7_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig bank = new BankTransferConfig();
            bank.ReadJSON();
            if (bank.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer");
            } else if (bank.lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer");
            }
            if (bank.lang == "EN")
            {
                Console.WriteLine("Select transfer method");
            }
            else if (bank.lang == "ID")
            {
                Console.WriteLine("Pilih metode transfer");
            }
            if (bank.lang == "EN")
            {
                Console.WriteLine("Please type <CONFIG6> to confirm the transaction");
            }
            else if (bank.lang == "ID")
            {
                Console.WriteLine("Ketik <CONFIG7> untuk mengkonfirmasi transaksi");
            }
            if (bank.lang == "EN")
            {
                Console.WriteLine("The transfer is completed");
            }
            else if (bank.lang == "ID")
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            if (bank.lang == "EN")
            {
                Console.WriteLine("Transfer is cancelled");
            }
            else if (bank.lang == "ID")
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }
    }
}
