using System;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemDate> items;
        Dictionary<string, string> rssUrlDict = new Dictionary<string, string>() {
            {"主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
            {"経済","https://news.yahoo.co.jp/rss/topics/business.xml" },
            {"IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
            {"科学","https://news.yahoo.co.jp/rss/topics/science.xml" },
        };

        public Form1() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {
            //戻&進ボタンのマスク
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoForward.Enabled = wvRssLink.CanGoForward;
            cbUrl.Items.AddRange(rssUrlDict.Select(x => x.Key).ToArray());
            cbUrl.SelectedIndex = -1;
        }

        private async void btRssGet_Click(object sender, EventArgs e) {
            try {
                using (var wc = new HttpClient()) {
                    using HttpResponseMessage response = await wc.GetAsync(getrssUrl(cbUrl.Text));
                    if (response is not null) {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        XDocument xdoc = XDocument.Parse(responseBody);//RSS取得

                        items = xdoc.Root.Descendants("item")
                                .Select(x =>
                                    new ItemDate {
                                        Title = (string?)x.Element("title"),
                                        Link = (string?)x.Element("link"),
                                    }
                                ).ToList();

                        lbTitles.Items.Clear();
                        items.ForEach(x => lbTitles.Items.Add(x.Title));
                        tsslbMessage.Text = "エラーコードなどがここに";
                    } else return;
                }
            }
            catch (InvalidOperationException) {
                tsslbMessage.Text = "URIがありません";
                return;
            }
            catch (Exception ex) {
                tsslbMessage.Text = ex.Message;
                return;
            }

        }
        /// <summary>
        /// 辞書に登録してあるものか判別します
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string? getrssUrl(string str) {
            if (rssUrlDict.ContainsKey(str)) {
                return rssUrlDict[str];
            }
            return str;

        }

        //記事を選択したときのイベントハンドラ
        private void lbTitles_Click(object sender, EventArgs e) {
            if (lbTitles is null || lbTitles.SelectedIndex == -1) {
                return;
            }
            try {
                wvRssLink.Source = new Uri(items[lbTitles.SelectedIndex].Link);
                tbSiteUrl.Text = items[lbTitles.SelectedIndex].Link;
            }
            catch (Exception ex) {
                tsslbMessage.Text = ex.Message;
                return;
            }

        }

        private void btGoBack_Click(object sender, EventArgs e) {
            wvRssLink.GoBack();
        }

        private void btGoForward_Click(object sender, EventArgs e) {
            wvRssLink.GoForward();
        }

        private void btFavorite_Click(object sender, EventArgs e) {
            if (IsValidUrl(cbUrl.Text)) {
                if (cbUrl.Items.Contains(cbUrl.Text)) {
                    tsslbMessage.Text = "既に登録されています";
                    return;
                }
                if (string.IsNullOrEmpty(cbUrl.Text)) {
                    tsslbMessage.Text = "空欄です";
                    return;
                }
                if (string.IsNullOrEmpty(tbfavoName.Text)) {
                    if (rssUrlDict.ContainsValue(cbUrl.Text)) {
                        tsslbMessage.Text = "既に登録されています";
                        return;
                    }
                    rssUrlDict.Add($"{cbUrl.Text}", cbUrl.Text);
                    cbUrl.Items.Add(cbUrl.Text);
                } else {
                    if (rssUrlDict.ContainsKey(tbfavoName.Text)) {
                        tsslbMessage.Text = "既に登録されています";
                        return;
                    }
                    rssUrlDict.Add($"{tbfavoName.Text}", cbUrl.Text);
                    cbUrl.Items.Add(tbfavoName.Text);
                }
            } else {
                tsslbMessage.Text = "URLがありません。";
            }
        }

        private void btFavoDelete_Click(object sender, EventArgs e) {
            if (cbUrl.SelectedIndex == -1) {
                tsslbMessage.Text = "選択されていません";
                return;
            }
            rssUrlDict.Remove(cbUrl.SelectedItem.ToString());
            cbUrl.Items.Remove(cbUrl.SelectedItem);
        }


        private void wvRssLink_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {
            GoBackForwardCheck();
        }

        private void lbTitles_DrawItem(object sender, DrawItemEventArgs e) {
            var idx = e.Index;                                                      //描画対象の行
            if (idx == -1) return;                                                  //範囲外なら何もしない
            var sts = e.State;                                                      //セルの状態
            var fnt = e.Font;                                                       //フォント
            var _bnd = e.Bounds;                                                    //描画範囲(オリジナル)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //描画範囲(描画用)
            var txt = (string)lbTitles.Items[idx];                                  //リストボックス内の文字
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //文字色
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //選択行か
            var odd = (idx % 2 == 1);                                               //奇数行か
            var fore = Brushes.WhiteSmoke;                                         //偶数行の背景色
            var bak = Brushes.LightCyan;                                           //奇数行の背景色

            e.DrawBackground();                                                     //背景描画

            //奇数項目の背景色を変える（選択行は除く）
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //文字を描画
            e.Graphics.DrawString(txt, fnt, bsh, bnd);
        }

        /// <summary>
        /// 戻・進ボタンの押せるかの判定をし、マスク処理をします。
        /// </summary>
        private void GoBackForwardCheck() {
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoForward.Enabled = wvRssLink.CanGoForward;
        }

        /// <summary>
        /// 有効なURLか判別します。
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static bool IsValidUrl(string url) {
            Uri? uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                    (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

        }
    }
}
