#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.POJO.Entity
 * Unique: 558f2c53-4503-470a-982b-03521988e85d
 * File name: DayWeight
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/14/2025 17:03:25
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
    [Table(Name = "t_day_weight")]
    public class DayWeight : BaseEntity
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "lunar_day"), NotNull]
        public string LunarDay { get; set; }

        [Column(Name = "weight"), NotNull]
        public decimal Weight { get; set; }

    }
}
