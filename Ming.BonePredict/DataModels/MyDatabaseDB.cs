#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.DataModels
 * Unique: 1bb4256e-6c02-492b-8267-2f2f6f28c24b
 * File name: SqliteConnection
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/14/2025 18:59:05
 *----------------------------------------------------------------*/
#endregion <<Notes>>
using LinqToDB;
using LinqToDB.Data;
using Ming.BonePredict.POJO.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ming.BonePredict.DataModels
{
    public class MyDatabaseDB : DataConnection
    {
        public MyDatabaseDB() : base("MyDatabase")
        { }

        public ITable<LifePrediction> LifePredictions => this.GetTable<LifePrediction>();
        public ITable<YearWeight> YearWeights => this.GetTable<YearWeight>();
        public ITable<MonthWeight> MonthWeights => this.GetTable<MonthWeight>();
        public ITable<DayWeight> DayWeights => this.GetTable<DayWeight>();
        public ITable<HourWeight> HourWeights => this.GetTable<HourWeight>();
    }
}
