using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// LockRequest
    /// </summary>
    public sealed partial class LockRequest : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _id { get; set; }
        private DirtyValue<string?>? _requestType { get; set; }
        private DirtyValue<string?>? _requestStatus { get; set; }
        private DirtyValue<string?>? _lockStatus { get; set; }
        private DirtyValue<int?>? _lockNumberOfDays { get; set; }
        private DirtyValue<string?>? _lockExpirationDate { get; set; }
        private DirtyValue<RequestedBy?>? _requestedBy { get; set; }
        private DirtyValue<DateTime?>? _requestedDate { get; set; }
        private DirtyValue<DateTime?>? _fulfilledDate { get; set; }
        private DirtyValue<FulfilledBy?>? _fulfilledBy { get; set; }
        private DirtyValue<string?>? _investor { get; set; }
        private DirtyValue<DateTime?>? _investorDeliveryDate { get; set; }
        private DirtyValue<List<string>?>? _requestIndicators { get; set; }
        private DirtyValue<ParentLockRequest?>? _parentLockRequest { get; set; }
        private DirtyValue<string?>? _investorCommitment { get; set; }
        private DirtyValue<Request?>? _lockRequest { get; set; }
        private DirtyValue<BuySide?>? _buySide { get; set; }
        private DirtyValue<SellSide?>? _sellSide { get; set; }
        private DirtyValue<Comparison?>? _comparison { get; set; }


        public string? id { get; set; }
        public string? requestType { get; set; }
        public string? requestStatus { get; set; }
        public string? lockStatus { get; set; }
        public int? lockNumberOfDays { get; set; }
        public string? lockExpirationDate { get; set; }
        public RequestedBy requestedBy { get; set; }
        public DateTime? requestedDate { get; set; }
        public DateTime? fulfilledDate { get; set; }
        public FulfilledBy fulfilledBy { get; set; }
        public string? investor { get; set; }
        public DateTime? investorDeliveryDate { get; set; }
        public List<string>? requestIndicators { get; set; }
        public ParentLockRequest? parentLockRequest { get; set; }
        public string? investorCommitment { get; set; }
        public Request? lockRequest { get; set; }
        public BuySide? buySide { get; set; }
        public SellSide? sellSide { get; set; }
        public Comparison? comparison { get; set; }
    }

    public sealed partial class RequestedBy : DirtyExtensibleObject
    {
        private DirtyValue<string?>? entityId { get; set; }
        private DirtyValue<string?>? entityType { get; set; }
        private DirtyValue<string?>? entityName { get; set; }
        private DirtyValue<string?>? entityUri { get; set; }


        private DirtyValue<string?>? entityId { get; set; }
        private DirtyValue<string?>? entityType { get; set; }
        private DirtyValue<string?>? entityName { get; set; }
        private DirtyValue<string?>? entityUri { get; set; }
    }

    public sealed partial class FulfilledBy : DirtyExtensibleObject
    {
        private DirtyValue<string?>? entityId { get; set; }
        private DirtyValue<string?>? entityType { get; set; }
        private DirtyValue<string?>? entityName { get; set; }
        private DirtyValue<string?>? entityUri { get; set; }


        private DirtyValue<string?>? entityId { get; set; }
        private DirtyValue<string?>? entityType { get; set; }
        private DirtyValue<string?>? entityName { get; set; }
        private DirtyValue<string?>? entityUri { get; set; }
    }

    public sealed partial class ParentLockRequest : DirtyExtensibleObject
    {
        private DirtyValue<string?>? requestType { get; set; }
        private DirtyValue<string?>? lockStatus { get; set; }
        private DirtyValue<string?>? entityId { get; set; }
        private DirtyValue<string?>? entityType { get; set; }
        private DirtyValue<string?>? entityUri { get; set; }


        private DirtyValue<string?>? requestType { get; set; }
        private DirtyValue<string?>? lockStatus { get; set; }
        private DirtyValue<string?>? entityId { get; set; }
        private DirtyValue<string?>? entityType { get; set; }
        private DirtyValue<string?>? entityUri { get; set; }
    }

    public sealed partial class Adjustment : DirtyExtensibleObject
    {
        private DirtyValue<string?>? adjustmentType { get; set; }
        private DirtyValue<string?>? description { get; set; }
        private DirtyValue<string?>? priceAdjustmentType { get; set; }
        public decimal adjustment { get; set; }


        private DirtyValue<string?>? adjustmentType { get; set; }
        private DirtyValue<string?>? description { get; set; }
        private DirtyValue<string?>? priceAdjustmentType { get; set; }
        public decimal adjustment { get; set; }
    }

    public sealed partial class Request : DirtyExtensibleObject
    {
        public decimal expectedNetPrice { get; set; }
        public bool onrpEligible { get; set; }
        public bool onrpLock { get; set; }
        public bool hedging { get; set; }
        private DirtyValue<DateTime?>? fulfilledDate { get; set; }
        public bool isDeliveryType { get; set; }
        public bool isCancelled { get; set; }
        private DirtyValue<string?>? rateStatus { get; set; }
        public bool requestPending { get; set; }
        public bool extensionRequestPending { get; set; }
        public bool cancellationRequestPending { get; set; }
        public bool reLockRequestPending { get; set; }
        private DirtyValue<int?>? lockNumberOfDays { get; set; }
        private DirtyValue<string?>? lockExpirationDate { get; set; }
        private DirtyValue<string?>? lockDate { get; set; }
        public decimal baseRate { get; set; }
        public List<Adjustment> adjustments { get; set; }
        public decimal netRate { get; set; }
        public decimal basePrice { get; set; }
        public decimal totalPriceAdjustments { get; set; }
        private DirtyValue<string?>? loanProgram { get; set; }


        public decimal expectedNetPrice { get; set; }
        public bool onrpEligible { get; set; }
        public bool onrpLock { get; set; }
        public bool hedging { get; set; }
        private DirtyValue<DateTime?>? fulfilledDate { get; set; }
        public bool isDeliveryType { get; set; }
        public bool isCancelled { get; set; }
        private DirtyValue<string?>? rateStatus { get; set; }
        public bool requestPending { get; set; }
        public bool extensionRequestPending { get; set; }
        public bool cancellationRequestPending { get; set; }
        public bool reLockRequestPending { get; set; }
        private DirtyValue<int?>? lockNumberOfDays { get; set; }
        private DirtyValue<string?>? lockExpirationDate { get; set; }
        private DirtyValue<string?>? lockDate { get; set; }
        public decimal baseRate { get; set; }
        public List<Adjustment> adjustments { get; set; }
        public decimal netRate { get; set; }
        public decimal basePrice { get; set; }
        public decimal totalPriceAdjustments { get; set; }
        private DirtyValue<string?>? loanProgram { get; set; }
    }

    public sealed partial class BuySide : DirtyExtensibleObject
    {
        private DirtyValue<string?>? requestedBy { get; set; }
        public bool onrpEligible { get; set; }
        private DirtyValue<string?>? branchApprovalDate { get; set; }
        private DirtyValue<string?>? branchApprovedby { get; set; }
        public decimal branchPrice { get; set; }
        public decimal profitMarginAdjustedBuyPrice { get; set; }
        private DirtyValue<string?>? reasonforBranchApproval { get; set; }
        public decimal totalBuyPrice { get; set; }
        public decimal totalPrice { get; set; }
        private DirtyValue<string?>? rateSheetId { get; set; }
        private DirtyValue<string?>? lastRateSetDate { get; set; }
        private DirtyValue<int?>? lockNumberOfDays { get; set; }
        private DirtyValue<string?>? lockExpirationDate { get; set; }
        private DirtyValue<string?>? lockDate { get; set; }
        public decimal baseRate { get; set; }
        public List<Adjustment> adjustments { get; set; }
        public decimal netRate { get; set; }
        public decimal basePrice { get; set; }
        public decimal totalPriceAdjustments { get; set; }
        public decimal netPrice { get; set; }
        private DirtyValue<string?>? loanProgram { get; set; }


        private DirtyValue<string?>? requestedBy { get; set; }
        public bool onrpEligible { get; set; }
        private DirtyValue<string?>? branchApprovalDate { get; set; }
        private DirtyValue<string?>? branchApprovedby { get; set; }
        public decimal branchPrice { get; set; }
        public decimal profitMarginAdjustedBuyPrice { get; set; }
        private DirtyValue<string?>? reasonforBranchApproval { get; set; }
        public decimal totalBuyPrice { get; set; }
        public decimal totalPrice { get; set; }
        private DirtyValue<string?>? rateSheetId { get; set; }
        private DirtyValue<string?>? lastRateSetDate { get; set; }
        private DirtyValue<int?>? lockNumberOfDays { get; set; }
        private DirtyValue<string?>? lockExpirationDate { get; set; }
        private DirtyValue<string?>? lockDate { get; set; }
        public decimal baseRate { get; set; }
        public List<Adjustment> adjustments { get; set; }
        public decimal netRate { get; set; }
        public decimal basePrice { get; set; }
        public decimal totalPriceAdjustments { get; set; }
        public decimal netPrice { get; set; }
        private DirtyValue<string?>? loanProgram { get; set; }
    }

    public sealed partial class SellSide : DirtyExtensibleObject
    {
        private DirtyValue<string?>? requestedBy { get; set; }
        public Investor investor { get; set; }
        public decimal diffAmount { get; set; }
        public decimal diffPrice { get; set; }
        public decimal netAmount { get; set; }
        private DirtyValue<string?>? servicingType { get; set; }
        public decimal discountYsp { get; set; }
        public decimal gainLossPercentage { get; set; }
        public decimal gainLossPrice { get; set; }
        public decimal gainLossTotalPrice { get; set; }
        private DirtyValue<string?>? rateSheetId { get; set; }
        private DirtyValue<string?>? lastRateSetDate { get; set; }
        private DirtyValue<int?>? lockNumberOfDays { get; set; }
        private DirtyValue<string?>? lockExpirationDate { get; set; }
        private DirtyValue<string?>? lockDate { get; set; }
        public decimal baseRate { get; set; }
        public decimal netRate { get; set; }
        public decimal basePrice { get; set; }
        public decimal netPrice { get; set; }
        private DirtyValue<string?>? loanProgram { get; set; }



        private DirtyValue<string?>? requestedBy { get; set; }
        public Investor investor { get; set; }
        public decimal diffAmount { get; set; }
        public decimal diffPrice { get; set; }
        public decimal netAmount { get; set; }
        private DirtyValue<string?>? servicingType { get; set; }
        public decimal discountYsp { get; set; }
        public decimal gainLossPercentage { get; set; }
        public decimal gainLossPrice { get; set; }
        public decimal gainLossTotalPrice { get; set; }
        private DirtyValue<string?>? rateSheetId { get; set; }
        private DirtyValue<string?>? lastRateSetDate { get; set; }
        private DirtyValue<int?>? lockNumberOfDays { get; set; }
        private DirtyValue<string?>? lockExpirationDate { get; set; }
        private DirtyValue<string?>? lockDate { get; set; }
        public decimal baseRate { get; set; }
        public decimal netRate { get; set; }
        public decimal basePrice { get; set; }
        public decimal netPrice { get; set; }
        private DirtyValue<string?>? loanProgram { get; set; }
    }


    public sealed partial class Investor : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?>? lockedDate { get; set; }
        private DirtyValue<string?>? deliveryDate { get; set; }
        private DirtyValue<string?>? targetDeliveryDate { get; set; }
        private DirtyValue<string?>? name { get; set; }
        private DirtyValue<string?>? contact { get; set; }
        private DirtyValue<string?>? phone { get; set; }
        private DirtyValue<string?>? email { get; set; }
        private DirtyValue<string?>? city { get; set; }
        private DirtyValue<string?>? state { get; set; }
        private DirtyValue<string?>? postalCode { get; set; }
        private DirtyValue<string?>? website { get; set; }
        private DirtyValue<string?>? lockType { get; set; }
        private DirtyValue<string?>? status { get; set; }
        private DirtyValue<string?>? statusDate { get; set; }
        private DirtyValue<string?>? commitment { get; set; }



        private DirtyValue<DateTime?>? lockedDate { get; set; }
        private DirtyValue<string?>? deliveryDate { get; set; }
        private DirtyValue<string?>? targetDeliveryDate { get; set; }
        private DirtyValue<string?>? name { get; set; }
        private DirtyValue<string?>? contact { get; set; }
        private DirtyValue<string?>? phone { get; set; }
        private DirtyValue<string?>? email { get; set; }
        private DirtyValue<string?>? city { get; set; }
        private DirtyValue<string?>? state { get; set; }
        private DirtyValue<string?>? postalCode { get; set; }
        private DirtyValue<string?>? website { get; set; }
        private DirtyValue<string?>? lockType { get; set; }
        private DirtyValue<string?>? status { get; set; }
        private DirtyValue<string?>? statusDate { get; set; }
        private DirtyValue<string?>? commitment { get; set; }
    }

    public sealed partial class Comparison : DirtyExtensibleObject
    {
        public decimal gainLossPercentage { get; set; }
        public decimal gainLossPrice { get; set; }


        public decimal gainLossPercentage { get; set; }
        public decimal gainLossPrice { get; set; }
    }

}