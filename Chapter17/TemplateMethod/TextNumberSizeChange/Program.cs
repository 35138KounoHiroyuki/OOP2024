using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using TextNumberChange;



namespace TextNumberChanger {
    internal class Program {
        static void Main(string[] args) {
        //    TextProcessor.Run<TextNumberChangeProcessor>(args[0]);

            var processor = new Framework.TextFileProcessor(new ToHankaku ());
            processor.Run(args[0]);
        }
    }
}
