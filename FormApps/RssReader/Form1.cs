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
                        tsslbMessage.Text = "�G���[�R�[�h�Ȃǂ�������";
                    } else return;
                }
            }
            catch (InvalidOperationException) {
                tsslbMessage.Text = "URI������܂���";
                return;
            }
            catch (Exception ex) {
                tsslbMessage.Text = ex.Message;
                return;
            }

        }
        /// <summary>
        /// �����ɓo�^���Ă�����̂����ʂ��܂�
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
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
                    tsslbMessage.Text = "���ɓo�^����Ă��܂�";
                    return;
                }
                if (string.IsNullOrEmpty(cbUrl.Text)) {
                    tsslbMessage.Text = "�󗓂ł�";
                    return;
                }
                if (string.IsNullOrEmpty(tbfavoName.Text)) {
                    if (rssUrlDict.ContainsValue(cbUrl.Text)) {
                        tsslbMessage.Text = "���ɓo�^����Ă��܂�";
                        return;
                    }
                    rssUrlDict.Add($"{cbUrl.Text}", cbUrl.Text);
                    cbUrl.Items.Add(cbUrl.Text);
                } else {
                    if (rssUrlDict.ContainsKey(tbfavoName.Text)) {
                        tsslbMessage.Text = "���ɓo�^����Ă��܂�";
                        return;
                    }
                    rssUrlDict.Add($"{tbfavoName.Text}", cbUrl.Text);
                    cbUrl.Items.Add(tbfavoName.Text);
                }
            } else {
                tsslbMessage.Text = "URL������܂���B";
            }
        }

        private void btFavoDelete_Click(object sender, EventArgs e) {
            if (cbUrl.SelectedIndex == -1) {
                tsslbMessage.Text = "�I������Ă��܂���";
                return;
            }
            rssUrlDict.Remove(cbUrl.SelectedItem.ToString());
            cbUrl.Items.Remove(cbUrl.SelectedItem);
        }


        private void wvRssLink_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {
            GoBackForwardCheck();
        }

        private void lbTitles_DrawItem(object sender, DrawItemEventArgs e) {
            var idx = e.Index;                                                      //�`��Ώۂ̍s
            if (idx == -1) return;                                                  //�͈͊O�Ȃ牽�����Ȃ�
            var sts = e.State;                                                      //�Z���̏��
            var fnt = e.Font;                                                       //�t�H���g
            var _bnd = e.Bounds;                                                    //�`��͈�(�I���W�i��)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //�`��͈�(�`��p)
            var txt = (string)lbTitles.Items[idx];                                  //���X�g�{�b�N�X���̕���
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //�����F
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //�I���s��
            var odd = (idx % 2 == 1);                                               //��s��
            var fore = Brushes.WhiteSmoke;                                         //�����s�̔w�i�F
            var bak = Brushes.LightCyan;                                           //��s�̔w�i�F

            e.DrawBackground();                                                     //�w�i�`��

            //����ڂ̔w�i�F��ς���i�I���s�͏����j
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //������`��
            e.Graphics.DrawString(txt, fnt, bsh, bnd);
        }

        /// <summary>
        /// �߁E�i�{�^���̉����邩�̔�������A�}�X�N���������܂��B
        /// </summary>
        private void GoBackForwardCheck() {
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoForward.Enabled = wvRssLink.CanGoForward;
        }

        /// <summary>
        /// �L����URL�����ʂ��܂��B
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
