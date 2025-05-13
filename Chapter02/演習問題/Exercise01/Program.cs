namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            //2.1.3
            //歌の情報のインスタンスを生成し、格納

            var songs = new Song[] {
                new Song("Let it be", "The Beatles", 243),
                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new Song("Close To You", "Carpenters", 276),
                new Song("Honesty", "Billy Joel", 231),
                new Song("I Will Always Love You", "Whitney Houston", 273),
            };
            PrintSongs(songs);
        }


        //2.1.4
        /// <summary>
        /// 歌の情報を出力するメソッド、演奏時間は分:秒に換算される
        /// </summary>
        /// <param name="songs"></param>
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine($"Title＞{song.Title,-30} | Artist＞{song.ArtistName,-20}" +
                                        $" | Length＞{TimeSpan.FromSeconds(song.Length):mm\\:ss}");

            }
        }
    }
}
