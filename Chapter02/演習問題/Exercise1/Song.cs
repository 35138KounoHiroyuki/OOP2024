using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class Song {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }
    }

    //コンストラクタ
    public Song(string title, string artistName, int length) {
        title = Title;
        artistName = ArtistName;
        length = Length;
    }
}
}
}




