#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.POJO.Entity
 * Unique: 04223635-0e34-4a34-a441-73be2342c890
 * File name: HourWeight
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/14/2025 17:04:17
 *----------------------------------------------------------------*/
#endregion <<Notes>>
using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ming.BonePredict.POJO.Entity
{
    [Table(Name = "t_hour_weight")]
    public class HourWeight : BaseEntity
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "lunar_hour"), NotNull]
        public string LunarHour { get; set; }

        [Column(Name = "weight"), NotNull]
        public decimal Weight { get; set; }

        [Column(Name = "start_hour"), NotNull]
        public int StartHour { get; set; }

        [Column(Name = "start_minute"), NotNull]
        public int StartMinute { get; set; }

        [Column(Name = "end_hour"), NotNull]
        public int EndHour { get; set; }

        [Column(Name = "end_minute"), NotNull]
        public int EndMinute { get; set; }

    }
}
