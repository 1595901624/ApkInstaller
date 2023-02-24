using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSAInstallTool
{
    class AndroidSDKVersion
    {
        public static readonly AndroidSDKVersion BASE = new AndroidSDKVersion(1, "1.0");
        public static readonly AndroidSDKVersion BASE_1_1 = new AndroidSDKVersion(2, "1.1");
        public static readonly AndroidSDKVersion CUPCAKE = new AndroidSDKVersion(3, "1.5");
        public static readonly AndroidSDKVersion DONUT = new AndroidSDKVersion(4, "1.6");
        public static readonly AndroidSDKVersion ECLAIR = new AndroidSDKVersion(5, "2.0");
        public static readonly AndroidSDKVersion ECLAIR_0_1 = new AndroidSDKVersion(6, "2.0.1");
        public static readonly AndroidSDKVersion ECLAIR_MR1 = new AndroidSDKVersion(7, "2.1.x");
        public static readonly AndroidSDKVersion FROYO = new AndroidSDKVersion(8, "2.2.x");
        public static readonly AndroidSDKVersion GINGERBREAD = new AndroidSDKVersion(9, "2.3/2.3.1/2.3.2");
        public static readonly AndroidSDKVersion GINGERBREAD_MR1 = new AndroidSDKVersion(10, "2.3.3/2.3.4");
        public static readonly AndroidSDKVersion HONEYCOMB = new AndroidSDKVersion(11, "3.0.x");
        public static readonly AndroidSDKVersion HONEYCOMB_MR1 = new AndroidSDKVersion(12, "3.1.x");
        public static readonly AndroidSDKVersion HONEYCOMB_MR2 = new AndroidSDKVersion(13, "3.2");
        public static readonly AndroidSDKVersion ICE_CREAM_SANDWICH = new AndroidSDKVersion(14, "4.0/4.0.1/4.0.2");
        public static readonly AndroidSDKVersion ICE_CREAM_SANDWICH_MR1 = new AndroidSDKVersion(15, "4.0.3/4.0.4");
        public static readonly AndroidSDKVersion JELLY_BEAN = new AndroidSDKVersion(16, "4.1/4.1.1");
        public static readonly AndroidSDKVersion JELLY_BEAN_MR1 = new AndroidSDKVersion(17, "4.2/4.2.2");
        public static readonly AndroidSDKVersion JELLY_BEAN_MR2 = new AndroidSDKVersion(18, "4.3");
        public static readonly AndroidSDKVersion KITKAT = new AndroidSDKVersion(19, "4.4");
        public static readonly AndroidSDKVersion KITKAT_WATCH = new AndroidSDKVersion(20, "4.4W");
        public static readonly AndroidSDKVersion LOLLIPOP = new AndroidSDKVersion(21, "5.0");
        public static readonly AndroidSDKVersion LOLLIPOP_MR1 = new AndroidSDKVersion(22, "5.1");
        public static readonly AndroidSDKVersion M = new AndroidSDKVersion(23, "6.0");
        public static readonly AndroidSDKVersion N1 = new AndroidSDKVersion(24, "7.0");
        public static readonly AndroidSDKVersion N2 = new AndroidSDKVersion(25, "7.1");
        public static readonly AndroidSDKVersion O1 = new AndroidSDKVersion(26, "8.0");
        public static readonly AndroidSDKVersion O2 = new AndroidSDKVersion(27, "8.1");
        public static readonly AndroidSDKVersion P = new AndroidSDKVersion(28, "9");
        public static readonly AndroidSDKVersion Q = new AndroidSDKVersion(29, "10");
        public static readonly AndroidSDKVersion R = new AndroidSDKVersion(30, "11");
        public static readonly AndroidSDKVersion S = new AndroidSDKVersion(31, "12");
        public static readonly AndroidSDKVersion S_V2 = new AndroidSDKVersion(32, "12L");
        public static readonly AndroidSDKVersion TIRAMISU = new AndroidSDKVersion(33, "13");

        public static IEnumerable<AndroidSDKVersion> Values
        {
            get
            {
                yield return BASE;
                yield return BASE_1_1;
                yield return CUPCAKE;
                yield return DONUT;
                yield return ECLAIR;
                yield return ECLAIR_0_1;
                yield return ECLAIR_MR1;
                yield return FROYO;
                yield return GINGERBREAD;
                yield return GINGERBREAD_MR1;
                yield return HONEYCOMB;
                yield return HONEYCOMB_MR1;
                yield return HONEYCOMB_MR2;
                yield return ICE_CREAM_SANDWICH;
                yield return ICE_CREAM_SANDWICH_MR1;
                yield return JELLY_BEAN;
                yield return JELLY_BEAN_MR1;
                yield return JELLY_BEAN_MR2;
                yield return KITKAT;
                yield return KITKAT_WATCH;
                yield return LOLLIPOP;
                yield return LOLLIPOP_MR1;
                yield return M;
                yield return N1;
                yield return N2;
                yield return O1;
                yield return O2;
                yield return P;
                yield return Q;
                yield return R;
                yield return S;
            }
        }

        public int api { get; private set; }
        public string version { get; private set; }

        public AndroidSDKVersion(int api, string version)
        {
            this.api = api;
            this.version = version;
        }
    }
}
