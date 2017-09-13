using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FreddieMac : IDirty
    {
        private Value<string> _affordableProduct;
        public string AffordableProduct { get { return _affordableProduct; } set { _affordableProduct = value; } }
        private Value<decimal?> _alimonyAsIncomeReduction;
        public decimal? AlimonyAsIncomeReduction { get { return _alimonyAsIncomeReduction; } set { _alimonyAsIncomeReduction = value; } }
        private Value<decimal?> _allMonthlyPayments;
        public decimal? AllMonthlyPayments { get { return _allMonthlyPayments; } set { _allMonthlyPayments = value; } }
        private Value<bool?> _allowsNegativeAmortizationIndicator;
        public bool? AllowsNegativeAmortizationIndicator { get { return _allowsNegativeAmortizationIndicator; } set { _allowsNegativeAmortizationIndicator = value; } }
        private Value<string> _amountOfFinancedMI;
        public string AmountOfFinancedMI { get { return _amountOfFinancedMI; } set { _amountOfFinancedMI = value; } }
        private Value<string> _aPNCity;
        public string APNCity { get { return _aPNCity; } set { _aPNCity = value; } }
        private Value<bool?> _armsLengthTransactionIndicator;
        public bool? ArmsLengthTransactionIndicator { get { return _armsLengthTransactionIndicator; } set { _armsLengthTransactionIndicator = value; } }
        private Value<bool?> _borrowerQualifiesAsVeteranIndicator;
        public bool? BorrowerQualifiesAsVeteranIndicator { get { return _borrowerQualifiesAsVeteranIndicator; } set { _borrowerQualifiesAsVeteranIndicator = value; } }
        private Value<string> _brokerOriginated;
        public string BrokerOriginated { get { return _brokerOriginated; } set { _brokerOriginated = value; } }
        private Value<string> _buydownContributor;
        public string BuydownContributor { get { return _buydownContributor; } set { _buydownContributor = value; } }
        private Value<string> _condoClass;
        public string CondoClass { get { return _condoClass; } set { _condoClass = value; } }
        private Value<decimal?> _convertibleFeeAmount;
        public decimal? ConvertibleFeeAmount { get { return _convertibleFeeAmount; } set { _convertibleFeeAmount = value; } }
        private Value<decimal?> _convertibleFeePercent;
        public decimal? ConvertibleFeePercent { get { return _convertibleFeePercent; } set { _convertibleFeePercent = value; } }
        private Value<decimal?> _convertibleMaxRateAdjPercent;
        public decimal? ConvertibleMaxRateAdjPercent { get { return _convertibleMaxRateAdjPercent; } set { _convertibleMaxRateAdjPercent = value; } }
        private Value<decimal?> _convertibleMinRateAdjPercent;
        public decimal? ConvertibleMinRateAdjPercent { get { return _convertibleMinRateAdjPercent; } set { _convertibleMinRateAdjPercent = value; } }
        private Value<string> _county;
        public string County { get { return _county; } set { _county = value; } }
        private Value<string> _creditReportCompany;
        public string CreditReportCompany { get { return _creditReportCompany; } set { _creditReportCompany = value; } }
        private Value<decimal?> _financingConcessions;
        public decimal? FinancingConcessions { get { return _financingConcessions; } set { _financingConcessions = value; } }
        private Value<string> _freddieFiel11;
        public string FreddieFiel11 { get { return _freddieFiel11; } set { _freddieFiel11 = value; } }
        private Value<string> _freddieFiel12;
        public string FreddieFiel12 { get { return _freddieFiel12; } set { _freddieFiel12 = value; } }
        private Value<string> _freddieFiel13;
        public string FreddieFiel13 { get { return _freddieFiel13; } set { _freddieFiel13 = value; } }
        private Value<string> _freddieFiel14;
        public string FreddieFiel14 { get { return _freddieFiel14; } set { _freddieFiel14 = value; } }
        private Value<string> _freddieFiel15;
        public string FreddieFiel15 { get { return _freddieFiel15; } set { _freddieFiel15 = value; } }
        private Value<string> _freddieField3;
        public string FreddieField3 { get { return _freddieField3; } set { _freddieField3 = value; } }
        private Value<string> _freddieField7;
        public string FreddieField7 { get { return _freddieField7; } set { _freddieField7 = value; } }
        private Value<string> _hELOCActualBalance;
        public string HELOCActualBalance { get { return _hELOCActualBalance; } set { _hELOCActualBalance = value; } }
        private Value<string> _hELOCCreditLimit;
        public string HELOCCreditLimit { get { return _hELOCCreditLimit; } set { _hELOCCreditLimit = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lenderAltPhone;
        public string LenderAltPhone { get { return _lenderAltPhone; } set { _lenderAltPhone = value; } }
        private Value<string> _lenderRegistration;
        public string LenderRegistration { get { return _lenderRegistration; } set { _lenderRegistration = value; } }
        private Value<string> _loanProspectorID;
        public string LoanProspectorID { get { return _loanProspectorID; } set { _loanProspectorID = value; } }
        private Value<string> _loanToConduitCode;
        public string LoanToConduitCode { get { return _loanToConduitCode; } set { _loanToConduitCode = value; } }
        private Value<string> _longLegalDescription;
        public string LongLegalDescription { get { return _longLegalDescription; } set { _longLegalDescription = value; } }
        private Value<string> _lossCoverage;
        public string LossCoverage { get { return _lossCoverage; } set { _lossCoverage = value; } }
        private Value<string> _lPKeyNumber;
        public string LPKeyNumber { get { return _lPKeyNumber; } set { _lPKeyNumber = value; } }
        private Value<string> _mIRefundOption;
        public string MIRefundOption { get { return _mIRefundOption; } set { _mIRefundOption = value; } }
        private Value<string> _mortgageInsuranceCompany;
        public string MortgageInsuranceCompany { get { return _mortgageInsuranceCompany; } set { _mortgageInsuranceCompany = value; } }
        private Value<decimal?> _netPurchasePrice;
        public decimal? NetPurchasePrice { get { return _netPurchasePrice; } set { _netPurchasePrice = value; } }
        private Value<string> _newConstructionType;
        public string NewConstructionType { get { return _newConstructionType; } set { _newConstructionType = value; } }
        private Value<string> _noAppraisalMAF;
        public string NoAppraisalMAF { get { return _noAppraisalMAF; } set { _noAppraisalMAF = value; } }
        private Value<decimal?> _nonOccupantNonHousingDebt;
        public decimal? NonOccupantNonHousingDebt { get { return _nonOccupantNonHousingDebt; } set { _nonOccupantNonHousingDebt = value; } }
        private Value<decimal?> _nonOccupantPresentHE;
        public decimal? NonOccupantPresentHE { get { return _nonOccupantPresentHE; } set { _nonOccupantPresentHE = value; } }
        private Value<bool?> _orderCreditEvaluationIndicator;
        public bool? OrderCreditEvaluationIndicator { get { return _orderCreditEvaluationIndicator; } set { _orderCreditEvaluationIndicator = value; } }
        private Value<bool?> _orderMergedCreditReportIndicator;
        public bool? OrderMergedCreditReportIndicator { get { return _orderMergedCreditReportIndicator; } set { _orderMergedCreditReportIndicator = value; } }
        private Value<string> _orderMortgageInsurance;
        public string OrderMortgageInsurance { get { return _orderMortgageInsurance; } set { _orderMortgageInsurance = value; } }
        private Value<bool?> _orderRiskGradeEvaluationIndicator;
        public bool? OrderRiskGradeEvaluationIndicator { get { return _orderRiskGradeEvaluationIndicator; } set { _orderRiskGradeEvaluationIndicator = value; } }
        private Value<decimal?> _originalIntRate;
        public decimal? OriginalIntRate { get { return _originalIntRate; } set { _originalIntRate = value; } }
        private Value<string> _originateID;
        public string OriginateID { get { return _originateID; } set { _originateID = value; } }
        private Value<string> _paymentFrequency;
        public string PaymentFrequency { get { return _paymentFrequency; } set { _paymentFrequency = value; } }
        private Value<string> _paymentOption;
        public string PaymentOption { get { return _paymentOption; } set { _paymentOption = value; } }
        private Value<decimal?> _personIncomeForSelfEmployment1;
        public decimal? PersonIncomeForSelfEmployment1 { get { return _personIncomeForSelfEmployment1; } set { _personIncomeForSelfEmployment1 = value; } }
        private Value<decimal?> _personIncomeForSelfEmployment2;
        public decimal? PersonIncomeForSelfEmployment2 { get { return _personIncomeForSelfEmployment2; } set { _personIncomeForSelfEmployment2 = value; } }
        private Value<int?> _personPercentOfBusinessOwned1;
        public int? PersonPercentOfBusinessOwned1 { get { return _personPercentOfBusinessOwned1; } set { _personPercentOfBusinessOwned1 = value; } }
        private Value<int?> _personPercentOfBusinessOwned2;
        public int? PersonPercentOfBusinessOwned2 { get { return _personPercentOfBusinessOwned2; } set { _personPercentOfBusinessOwned2 = value; } }
        private Value<string> _premiumSource;
        public string PremiumSource { get { return _premiumSource; } set { _premiumSource = value; } }
        private Value<decimal?> _presentHousingExpense;
        public decimal? PresentHousingExpense { get { return _presentHousingExpense; } set { _presentHousingExpense = value; } }
        private Value<string> _processingPoint;
        public string ProcessingPoint { get { return _processingPoint; } set { _processingPoint = value; } }
        private Value<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        private Value<string> _purposeOfLoan;
        public string PurposeOfLoan { get { return _purposeOfLoan; } set { _purposeOfLoan = value; } }
        private Value<string> _renewalOption;
        public string RenewalOption { get { return _renewalOption; } set { _renewalOption = value; } }
        private Value<string> _renewalType;
        public string RenewalType { get { return _renewalType; } set { _renewalType = value; } }
        private Value<string> _requiredDocumentType;
        public string RequiredDocumentType { get { return _requiredDocumentType; } set { _requiredDocumentType = value; } }
        private Value<decimal?> _reserves;
        public decimal? Reserves { get { return _reserves; } set { _reserves = value; } }
        private Value<bool?> _retailLoanIndicator;
        public bool? RetailLoanIndicator { get { return _retailLoanIndicator; } set { _retailLoanIndicator = value; } }
        private Value<string> _riskClass;
        public string RiskClass { get { return _riskClass; } set { _riskClass = value; } }
        private Value<string> _riskGradeEvaluationType;
        public string RiskGradeEvaluationType { get { return _riskGradeEvaluationType; } set { _riskGradeEvaluationType = value; } }
        private Value<decimal?> _salesConcessions;
        public decimal? SalesConcessions { get { return _salesConcessions; } set { _salesConcessions = value; } }
        private Value<string> _secondaryFinancingType;
        public string SecondaryFinancingType { get { return _secondaryFinancingType; } set { _secondaryFinancingType = value; } }
        private Value<bool?> _secondTrustRefiIndicator;
        public bool? SecondTrustRefiIndicator { get { return _secondTrustRefiIndicator; } set { _secondTrustRefiIndicator = value; } }
        private Value<decimal?> _simulatedPITI;
        public decimal? SimulatedPITI { get { return _simulatedPITI; } set { _simulatedPITI = value; } }
        private Value<string> _sizeOfHousehold;
        public string SizeOfHousehold { get { return _sizeOfHousehold; } set { _sizeOfHousehold = value; } }
        private Value<string> _specialInstruction1;
        public string SpecialInstruction1 { get { return _specialInstruction1; } set { _specialInstruction1 = value; } }
        private Value<string> _specialInstruction2;
        public string SpecialInstruction2 { get { return _specialInstruction2; } set { _specialInstruction2 = value; } }
        private Value<string> _specialInstruction3;
        public string SpecialInstruction3 { get { return _specialInstruction3; } set { _specialInstruction3 = value; } }
        private Value<string> _specialInstruction4;
        public string SpecialInstruction4 { get { return _specialInstruction4; } set { _specialInstruction4 = value; } }
        private Value<string> _specialInstruction5;
        public string SpecialInstruction5 { get { return _specialInstruction5; } set { _specialInstruction5 = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<bool?> _transferLoanToConduitIndicator;
        public bool? TransferLoanToConduitIndicator { get { return _transferLoanToConduitIndicator; } set { _transferLoanToConduitIndicator = value; } }
        private Value<string> _yearsOfCoverage;
        public string YearsOfCoverage { get { return _yearsOfCoverage; } set { _yearsOfCoverage = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _affordableProduct.Dirty
                    || _alimonyAsIncomeReduction.Dirty
                    || _allMonthlyPayments.Dirty
                    || _allowsNegativeAmortizationIndicator.Dirty
                    || _amountOfFinancedMI.Dirty
                    || _aPNCity.Dirty
                    || _armsLengthTransactionIndicator.Dirty
                    || _borrowerQualifiesAsVeteranIndicator.Dirty
                    || _brokerOriginated.Dirty
                    || _buydownContributor.Dirty
                    || _condoClass.Dirty
                    || _convertibleFeeAmount.Dirty
                    || _convertibleFeePercent.Dirty
                    || _convertibleMaxRateAdjPercent.Dirty
                    || _convertibleMinRateAdjPercent.Dirty
                    || _county.Dirty
                    || _creditReportCompany.Dirty
                    || _financingConcessions.Dirty
                    || _freddieFiel11.Dirty
                    || _freddieFiel12.Dirty
                    || _freddieFiel13.Dirty
                    || _freddieFiel14.Dirty
                    || _freddieFiel15.Dirty
                    || _freddieField3.Dirty
                    || _freddieField7.Dirty
                    || _hELOCActualBalance.Dirty
                    || _hELOCCreditLimit.Dirty
                    || _id.Dirty
                    || _lenderAltPhone.Dirty
                    || _lenderRegistration.Dirty
                    || _loanProspectorID.Dirty
                    || _loanToConduitCode.Dirty
                    || _longLegalDescription.Dirty
                    || _lossCoverage.Dirty
                    || _lPKeyNumber.Dirty
                    || _mIRefundOption.Dirty
                    || _mortgageInsuranceCompany.Dirty
                    || _netPurchasePrice.Dirty
                    || _newConstructionType.Dirty
                    || _noAppraisalMAF.Dirty
                    || _nonOccupantNonHousingDebt.Dirty
                    || _nonOccupantPresentHE.Dirty
                    || _orderCreditEvaluationIndicator.Dirty
                    || _orderMergedCreditReportIndicator.Dirty
                    || _orderMortgageInsurance.Dirty
                    || _orderRiskGradeEvaluationIndicator.Dirty
                    || _originalIntRate.Dirty
                    || _originateID.Dirty
                    || _paymentFrequency.Dirty
                    || _paymentOption.Dirty
                    || _personIncomeForSelfEmployment1.Dirty
                    || _personIncomeForSelfEmployment2.Dirty
                    || _personPercentOfBusinessOwned1.Dirty
                    || _personPercentOfBusinessOwned2.Dirty
                    || _premiumSource.Dirty
                    || _presentHousingExpense.Dirty
                    || _processingPoint.Dirty
                    || _propertyType.Dirty
                    || _purposeOfLoan.Dirty
                    || _renewalOption.Dirty
                    || _renewalType.Dirty
                    || _requiredDocumentType.Dirty
                    || _reserves.Dirty
                    || _retailLoanIndicator.Dirty
                    || _riskClass.Dirty
                    || _riskGradeEvaluationType.Dirty
                    || _salesConcessions.Dirty
                    || _secondaryFinancingType.Dirty
                    || _secondTrustRefiIndicator.Dirty
                    || _simulatedPITI.Dirty
                    || _sizeOfHousehold.Dirty
                    || _specialInstruction1.Dirty
                    || _specialInstruction2.Dirty
                    || _specialInstruction3.Dirty
                    || _specialInstruction4.Dirty
                    || _specialInstruction5.Dirty
                    || _state.Dirty
                    || _transferLoanToConduitIndicator.Dirty
                    || _yearsOfCoverage.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _affordableProduct.Dirty = value;
                _alimonyAsIncomeReduction.Dirty = value;
                _allMonthlyPayments.Dirty = value;
                _allowsNegativeAmortizationIndicator.Dirty = value;
                _amountOfFinancedMI.Dirty = value;
                _aPNCity.Dirty = value;
                _armsLengthTransactionIndicator.Dirty = value;
                _borrowerQualifiesAsVeteranIndicator.Dirty = value;
                _brokerOriginated.Dirty = value;
                _buydownContributor.Dirty = value;
                _condoClass.Dirty = value;
                _convertibleFeeAmount.Dirty = value;
                _convertibleFeePercent.Dirty = value;
                _convertibleMaxRateAdjPercent.Dirty = value;
                _convertibleMinRateAdjPercent.Dirty = value;
                _county.Dirty = value;
                _creditReportCompany.Dirty = value;
                _financingConcessions.Dirty = value;
                _freddieFiel11.Dirty = value;
                _freddieFiel12.Dirty = value;
                _freddieFiel13.Dirty = value;
                _freddieFiel14.Dirty = value;
                _freddieFiel15.Dirty = value;
                _freddieField3.Dirty = value;
                _freddieField7.Dirty = value;
                _hELOCActualBalance.Dirty = value;
                _hELOCCreditLimit.Dirty = value;
                _id.Dirty = value;
                _lenderAltPhone.Dirty = value;
                _lenderRegistration.Dirty = value;
                _loanProspectorID.Dirty = value;
                _loanToConduitCode.Dirty = value;
                _longLegalDescription.Dirty = value;
                _lossCoverage.Dirty = value;
                _lPKeyNumber.Dirty = value;
                _mIRefundOption.Dirty = value;
                _mortgageInsuranceCompany.Dirty = value;
                _netPurchasePrice.Dirty = value;
                _newConstructionType.Dirty = value;
                _noAppraisalMAF.Dirty = value;
                _nonOccupantNonHousingDebt.Dirty = value;
                _nonOccupantPresentHE.Dirty = value;
                _orderCreditEvaluationIndicator.Dirty = value;
                _orderMergedCreditReportIndicator.Dirty = value;
                _orderMortgageInsurance.Dirty = value;
                _orderRiskGradeEvaluationIndicator.Dirty = value;
                _originalIntRate.Dirty = value;
                _originateID.Dirty = value;
                _paymentFrequency.Dirty = value;
                _paymentOption.Dirty = value;
                _personIncomeForSelfEmployment1.Dirty = value;
                _personIncomeForSelfEmployment2.Dirty = value;
                _personPercentOfBusinessOwned1.Dirty = value;
                _personPercentOfBusinessOwned2.Dirty = value;
                _premiumSource.Dirty = value;
                _presentHousingExpense.Dirty = value;
                _processingPoint.Dirty = value;
                _propertyType.Dirty = value;
                _purposeOfLoan.Dirty = value;
                _renewalOption.Dirty = value;
                _renewalType.Dirty = value;
                _requiredDocumentType.Dirty = value;
                _reserves.Dirty = value;
                _retailLoanIndicator.Dirty = value;
                _riskClass.Dirty = value;
                _riskGradeEvaluationType.Dirty = value;
                _salesConcessions.Dirty = value;
                _secondaryFinancingType.Dirty = value;
                _secondTrustRefiIndicator.Dirty = value;
                _simulatedPITI.Dirty = value;
                _sizeOfHousehold.Dirty = value;
                _specialInstruction1.Dirty = value;
                _specialInstruction2.Dirty = value;
                _specialInstruction3.Dirty = value;
                _specialInstruction4.Dirty = value;
                _specialInstruction5.Dirty = value;
                _state.Dirty = value;
                _transferLoanToConduitIndicator.Dirty = value;
                _yearsOfCoverage.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}