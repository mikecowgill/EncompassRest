using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Employment : IDirty
    {
        private Value<string> _addressCity;
        public string AddressCity { get { return _addressCity; } set { _addressCity = value; } }
        private Value<string> _addressPostalCode;
        public string AddressPostalCode { get { return _addressPostalCode; } set { _addressPostalCode = value; } }
        private Value<string> _addressState;
        public string AddressState { get { return _addressState; } set { _addressState = value; } }
        private Value<string> _addressStreetLine1;
        public string AddressStreetLine1 { get { return _addressStreetLine1; } set { _addressStreetLine1 = value; } }
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private Value<string> _attention;
        public string Attention { get { return _attention; } set { _attention = value; } }
        private Value<string> _badgeOrEmployeeID;
        public string BadgeOrEmployeeID { get { return _badgeOrEmployeeID; } set { _badgeOrEmployeeID = value; } }
        private Value<decimal?> _basePayAmount;
        public decimal? BasePayAmount { get { return _basePayAmount; } set { _basePayAmount = value; } }
        private Value<decimal?> _bonusAmount;
        public decimal? BonusAmount { get { return _bonusAmount; } set { _bonusAmount = value; } }
        private Value<string> _businessName;
        public string BusinessName { get { return _businessName; } set { _businessName = value; } }
        private Value<decimal?> _businessOwnedPercent;
        public decimal? BusinessOwnedPercent { get { return _businessOwnedPercent; } set { _businessOwnedPercent = value; } }
        private Value<string> _businessPhone;
        public string BusinessPhone { get { return _businessPhone; } set { _businessPhone = value; } }
        private Value<decimal?> _commissionsAmount;
        public decimal? CommissionsAmount { get { return _commissionsAmount; } set { _commissionsAmount = value; } }
        private Value<bool?> _currentEmploymentIndicator;
        public bool? CurrentEmploymentIndicator { get { return _currentEmploymentIndicator; } set { _currentEmploymentIndicator = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<string> _employerComments;
        public string EmployerComments { get { return _employerComments; } set { _employerComments = value; } }
        private Value<string> _employerName;
        public string EmployerName { get { return _employerName; } set { _employerName = value; } }
        private Value<DateTime?> _endDate;
        public DateTime? EndDate { get { return _endDate; } set { _endDate = value; } }
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _monthlyIncomeAmount;
        public int? MonthlyIncomeAmount { get { return _monthlyIncomeAmount; } set { _monthlyIncomeAmount = value; } }
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        private Value<decimal?> _otherAmount;
        public decimal? OtherAmount { get { return _otherAmount; } set { _otherAmount = value; } }
        private Value<decimal?> _overtimeAmount;
        public decimal? OvertimeAmount { get { return _overtimeAmount; } set { _overtimeAmount = value; } }
        private Value<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        private Value<string> _phoneNumber;
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        private Value<string> _positionDescription;
        public string PositionDescription { get { return _positionDescription; } set { _positionDescription = value; } }
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        private Value<bool?> _selfEmployedIndicator;
        public bool? SelfEmployedIndicator { get { return _selfEmployedIndicator; } set { _selfEmployedIndicator = value; } }
        private Value<DateTime?> _startDate;
        public DateTime? StartDate { get { return _startDate; } set { _startDate = value; } }
        private Value<int?> _timeInLineOfWorkMonths;
        public int? TimeInLineOfWorkMonths { get { return _timeInLineOfWorkMonths; } set { _timeInLineOfWorkMonths = value; } }
        private Value<int?> _timeInLineOfWorkYears;
        public int? TimeInLineOfWorkYears { get { return _timeInLineOfWorkYears; } set { _timeInLineOfWorkYears = value; } }
        private Value<int?> _timeOnJobTermMonths;
        public int? TimeOnJobTermMonths { get { return _timeOnJobTermMonths; } set { _timeOnJobTermMonths = value; } }
        private Value<int?> _timeOnJobTermYears;
        public int? TimeOnJobTermYears { get { return _timeOnJobTermYears; } set { _timeOnJobTermYears = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        private Value<DateTime?> _verificationRequestDate;
        public DateTime? VerificationRequestDate { get { return _verificationRequestDate; } set { _verificationRequestDate = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _addressCity.Dirty
                    || _addressPostalCode.Dirty
                    || _addressState.Dirty
                    || _addressStreetLine1.Dirty
                    || _altId.Dirty
                    || _attention.Dirty
                    || _badgeOrEmployeeID.Dirty
                    || _basePayAmount.Dirty
                    || _bonusAmount.Dirty
                    || _businessName.Dirty
                    || _businessOwnedPercent.Dirty
                    || _businessPhone.Dirty
                    || _commissionsAmount.Dirty
                    || _currentEmploymentIndicator.Dirty
                    || _email.Dirty
                    || _employerComments.Dirty
                    || _employerName.Dirty
                    || _endDate.Dirty
                    || _entityDeleted.Dirty
                    || _fax.Dirty
                    || _id.Dirty
                    || _monthlyIncomeAmount.Dirty
                    || _noLinkToDocTrackIndicator.Dirty
                    || _otherAmount.Dirty
                    || _overtimeAmount.Dirty
                    || _owner.Dirty
                    || _phoneNumber.Dirty
                    || _positionDescription.Dirty
                    || _printAttachmentIndicator.Dirty
                    || _printUserNameIndicator.Dirty
                    || _selfEmployedIndicator.Dirty
                    || _startDate.Dirty
                    || _timeInLineOfWorkMonths.Dirty
                    || _timeInLineOfWorkYears.Dirty
                    || _timeOnJobTermMonths.Dirty
                    || _timeOnJobTermYears.Dirty
                    || _title.Dirty
                    || _titleFax.Dirty
                    || _titlePhone.Dirty
                    || _verificationRequestDate.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _addressCity.Dirty = value;
                _addressPostalCode.Dirty = value;
                _addressState.Dirty = value;
                _addressStreetLine1.Dirty = value;
                _altId.Dirty = value;
                _attention.Dirty = value;
                _badgeOrEmployeeID.Dirty = value;
                _basePayAmount.Dirty = value;
                _bonusAmount.Dirty = value;
                _businessName.Dirty = value;
                _businessOwnedPercent.Dirty = value;
                _businessPhone.Dirty = value;
                _commissionsAmount.Dirty = value;
                _currentEmploymentIndicator.Dirty = value;
                _email.Dirty = value;
                _employerComments.Dirty = value;
                _employerName.Dirty = value;
                _endDate.Dirty = value;
                _entityDeleted.Dirty = value;
                _fax.Dirty = value;
                _id.Dirty = value;
                _monthlyIncomeAmount.Dirty = value;
                _noLinkToDocTrackIndicator.Dirty = value;
                _otherAmount.Dirty = value;
                _overtimeAmount.Dirty = value;
                _owner.Dirty = value;
                _phoneNumber.Dirty = value;
                _positionDescription.Dirty = value;
                _printAttachmentIndicator.Dirty = value;
                _printUserNameIndicator.Dirty = value;
                _selfEmployedIndicator.Dirty = value;
                _startDate.Dirty = value;
                _timeInLineOfWorkMonths.Dirty = value;
                _timeInLineOfWorkYears.Dirty = value;
                _timeOnJobTermMonths.Dirty = value;
                _timeOnJobTermYears.Dirty = value;
                _title.Dirty = value;
                _titleFax.Dirty = value;
                _titlePhone.Dirty = value;
                _verificationRequestDate.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}