using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineTotal
    {
        public MachineTotal()
        {
            this.MachineTotalsMachineDeductions = new List<MachineDeduction>();
        }

        public int FiscalYearID { get; set; }
        public int FiscalPeriodID { get; set; }
        public int MachineID { get; set; }
        public int SiteID { get; set; }
        public int ModelID { get; set; }
        public int NoOfCollections { get; set; }
        public decimal TotalCoinsIn { get; set; }
        public decimal TotalCoinboxDrop { get; set; }
        public decimal TotalCoinRefill { get; set; }
        public decimal TotalCoinsOut { get; set; }
        public decimal TotalCoinDump { get; set; }
        public decimal TotalNotesIn { get; set; }
        public decimal TotalCashIn { get; set; }
        public decimal TotalCashOut { get; set; }
        public decimal TotalCashlessIn { get; set; }
        public decimal TotalCashlessOut { get; set; }
        public decimal TotalBet { get; set; }
        public decimal TotalWin { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalResets { get; set; }
        public decimal TotalHandPays { get; set; }
        public int TotalDoorOpens { get; set; }
        public int TotalCashDoorOpens { get; set; }
        public int TotalLogicDoorOpens { get; set; }
        public int TotalCallAttendants { get; set; }
        public decimal TotalProgressiveWin { get; set; }
        public decimal DoubleUpIn { get; set; }
        public decimal DoubleUpOut { get; set; }
        public decimal RemoteCashIn { get; set; }
        public decimal RemoteCashOut { get; set; }
        public decimal GrossGamingRevenue { get; set; }
        public decimal NettGamingRevenue { get; set; }
        public Nullable<double> DownTimeHours { get; set; }
        public Nullable<double> SiteIndex { get; set; }
        public Nullable<double> MachineIndex { get; set; }
        public virtual FiscalPeriod FiscalPeriodsFiscalPeriod { get; set; }
        public virtual ICollection<MachineDeduction> MachineTotalsMachineDeductions { get; set; }
    }
}
