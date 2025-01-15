#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.POJO.Entity
 * Unique: 65fbc16e-3472-4258-9ff9-ac9438ec6fde
 * File name: YearWeight
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/14/2025 16:59:17
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
    [Table(Name = "t_year_weight")]
    public class YearWeight : BaseEntity
    {
        /// <summary>
        /// 主键 ID
        /// </summary>
        [PrimaryKey, Identity]
        public int Id { get; set; }

        /// <summary>
        /// 公历年份
        /// </summary>
        [Column(Name = "solar_year"), NotNull]
        public int SolarYear { get; set; }

        /// <summary>
        /// 权重，支持一位小数
        /// </summary>
        [Column(Name = "weight"), NotNull]
        public decimal Weight { get; set; }


    }
}
