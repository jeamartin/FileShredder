using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShredder
{
    public static class Extensions
    {
        public static byte[] ToArray(this byte b)
        {
            byte[] ret = new byte[1];
            ret[0] = b;
            return ret;
        }
    }
}
