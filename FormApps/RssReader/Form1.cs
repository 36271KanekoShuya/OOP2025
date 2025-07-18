using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemDate> items;
        public Form1() {
            InitializeComponent();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {
            try {
                using (var wc = new HttpClient()) {
                    using HttpResponseMessage response = await wc.GetAsync(cbUrl.Text);
                    if (response is not null) {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        XDocument xdoc = XDocument.Parse(responseBody);//RSS取得

                        items = xdoc.Root.Descendants("item")
                                .Select(x =>
                                    new ItemDate {
                                        Title = (string)x.Element("title"),
                                        Link = (string)x.Element("link"),
                                    }
                                ).ToList();

                        lbTitles.Items.Clear();
                        items.ForEach(x => lbTitles.Items.Add(x.Title));
                        setcbUrl(cbUrl.Text);
                        lbErrorCodes.Text = "エラーコードなどがここに";
                    } else return;
                }
            }
            catch (InvalidOperationException) {
                lbErrorCodes.Text = "URIがありません";
                return;
            }
            catch (Exception ex) {
                lbErrorCodes.Text = ex.Message;
                return;
            }

        }
        //記事を選択したときのイベントハンドラ
        private void lbTitles_Click(object sender, EventArgs e) {
            if (lbTitles is null || lbTitles.SelectedIndex == -1) {
                return;
            }
            try {
                wvRssLink.Source = new Uri(items[lbTitles.SelectedIndex].Link);
            }
            catch (Exception ex) {
                lbErrorCodes.Text = ex.Message;
                return;
            }

        }

        private void btGoBack_Click(object sender, EventArgs e) {
            if (wvRssLink is not null && wvRssLink.CanGoBack) wvRssLink.GoBack();
        }

        private void btGoForward_Click(object sender, EventArgs e) {
            if (wvRssLink is not null && wvRssLink.CanGoForward) wvRssLink.GoForward();
        }
        /// <summary>
        /// コンボボックスへURIの履歴を登録します
        /// </summary>
        /// <param name="url"></param>
        private void setcbUrl(string url) {
            if (cbUrl.Items.Contains(url)) {
                return;
            } else if (url is null) {
                return;
            }
            cbUrl.Items.Add(url);
        }

        private void Form1_Load(object sender, EventArgs e) {
            //戻&進ボタンのマスク
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoForward.Enabled = wvRssLink.CanGoForward;
        }

        private void btFavorite_Click(object sender, EventArgs e) {

        }
    }
}
