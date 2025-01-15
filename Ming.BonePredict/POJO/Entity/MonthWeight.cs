#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.POJO.Entity
 * Unique: 197f8873-77e1-4202-9cb3-0b75a5173666
 * File name: MonthWeight
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/14/2025 17:02:28
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
    [Table(Name = "t_month_weight")]
    public class MonthWeight : BaseEntity
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "lunar_month"), NotNull]
        public string LunarMonth { get; set; }

        [Column(Name = "weight"), NotNull]
        public decimal Weight { get; set; }

    }
}
