using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineCollection
    {
        public System.DateTime CollectionEndTime { get; set; }
        public System.DateTime CollectionStartTime { get; set; }
        public int MachineType { get; set; }
        public int GameType { get; set; }
        public string SoftwareVersion { get; set; }
        public long MachineID { get; set; }
        public Nullable<int> SiteID { get; set; }
        public Nullable<int> RevenueProfileID { get; set; }
        public string ProtocolVersion { get; set; }
        public int MaximumBet { get; set; }
        public int AccountingDenom { get; set; }
        public int TargetPercentage { get; set; }
        public int CoinsIn10c { get; set; }
        public int CoinsIn20c { get; set; }
        public int CoinsIn50c { get; set; }
        public int CoinsIn100c { get; set; }
        public int CoinsIn200c { get; set; }
        public int CoinsIn500c { get; set; }
        public int CoinsIn1000c { get; set; }
        public int CoinsIn2000c { get; set; }
        public int CoinsIn5000c { get; set; }
        public int CoinDrop10c { get; set; }
        public int CoinDrop20c { get; set; }
        public int CoinDrop50c { get; set; }
        public int CoinDrop100c { get; set; }
        public int CoinDrop200c { get; set; }
        public int CoinDrop500c { get; set; }
        public int CoinDrop1000c { get; set; }
        public int CoinDrop2000c { get; set; }
        public int CoinDrop5000c { get; set; }
        public int CoinRefill10c { get; set; }
        public int CoinRefill20c { get; set; }
        public int CoinRefill50c { get; set; }
        public int CoinRefill100c { get; set; }
        public int CoinRefill200c { get; set; }
        public int CoinRefill500c { get; set; }
        public int CoinRefill1000c { get; set; }
        public int CoinRefill2000c { get; set; }
        public int CoinRefill5000c { get; set; }
        public int CoinOut10c { get; set; }
        public int CoinOut20c { get; set; }
        public int CoinOut50c { get; set; }
        public int CoinOut100c { get; set; }
        public int CoinOut200c { get; set; }
        public int CoinOut500c { get; set; }
        public int CoinOut1000c { get; set; }
        public int CoinOut2000c { get; set; }
        public int CoinOut5000c { get; set; }
        public int NoteIn10 { get; set; }
        public int NoteIn20 { get; set; }
        public int NoteIn50 { get; set; }
        public int NoteIn100 { get; set; }
        public int NoteIn200 { get; set; }
        public Nullable<int> NoteIn500 { get; set; }
        public Nullable<int> NoteIn1000 { get; set; }
        public Nullable<int> NoteDrop10 { get; set; }
        public Nullable<int> NoteDrop20 { get; set; }
        public Nullable<int> NoteDrop50 { get; set; }
        public Nullable<int> NoteDrop100 { get; set; }
        public Nullable<int> NoteDrop200 { get; set; }
        public Nullable<int> NoteDrop500 { get; set; }
        public Nullable<int> NoteDrop1000 { get; set; }
        public Nullable<int> NoteRefill10 { get; set; }
        public Nullable<int> NoteRefill20 { get; set; }
        public Nullable<int> NoteRefill50 { get; set; }
        public Nullable<int> NoteRefill100 { get; set; }
        public Nullable<int> NoteRefill200 { get; set; }
        public Nullable<int> NoteRefill500 { get; set; }
        public Nullable<int> NoteRefill1000 { get; set; }
        public Nullable<int> NoteOut10 { get; set; }
        public Nullable<int> NoteOut20 { get; set; }
        public Nullable<int> NoteOut50 { get; set; }
        public Nullable<int> NoteOut100 { get; set; }
        public Nullable<int> NoteOut200 { get; set; }
        public Nullable<int> NoteOut500 { get; set; }
        public Nullable<int> NoteOut1000 { get; set; }
        public Nullable<int> TotalBet { get; set; }
        public Nullable<int> TotalWin { get; set; }
        public Nullable<int> TotalCoinDrop { get; set; }
        public Nullable<int> TotalBillDrop { get; set; }
        public Nullable<int> TotalGamesPlayed { get; set; }
        public Nullable<int> TotalGamesWon { get; set; }
        public Nullable<int> RemoteHandpayReset { get; set; }
        public Nullable<int> TotalHandPays { get; set; }
        public Nullable<int> TotalCashIn { get; set; }
        public Nullable<int> TotalCashOut { get; set; }
        public Nullable<int> TotalCashlessIn { get; set; }
        public Nullable<int> TotalCashlessOut { get; set; }
        public Nullable<int> TotalJackpot { get; set; }
        public Nullable<int> TotalTicketIn { get; set; }
        public Nullable<int> TotalTicketOut { get; set; }
        public Nullable<int> TotalDoorOpens { get; set; }
        public int TotalCashDoorOpens { get; set; }
        public int TotalLogicDoorOpens { get; set; }
        public int TotalCallAttendants { get; set; }
        public int TransactionNumber { get; set; }
        public long AccumulatedTotalBet { get; set; }
        public long AccumulatedTotalWin { get; set; }
        public long AccumulatedTotalCoinBoxDrop { get; set; }
        public long AccumulatedTotalBillDrop { get; set; }
        public long AccumulatedTotalGamesPlayed { get; set; }
        public long AccumulatedTotalHandPay { get; set; }
        public long AccumulatedTotalCashIn { get; set; }
        public long AccumulatedTotalCashOut { get; set; }
        public long AccumulatedTotalCashlessIn { get; set; }
        public long AccumulatedTotalCashlessOut { get; set; }
        public Nullable<long> AccumulatedTotalTicketIn { get; set; }
        public Nullable<long> AccumulatedTotalTicketOut { get; set; }
        public Nullable<long> AccumulatedTotalJackpot { get; set; }
        public int CollectionType { get; set; }
        public Nullable<int> ActualCashCollected { get; set; }
        public Nullable<int> CalculatedCash { get; set; }
        public Nullable<System.DateTime> DateProcessed { get; set; }
        public Nullable<int> CertifiedModelID { get; set; }
        public Nullable<int> PortNumber { get; set; }
        public Nullable<int> EPCCertifiedModelID { get; set; }
        public Nullable<System.DateTime> DateMigrated { get; set; }
    }
}
