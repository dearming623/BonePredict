#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.POJO.Entity
 * Unique: 657a2ea0-5f1a-4e6e-89fa-2c82e9733fc5
 * File name: BaseEntity
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/14/2025 16:57:24
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
    public class BaseEntity
    {
        /// <summary>
        /// 创建时间，Unix 时间戳
        /// </summary>
        [Column(Name = "create_at"), Nullable]
        public long? CreateAt { get; set; }

        /// <summary>
        /// 修改时间，Unix 时间戳
        /// </summary>
        [Column(Name = "modify_at"), Nullable]
        public long? ModifyAt { get; set; }

    }
}
