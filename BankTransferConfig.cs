using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace modul7_1302200040
{
    class BankTransferConfig
    {
        public String lang;
        public String threshold;
        public String low_fee;
        public String high_fee;
        public String methods;
        public String en;
        public String id;
        public void ReadJSON()
        {
            String file = "bank_transfer_config.json";

            String str = File.ReadAllText(file);

            BankTransferConfig bank = JsonSerializer.Deserialize<BankTransferConfig>(str);

            Console.WriteLine($"Language{bank.lang} threshold{bank.threshold} low fee{bank.low_fee} high fee{bank.high_fee} methods{bank.methods} en{bank.en} id{bank.id}");
        }
    }
}
