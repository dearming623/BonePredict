#region <<Notes>>
/*----------------------------------------------------------------
 * Copy right (c) 2025  All rights reserved。
 * CLR Ver: 4.0.30319.42000
 * Computer: MOLEQ-MING
 * Company: 
 * namespace: Ming.GohostPredict.Repository
 * Unique: 99f1b0a3-0ff7-45a7-889c-170c52b65ebd
 * File name: PredictRepository
 * Domain: MOLEQ-MING
 * 
 * @author: t8min
 * @email: t8ming@live.com
 * @date: 1/15/2025 10:05:47
 *----------------------------------------------------------------*/
#endregion <<Notes>>
using Ming.BonePredict.DataModels;
using Ming.BonePredict.POJO.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Ming.BonePredict.Repository
{
    public class PredictRepository
    {
        public List<YearWeight> ListAllYearWeight()
        {
            using (var db = new MyDatabaseDB())
            {
                return db.YearWeights?.ToList();
            }
        }

        public List<MonthWeight> ListAllMonthWeight()
        {
            using (var db = new MyDatabaseDB())
            {
                return db.MonthWeights?.ToList();
            }
        }

        public List<DayWeight> ListAllDayWeight()
        {
            using (var db = new MyDatabaseDB())
            {
                return db.DayWeights?.ToList();
            }
        }

        public List<HourWeight> ListAllHourWeight()
        {
            using (var db = new MyDatabaseDB())
            {
                return db.HourWeights?.ToList();
            }
        }

        public List<LifePrediction> ListAllLifePredictions()
        {
            using (var db = new MyDatabaseDB())
            {
                return db.LifePredictions?.ToList();
            }
        }
         

    }
}
