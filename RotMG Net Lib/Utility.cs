using System;
using System.Text;

namespace RotMG_Net_Lib
{
    public class Utility
    {
        public static byte[] HexStringToBytes(string key)
        {
            if (key.Length % 2 != 0)
                throw new ArgumentException("Invalid hex string!");

            byte[] bytes = new byte[key.Length / 2];
            char[] c = key.ToCharArray();
            for (int i = 0; i < c.Length; i += 2)
            {
                StringBuilder sb = new StringBuilder(2).Append(c[i]).Append(c[(i + 1)]);
                int j = Convert.ToInt32(sb.ToString(), 16);
                bytes[(i / 2)] = (byte)j;
            }
            return bytes;
        }
    }
}
