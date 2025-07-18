using System.Net;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemDate> items;
        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text); 
                XDocument xdoc = XDocument.Load(url);//RSSŽæ“¾

                items = xdoc.Root.Descendants("item")
                        .Select(x => 
                            new ItemDate { 
                                Title = (string)x.Element("title") 
                            })
                        .ToList();
                foreach (var item in items) {
                    lbTitles.Items.Add(item.Title);
                }

            }
        }
    }
}
