using HtmlAgilityPack;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMusic
{
    public partial class mainForm : UIForm
    {
        public mainForm()
        {
            InitializeComponent();
        }
        List<Models.MusicList> musicList = new List<Models.MusicList>();
        private void mainForm_Load(object sender, EventArgs e)
        {
            var musicindex = "https://music.163.com/discover/toplist?id=3778678";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(HttpVisitHelper.Get(musicindex).Html);
            var popularUrl = doc.DocumentNode.SelectNodes("//ul[@class='f-hide']/li");

            string pattern = @"\d+\.?\d*";
            foreach (HtmlNode item in popularUrl)
            {
                var inf = item.SelectSingleNode(".//a").Attributes["href"].Value;
                musicList.Add(new Models.MusicList { name = item.InnerText, url = inf, id = int.Parse(new Regex(pattern).Match(inf).Groups[0].Value) });
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Symbol == 61515)
            {
                btnPlay.Symbol = 61516;
                new Task(() =>
                  {
                      play();
                  }).Start();
            }
            else
            {
                btnPlay.Symbol = 61515;
            }

        }

        public void play()
        {
            var i = new Random().Next(0, musicList.Count);
            var id = musicList[i].id;
            var infModel = JsonConvert.DeserializeObject<Models.MusicDetailModel>(HttpVisitHelper.Get("https://api.imjad.cn/cloudmusic/?type=detail&id=" + musicList[i].id).Html);
            var musicSongModel = JsonConvert.DeserializeObject<Models.MusicSongModel>(HttpVisitHelper.Get("https://api.imjad.cn/cloudmusic/?type=song&id=" + musicList[i].id).Html);
            var imgUlr = infModel.songs[0].al.picUrl;
            var img = HttpVisitHelper.GetImg(imgUlr).ResultByte;
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(img, 0, img.Length);
                pictureBox1.Image = Image.FromStream(ms);
            }
            var musicPlayUrl = musicSongModel.data[0].url;
          //var   stream = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_SAMPLE_FLOAT, null, IntPrt.Zero);
        }

    }
}
