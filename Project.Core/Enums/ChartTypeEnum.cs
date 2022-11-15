using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Project.Core.Enums
{
    public enum ChartTypeEnum : byte
    {
        [Display(Name = "plSummary")]
        [EnumMember(Value = "plSummary")]
        PlSummary = 1,
        [Display(Name = "profitability")]
        [EnumMember(Value = "profitability")]
        Profitability,
        [Display(Name = "revenueBreakDown")]
        [EnumMember(Value = "revenueBreakDown")]
        RevenueBreakDown,
        [Display(Name = "capitalEfficiency")]
        [EnumMember(Value = "capitalEfficiency")]
        CapitalEfficiency,
        [Display(Name = "capitalStructureEvolution")]
        [EnumMember(Value = "capitalStructureEvolution")]
        CapitalStructureEvolution,
        [Display(Name = "solvency")]
        [EnumMember(Value = "solvency")]
        Solvency,
        [Display(Name = "governmentFinancing")]
        [EnumMember(Value = "governmentFinancing")]
        GovernmentFinancing,
        [Display(Name = "taxExpenses")]
        [EnumMember(Value = "taxExpenses")]
        TaxExpenses,
        [Display(Name = "bankCapitalSummary")]
        [EnumMember(Value = "bankCapitalSummary")]
        BankCapitalSummary,
        [Display(Name = "bankNetInterestIncomeBreakDown")]
        [EnumMember(Value = "bankNetInterestIncomeBreakDown")]
        BankNetInterestIncomeBreakDown,
        [Display(Name = "bankProfitability")]
        [EnumMember(Value = "bankProfitability")]
        BankProfitability,
        [Display(Name = "bankFundingStructureSummary")]
        [EnumMember(Value = "bankFundingStructureSummary")]
        BankFundingStructureSummary,
        [Display(Name = "bankBalanceSheetSummary")]
        [EnumMember(Value = "bankBalanceSheetSummary")]
        BankBalanceSheetSummary,
        [Display(Name = "bankProfitOrLossStatementSummary")]
        [EnumMember(Value = "bankProfitOrLossStatementSummary")]
        BankProfitOrLossStatementSummary,
        [Display(Name = "bankInterestInComeBreakdown")]
        [EnumMember(Value = "bankInterestInComeBreakdown")]
        BankInterestInComeBreakdown,
        [Display(Name = "bankNonInterestInComeBreakdown")]
        [EnumMember(Value = "bankNonInterestInComeBreakdown")]
        BankNonInterestInComeBreakdown,
        [Display(Name = "bankCapitalRatios")]
        [EnumMember(Value = "bankCapitalRatios")]
        BankCapitalRatios,
        [Display(Name = "bankProfitabilityRatios")]
        [EnumMember(Value = "bankProfitabilityRatios")]
        BankProfitabilityRatios,
        [Display(Name = "bankLiquidityRatios")]
        [EnumMember(Value = "bankLiquidityRatios")]
        BankLiquidityRatios,
        [Display(Name = "bankAssetQualityRatios")]
        [EnumMember(Value = "bankAssetQualityRatios")]
        BankAssetQualityRatios
    }
}
