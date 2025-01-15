#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.POJO.Entity
 * Unique: c4157a00-89ab-40a4-b128-59ce18b480da
 * File name: LifePrediction
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/14/2025 16:39:21
 *----------------------------------------------------------------*/
#endregion <<Notes>>
using LinqToDB.Mapping;
using Ming.BonePredict.POJO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace Ming.BonePredict.POJO.Entity
{
    [Table(Name = "t_life_predictions")]
    public class LifePrediction : BaseEntity
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "total_weight"), NotNull]
        public int TotalWeight { get; set; }

        [Column(Name = "description"), NotNull]
        public string Description { get; set; } 
    }
}
