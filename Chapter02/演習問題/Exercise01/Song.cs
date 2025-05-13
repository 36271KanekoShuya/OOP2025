using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //2.1.1
    public class Song {
        public string Title { get; private set; } = string.Empty;
        public string ArtistName { get; private set; } = string.Empty;
        public int Length { get; private set; }

        //2.1.2
        /// <summary>
        /// 歌の情報を格納するコンストラクタ
        /// </summary>
        /// <param name="title">歌のタイトル</param>
        /// <param name="artistName">アーティスト名</param>
        /// <param name="length">演奏時間</param>
        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }

    }

    

}
