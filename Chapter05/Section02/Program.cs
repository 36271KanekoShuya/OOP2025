namespace Section02 {
    internal class Program {
        static void Main(string[] args) {


            var appver1 = new AppVersion(5, 1);
            var appver2 = new AppVersion(5, 1);
            Console.WriteLine(appver1);
            //if (appver1 == appver2) {
            //    Console.WriteLine("等しい");
            //} else {
            //    Console.WriteLine("等しくない");
            //}


        }
        public record class AppVersion {
            public int Major { get; init; }
            public int Minor { get; init; }
            public int Build { get; init; }
            public int Revision { get; init; }



            //オプション引数(デフォルト引数)
            public AppVersion(int major, int minor, int build = 0, int revision = 0) {
                Major = major;
                Minor = minor;
                Build = build;
                Revision = revision;
            }

            public override string ToString() =>
                $"{Major}.{Minor}.{Build}.{Revision}";

        }

        //プライマリーコンストラクタを使ったクラス定義
        public class AppVersion2(int m, int mi, int b = 0, int r = 0) {
            public int Major { get; init; } = m;
            public int Minor { get; init; } = mi;
            public int Build { get; init; } = b;
            public int Revision { get; init; } = r;


            public override string ToString() =>
                $"{Major}.{Minor}.{Build}.{Revision}";

        }

    }
}

