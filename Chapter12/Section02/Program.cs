﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var novels = new Novel[] {
              new Novel {
                  Author = "アイザック・アシモフ",
                  Title = "われはロボット",
                  Published = 1950,
                 },
              new Novel {
                  Author = "ジョージ・オーウェル",
                  Title = "一九八四年",
                  Published = 1949,
                 },
             };
#if false
            using (var stream = new FileStream("novels.json",FileMode.Create,FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(novel.GetType());
                serializer.WriteObject(stream, novels);
            }
#else
            var options = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRange.All),
                WriteIndented = true,
            };
            string jsonString = JsonSerializer.Serialize(novels);
            Console.WriteLine(jsonString);




#endif
        }
    }
}
