using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMusic
{
    public class Models
    {

        public class MusicList
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
        //

        public class MusicDetailModel
        {




            public Song[] songs { get; set; }
            public Privilege[] privileges { get; set; }
            public int code { get; set; }
        }

        public class Song
        {
            public string name { get; set; }
            public int id { get; set; }
            public int pst { get; set; }
            public int t { get; set; }
            public Ar[] ar { get; set; }
            public string[] alia { get; set; }
            public float pop { get; set; }
            public int st { get; set; }
            public object rt { get; set; }
            public int fee { get; set; }
            public int v { get; set; }
            public object crbt { get; set; }
            public string cf { get; set; }
            public Al al { get; set; }
            public int dt { get; set; }
            public H h { get; set; }
            public M m { get; set; }
            public L l { get; set; }
            public object a { get; set; }
            public string cd { get; set; }
            public int no { get; set; }
            public object rtUrl { get; set; }
            public int ftype { get; set; }
            public object[] rtUrls { get; set; }
            public int djId { get; set; }
            public int copyright { get; set; }
            public int s_id { get; set; }
            public int mark { get; set; }
            public int originCoverType { get; set; }
            public object originSongSimpleData { get; set; }
            public bool resourceState { get; set; }
            public int single { get; set; }
            public object noCopyrightRcmd { get; set; }
            public int rtype { get; set; }
            public object rurl { get; set; }
            public int mst { get; set; }
            public int cp { get; set; }
            public int mv { get; set; }
            public long publishTime { get; set; }
        }

        public class Al
        {
            public int id { get; set; }
            public string name { get; set; }
            public string picUrl { get; set; }
            public object[] tns { get; set; }
            public string pic_str { get; set; }
            public long pic { get; set; }
        }

        public class H
        {
            public int br { get; set; }
            public int fid { get; set; }
            public int size { get; set; }
            public float vd { get; set; }
        }

        public class M
        {
            public int br { get; set; }
            public int fid { get; set; }
            public int size { get; set; }
            public float vd { get; set; }
        }

        public class L
        {
            public int br { get; set; }
            public int fid { get; set; }
            public int size { get; set; }
            public float vd { get; set; }
        }

        public class Ar
        {
            public int id { get; set; }
            public string name { get; set; }
            public object[] tns { get; set; }
            public object[] alias { get; set; }
        }

        public class Privilege
        {
            public int id { get; set; }
            public int fee { get; set; }
            public int payed { get; set; }
            public int st { get; set; }
            public int pl { get; set; }
            public int dl { get; set; }
            public int sp { get; set; }
            public int cp { get; set; }
            public int subp { get; set; }
            public bool cs { get; set; }
            public int maxbr { get; set; }
            public int fl { get; set; }
            public bool toast { get; set; }
            public int flag { get; set; }
            public bool preSell { get; set; }
            public int playMaxbr { get; set; }
            public int downloadMaxbr { get; set; }
            public object rscl { get; set; }
            public Freetrialprivilege freeTrialPrivilege { get; set; }
            public Chargeinfolist[] chargeInfoList { get; set; }
        }

        public class Freetrialprivilege
        {
            public bool resConsumable { get; set; }
            public bool userConsumable { get; set; }
        }

        public class Chargeinfolist
        {
            public int rate { get; set; }
            public object chargeUrl { get; set; }
            public object chargeMessage { get; set; }
            public int chargeType { get; set; }
        }


        //

        public class MusicSongModel
        {
            public Datum[] data { get; set; }
            public int code { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string url { get; set; }
            public int br { get; set; }
            public int size { get; set; }
            public string md5 { get; set; }
            public int code { get; set; }
            public int expi { get; set; }
            public string type { get; set; }
            public int gain { get; set; }
            public int fee { get; set; }
            public object uf { get; set; }
            public int payed { get; set; }
            public int flag { get; set; }
            public bool canExtend { get; set; }
            public object freeTrialInfo { get; set; }
            public object level { get; set; }
            public object encodeType { get; set; }
            public SongFreetrialprivilege freeTrialPrivilege { get; set; }
            public Freetimetrialprivilege freeTimeTrialPrivilege { get; set; }
            public int urlSource { get; set; }
        }

        public class SongFreetrialprivilege
        {
            public bool resConsumable { get; set; }
            public bool userConsumable { get; set; }
        }

        public class Freetimetrialprivilege
        {
            public bool resConsumable { get; set; }
            public bool userConsumable { get; set; }
            public int type { get; set; }
            public int remainTime { get; set; }
        }

        //
    }
}
