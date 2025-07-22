using System;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemDate> items;
        Dictionary<string, string> rssUrlDict = new Dictionary<string, string>() {
            {"��v","https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
            {"�o��","https://news.yahoo.co.jp/rss/topics/business.xml" },
            {"IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
            {"�Ȋw","https://news.yahoo.co.jp/rss/topics/science.xml" },
        };

        public Form1() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {
            //��&�i�{�^���̃}�X�N
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoForward.Enabled = wvRssLink.CanGoForward;
            cbUrl.DataSource = rssUrlDict.Select(x => x.Key).ToList();
            cbUrl.SelectedIndex = -1;
        }

        private async void btRssGet_Click(object sender, EventArgs e) {
            try {
                using (var wc = new HttpClient()) {
                    using HttpResponseMessage response = await wc.GetAsync(getrssUrl(cbUrl.Text));
                    if (response is not null) {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        XDocument xdoc = XDocument.Parse(responseBody);//RSS�擾

                        items = xdoc.Root.Descendants("item")
                                .Select(x =>
                                    new ItemDate {
                                        Title = (string?)x.Element("title"),
                                        Link = (string?)x.Element("link"),
                                    }
                                ).ToList();

                        lbTitles.Items.Clear();
                        items.ForEach(x => lbTitles.Items.Add(x.Title));
                        lbErrorCodes.Text = "�G���[�R�[�h�Ȃǂ�������";
                    } else return;
                }
            }
            catch (InvalidOperationException) {
                lbErrorCodes.Text = "URI������܂���";
                return;
            }
            catch (Exception ex) {
                lbErrorCodes.Text = ex.Message;
                return;
            }

        }
        private string? getrssUrl(string str) {
            if (rssUrlDict.ContainsKey(str)) {
                return rssUrlDict[str];
            }
            return str;

        }

        //�L����I�������Ƃ��̃C�x���g�n���h��
        private void lbTitles_Click(object sender, EventArgs e) {
            if (lbTitles is null || lbTitles.SelectedIndex == -1) {
                return;
            }
            try {
                wvRssLink.Source = new Uri(items[lbTitles.SelectedIndex].Link);
                tbSiteUrl.Text = items[lbTitles.SelectedIndex].Link;
            }
            catch (Exception ex) {
                lbErrorCodes.Text = ex.Message;
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
            if (cbUrl.Items.Contains(cbUrl.Text)) {
                return;
            } else if (cbUrl.Text is null) {
                return;
            }
            cbUrl.Items.Add(cbUrl.Text);
        }

        private void btFavoDelete_Click(object sender, EventArgs e) {
            if (cbUrl.SelectedIndex == -1) {
                return;
            }
            cbUrl.Items.Remove(cbUrl.SelectedItem);
        }

        private void wvRssLink_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e) {

        }

        private void wvRssLink_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {
            GoBackForwardCheck();
        }

        /// <summary>
        /// �߁E�i�{�^���̉����邩�̔�������A�}�X�N���������܂�
        /// </summary>
        private void GoBackForwardCheck() {
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoForward.Enabled = wvRssLink.CanGoForward;
        }

    }
}
