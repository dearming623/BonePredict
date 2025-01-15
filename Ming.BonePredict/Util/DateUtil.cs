#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.Util
 * Unique: b5dcd93c-31dd-4995-9f3c-274740cc912b
 * File name: DateUtil
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/15/2025 10:35:27
 *----------------------------------------------------------------*/
#endregion <<Notes>>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ming.BonePredict.Util
{
    public class DateUtil
    {
        // 自定义方法: DateTime 转 Unix 时间戳
        public static long DateTimeToUnixTime(DateTime dateTime)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((dateTime.ToUniversalTime() - unixEpoch).TotalSeconds);
        }

        // 自定义方法: Unix 时间戳 转 DateTime
        public static DateTime UnixTimeToDateTime(long? unixTime)
        {
            if (!unixTime.HasValue) return DateTime.MinValue;
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return unixEpoch.AddSeconds(unixTime.Value);
        }
    }
}
