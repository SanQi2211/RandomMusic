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
using Un4seen.Bass;

namespace RandomMusic
{
    public partial class mainForm : UIForm
    {
        public mainForm()
        {
            InitializeComponent();
            BassNet.Registration("2323326932@qq.com", "994cb1f810");
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS, IntPtr.Zero);
        }

        double alltime;
        int stream;
        int x = 0;
        double schedule = 0;//播放进度
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
                if (stream != 0)
                {
                    ChannelPlay();
                }
                else
                {
                    //new Task(() =>
                    //               {
                    play(new Random().Next(0, musicList.Count));
                    //               }).Start();
                }

            }
            else
            {
                btnPlay.Symbol = 61515;
                ChannelPause();
            }

        }

        public void play(int i)
        {
            tmrPlay.Enabled = true;
            var id = musicList[i].id;
            x = i;
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
            lblInf.Text = infModel.songs[0].name + "  -   " + infModel.songs[0].ar[0].name;

            Bass.BASS_Start();

            stream = Bass.BASS_StreamCreateURL(musicPlayUrl, 0, BASSFlag.BASS_SAMPLE_FLOAT, null, IntPtr.Zero);


            alltime = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
            Bass.BASS_ChannelPlay(stream, true);
            MessageBox.Show(GetLength.ToString());
            MessageBox.Show(Position.ToString());

            var aaa = value;
        }

        //暂停播放
        public void ChannelPause() { Bass.BASS_ChannelPause(stream); }
        public void ChannelPlay() { Bass.BASS_ChannelPlay(stream, false); }
        //获取当前音量 ref value
        public float value
        {
            //获取当前音量 ref value
            get
            {
                float value = 0;
                Bass.BASS_ChannelGetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, ref value);
                return value;
            }
        }

        //长度
        public TimeSpan GetLength
        {
            get
            {
                double seconds = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
                return TimeSpan.FromSeconds(seconds);
            }
        }
        //当前播放位置
        public TimeSpan Position
        {
            get
            {
                double seconds = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));
                return TimeSpan.FromSeconds(seconds);
            }
            set => Bass.BASS_ChannelSetPosition(stream, value.TotalSeconds);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPlay.Symbol = 61515;
            stream = 0;
            tmrPlay.Enabled = false;
            Bass.BASS_ChannelStop(stream);
            //Bass.BASS_StreamFree(stream);

            Bass.BASS_Stop();
            //Bass.BASS_Free();

        }



        private void btnPer_Click(object sender, EventArgs e)
        {

            btnStop_Click(null, null);
            btnPlay.Symbol = 61516;
            var a = x - 1;
            if (a < 0)
            {
                a = 0;
            }
            play(a);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnStop_Click(null, null);
            btnPlay.Symbol = 61516;
            var a = x + 1;
            if (a > musicList.Count)
            {
                a = musicList.Count;
            }
            play(a);
        }

        private void tmrPlay_Tick(object sender, EventArgs e)
        {
            double runningtime = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));//获取当前正播放歌曲的进度

            TimeTrack.Value = Convert.ToInt32(Schedule * 100);
            if (alltime <= runningtime)
            {
                btnNext_Click(null, null);
            }//自动下一曲
        }

        /// <summary>
        /// 播放进度0—1
        /// </summary>
        public double Schedule
        {
            get
            {
                if (stream == 0 || Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream)) == -1)
                {
                    schedule = 0;
                }
                else
                {
                    schedule = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream)) / Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
                }
                return schedule;
            }
            set
            {
                schedule = value;
                double temp = schedule * Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
                Bass.BASS_ChannelSetPosition(stream, Bass.BASS_ChannelSeconds2Bytes(stream, temp));
            }
        }
        bool TrackFlag = false;
        private void TimeTrack_Scroll(object sender, EventArgs e)
        {

            double s = Schedule;
            Schedule = (double)TimeTrack.Value / 100;
            //if (MusicLrcPannel.Visible)
            //{
            //    if (s < schedule)
            //    {
            //        TrackFlag = false;
            //    }
            //    else
            //    {
            //        TrackFlag = true;
            //    }

            //}

        }
    }
}
