using LinqToDB;
using Ming.BonePredict.POJO.Entity;
using Ming.BonePredict.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ming.BonePredict
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private PredictRepository predictRepository = new PredictRepository();
        private void button1_Click(object sender, EventArgs e)
        {

            string solarYearStr = tbBirthYear.Text.Trim();
            if (string.IsNullOrEmpty(solarYearStr))
            {
                MessageBox.Show("请输入出生年");
                return;
            }

            if (cbLunarMonth.SelectedIndex <= 0 ||
                cbLunarDay.SelectedIndex <= 0 ||
                cbLunarHour.SelectedIndex <= 0)
            {
                MessageBox.Show("请输入生辰八字.");
                return;
            }
            string prediction = string.Empty;
            decimal liftBoneWeight = 0;

            int birthYear = 1983;
            int lunarMonth = 5;
            int lunarDay = 13;
            int lunarHour = 5;

            birthYear = Convert.ToInt32(tbBirthYear.Text.Trim());
            lunarMonth = cbLunarMonth.SelectedIndex;
            lunarDay = cbLunarDay.SelectedIndex;
            lunarHour = cbLunarHour.SelectedIndex;

            var years = predictRepository.ListAllYearWeight();
            int solarYear = CalcSolarYear(birthYear, years);

            var yearBoneWeight = years.Where(it => it.SolarYear == solarYear).FirstOrDefault().Weight;
            var monthBoneWeight = predictRepository.ListAllMonthWeight().Where(it => it.Id == lunarMonth).FirstOrDefault().Weight;
            var dayBoneWeight = predictRepository.ListAllDayWeight().Where(it => it.Id == lunarDay).FirstOrDefault().Weight;
            var hourBoneWeight = predictRepository.ListAllHourWeight().Where(it => it.Id == lunarHour).FirstOrDefault().Weight;

            liftBoneWeight = yearBoneWeight + monthBoneWeight + dayBoneWeight + hourBoneWeight;

            var lifePredictions = predictRepository.ListAllLifePredictions();
            prediction = lifePredictions.Where(it => it.TotalWeight == liftBoneWeight).FirstOrDefault().Description;


            int liang = (int)liftBoneWeight / 10;
            int qian = (int)liftBoneWeight % 10;
            tbPredictResult.Text = $"骨重: {liang}两{qian}钱\r\n卜文: {prediction}";
        }

        private int CalcSolarYear(int birthYear, List<YearWeight> years)
        {
            if (years == null || years.Count == 0)
            {
                return birthYear;
            }

            bool positive = false, negative = false;
            int maxYear = years.Max(it => it.SolarYear);
            int minYear = years.Min(it => it.SolarYear);

            if (birthYear >= minYear && birthYear <= maxYear)
            {
                return birthYear;
            }

            if (birthYear > maxYear)
            {
                negative = true;
            }

            if (birthYear < minYear)
            {
                positive = true;
            }

            int solarYear = -1;
            do
            {
                solarYear = birthYear;
                if (positive)
                {
                    solarYear = birthYear + 60;
                    continue;
                }
                if (negative)
                {
                    solarYear = birthYear - 60;
                    continue;
                }
            } while (solarYear < minYear && solarYear > maxYear);
            return solarYear;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lunarMonths = predictRepository.ListAllMonthWeight();
            if (lunarMonths != null && lunarMonths.Count > 0)
            {
                var displayLst = lunarMonths.OrderBy(it => it.Id)
                        .Select(it => $"{it.LunarMonth} ({it.Id}月)")
                        .ToList();
                displayLst.Insert(0, "-- Empty --");
                cbLunarMonth.Items.AddRange(displayLst.ToArray());
                cbLunarMonth.SelectedIndex = 5;
            }

            var lunarDays = predictRepository.ListAllDayWeight();
            if (lunarDays != null && lunarDays.Count > 0)
            {
                var displayLst = lunarDays.OrderBy(it => it.Id)
                       .Select(it => $"{it.LunarDay} ({it.Id}日)")
                       .ToList();
                displayLst.Insert(0, "-- Empty --");
                cbLunarDay.Items.AddRange(displayLst.ToArray());
                cbLunarDay.SelectedIndex = 13;
            }

            var lunarHours = predictRepository.ListAllHourWeight();
            if (lunarHours != null && lunarHours.Count > 0)
            {
                var displayLst = lunarHours.OrderBy(it => it.Id)
                 .Select(it =>
                 {
                     var startHour = it.StartHour.ToString("D2");
                     var startMinute = it.StartMinute.ToString("D2");
                     var endHour = it.EndHour.ToString("D2");
                     var endMinute = it.EndMinute.ToString("D2");
                     return $"{it.LunarHour} {startHour}:{startMinute}-{endHour}:{endMinute}";
                 })
                 .ToList();
                displayLst.Insert(0, "-- Empty --");
                cbLunarHour.Items.AddRange(displayLst.ToArray());
                cbLunarHour.SelectedIndex = 5;
            }
        }
    }
}
