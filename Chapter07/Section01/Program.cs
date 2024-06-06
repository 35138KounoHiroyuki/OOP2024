using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
           
            var prefOfficeDict = new Dictionary<string, string>();
            
            //入力処理
            Console.WriteLine("県庁所在地の登録");
            for (int i = 0; i < 5; i++) {
                //  都道府県の入力

                Console.WriteLine("都道府県");
                string prefecture = Console.ReadLine();

                //県庁所在地の入力              

                Console.WriteLine("県庁所在地");
                string city = Console.ReadLine();

                prefOfficeDict.Add(prefecture, city);
            }
                //出力
                foreach (var item in prefOfficeDict) {
                Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");

                }
                //すでに都道府県が登録されているか?
                var key = prefOfficeDict;
            //  if (prefOfficeDict.ContainsKey(key)) { 
                
                
                }
                
                    
                }
            }
        
    

