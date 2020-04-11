using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient ;
using Salary;

    public class ClsTax
    {
        private SqlCommand Cmd = new SqlCommand();

        public DataTable GetTax(short FiscalYear)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetTax]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_FiscalYear", FiscalYear);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }

    public DataTable GetDisketeGroups( )
    {
        try
        {
            Cmd.Parameters.Clear();
            Cmd.CommandText = "SELECT En_NameKargah,id_company,csv_Group_Folder FROM pr.diskete";
            Cmd.CommandType = CommandType.Text;
            return Global.DB.FillDataTable(Cmd);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Save(short FiscalYear,DataTable Items)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspSaveTax]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_FiscalYear", FiscalYear);
                Cmd.Parameters.AddWithValue("Items", Items);
                return Global.DB.ExecuteNonQuery(Cmd);

            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
    }
    
        public DataSet GetListTotal(short IDMonthOfSalary, byte IDCompany, string IDKargah)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetTaxListForDisketTotal]";

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("IDMonthOfSalary", IDMonthOfSalary);
                Cmd.Parameters.AddWithValue("IDCompany", IDCompany);
                Cmd.Parameters.AddWithValue("IDKargah", IDKargah);
                return Global.DB.FillDataSet(Cmd);
        }
            catch (Exception ex)
            {
                throw ex ;
            }
        }

        public DataSet GetList(short IDMonthOfSalary, byte IDCompany, long IDKargah)
    {
        try
        {
            Cmd.Parameters.Clear();
            Cmd.CommandText = "[Sl].[UspGetTaxListForDisket]";

            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("IDMonthOfSalary", IDMonthOfSalary);
            Cmd.Parameters.AddWithValue("IDCompany", IDCompany);
            Cmd.Parameters.AddWithValue("IDKargah", IDKargah);
            return Global.DB.FillDataSet(Cmd);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public    class CsvGenerator
    {
        /// <summary>
        /// برای ساخت فایل WP.TXT
        /// </summary>
        /// <param name="nationality">ملیت</param>
        /// <param name="isNewRecord">آیا رکورد جدید است</param>
        /// <param name="nationalCode">کد ملی</param>
        /// <param name="name">نام</param>
        /// <param name="Family">نام خانوادگی</param>
        /// <param name="EdDegree">مدرک تحصیلی</param>
        /// <param name="position">سمت شغلی</param>
        /// <param name="InsurType">نوع بیمه</param>
        /// <param name="dateOfEnrol">تاریخ شروع قرارداد</param>
        /// <param name="empType">نوع استخدام</param>
        /// <param name="placeOfContract">محل استخدام</param>
        /// <param name="workpStatus">وضعیت محل خدمت</param>
        /// <param name="typeOfContract">نوع قرارداد</param>
        /// <param name="empStatus">وضعیت کارمند</param>
        /// <param name="country">کد کشور</param>
        /// <param name="empCode">شناسه کارمند</param>
        /// <param name="insurName">نام بیمه</param>
        /// <param name="insurNumber">شماره بیمه</param>
        /// <param name="homeZipCode">کدپستی محل سکونت</param>
        /// <param name="homeAddress">آدرس محل سکونت</param>
        /// <param name="dateOfEndContract">تاریخ پایان کار</param>
        /// <param name="cellphone">شماره موبایل</param>
        /// <param name="emailAddress">آدرس ایمیل</param>
        /// <returns></returns>
        public string Personel(Nationality nationality, Boolean isNewRecord, string nationalCode, string name, string Family,
                               EducationalDegree EdDegree, string position, InssuranceType InsurType, int dateOfEnrol,
                               EmploymentType empType, string placeOfContract, WorkPlaceStatus workpStatus,
                               TypeOfContract typeOfContract, EmployeeStatus empStatus, Countries country = 0,
                               string empCode = "", string insurName = "", string insurNumber = "", string homeZipCode = "",
                               string homeAddress = "", int? dateOfEndContract = null, long? cellphone = null, string emailAddress = "")
        {
            var str = "";
            str += "," + nationality;
            str += "," + (isNewRecord ? "1" : "2");
            str += "," + nationalCode;
            str += "," + name;
            str += "," + Family;
            str += "," + country;
            str += "," + empCode;
            str += "," + EdDegree;
            str += "," + position;
            str += "," + InsurType;
            str += "," + insurName;
            str += "," + insurNumber;
            str += "," + homeZipCode;
            str += "," + homeAddress;
            str += "," + dateOfEnrol;
            str += "," + empType;
            str += "," + placeOfContract;
            str += "," + workpStatus;
            str += "," + typeOfContract;
            str += "," + dateOfEndContract;
            str += "," + empStatus;
            str += "," + cellphone;
            str += "," + emailAddress;

            str += (char)13 + (char)10;
            return str;
        }


        /// <summary>
        /// برای ساخت فایل WKYYYYMM.TXT
        /// </summary>
        /// <param name="nationalCode">کد ملی</param>
        /// <param name="typeOfPayment">نوع پرداخت</param>
        /// <param name="WorkMonthsThisYear">تعداد ماههای کارکرد واقعی از ابتدای سال</param>
        /// <param name="dateOfWorkStart">تاریخ شروع به کار</param>
        /// <param name="empStatus">وضعیت کارمند</param>
        /// <param name="workPlaceStatus">وضعیت محل خدمت</param>
        /// <param name="Tax">مالیات متعلقه حقوق و دستمزد مستمر نقدی</param>
        /// <param name="totalTax">جمع خالص مالیات متعلقه سال جاری</param>
        /// <param name="isLastMonth">آیا این ماه آخر فعالیت حقوق بگیر است؟</param>
        /// <param name="dateOfWorkEnd">تاریخ پایان کار</param>
        /// <param name="netSalary">ناخالص حقوق و دستمزد</param>
        /// <param name="paymentWithoutTax">پرداختهای مستمر معوق</param>
        /// <param name="housingType">نوع مسکن</param>
        /// <param name="houseRentCost">مبلغ کسر شده از حقوق کارمند بابت مسکن ماه جاری</param>
        /// <param name="vehicleType">نوع وسیله نقلیه</param>
        /// <param name="vehicleRentCost">مبلغ کسر شده از حقوق کارمند بابت وسیله نقلیه ماه جاری</param>
        /// <param name="nonCashBenefits">پرداخت مزایای غیرنقدی ماه جاری</param>
        /// <param name="healthCareCost">هزینه های درمانی موضوع 137</param>
        /// <param name="inssuranceCost">حق بیمه پرداختی موضوع 137</param>
        /// <param name="hosusingLoan">تسهیلات اعتباری مسکن از بانکها</param>
        /// <param name="otherExceptions">سایر معافیت ها</param>
        /// <param name="extraHoursPayments">ناخالص اضافه کاری ماه جاری</param>
        /// <param name="otherPayments">سایر پرداختهای غیرمستمر ماه جاری</param>
        /// <param name="bounus">پاداشهای موردی ماه جاری</param>
        /// <param name="delayedPayment">پرداختهای غیرمستمر نقدی معوقه ماه جاری</param>
        /// <param name="nonRecurringDeductions">کسر میشود:معافیتهای غیر مستمر نقدی</param>
        /// <param name="nonRecurringBonus">پرداخت مزایای غیر مستمر غیر نقدی ماه جاری</param>
        /// <param name="newYearReward">عیدی و مزایای پایان سال</param>
        /// <param name="leaveRedemption">بازخرید مرخصی و بازخرید سنوات</param>
        /// <param name="deductionException">کسر میشود:معافیت</param>
        /// <param name="freeZoneDeduction">معافیت مربوط به مناطق آزاد تجاری</param>
        /// <param name="overTaxingDeduction">معافیت موضوع قانون اجتناب از اخذ مالیات مضاعف</param>
        /// <returns></returns>
        public string SalaryDetail(string nationalCode, TypeOfPayment typeOfPayment, int WorkMonthsThisYear, int dateOfWorkStart,
            EmployeeStatus empStatus, WorkPlaceStatus workPlaceStatus, int Tax, int totalTax, bool isLastMonth = false,
            int? dateOfWorkEnd = null, int? netSalary = null, int? paymentWithoutTax = null, HousingType housingType = 0,
            int? houseRentCost = null, VehicleType vehicleType = 0, int? vehicleRentCost = null, int? nonCashBenefits = null,
            int? healthCareCost = null, int? inssuranceCost = null, int? hosusingLoan = null, int? otherExceptions = null,
            int? extraHoursPayments = null, int? otherPayments = null, int? bounus = null, int? delayedPayment = null,
            int? nonRecurringDeductions = null, int? nonRecurringBonus = null, int? newYearReward = null, int? leaveRedemption = null,
            int? deductionException = null, int? freeZoneDeduction = null, int? overTaxingDeduction = null)
        {
            string str = "";
            str += "," + nationalCode;
            str += "," + typeOfPayment;
            str += "," + WorkMonthsThisYear;
            str += "," + (isLastMonth ? 1 : 0);
            str += "," + Currencies.IRL;
            str += "," + 1;//nerkhe tasrie arz, har yek rial yek rial ast- nerkhe arz ra be rial mizanim inja
            str += "," + dateOfWorkStart;
            str += "," + dateOfWorkEnd;
            str += "," + empStatus;
            str += "," + workPlaceStatus;
            str += "," + netSalary;
            str += "," + paymentWithoutTax;
            str += "," + housingType;
            str += "," + houseRentCost;
            str += "," + vehicleType;
            str += "," + vehicleRentCost;
            str += "," + nonCashBenefits;
            str += "," + healthCareCost;
            str += "," + inssuranceCost;
            str += "," + hosusingLoan;
            str += "," + otherExceptions;
            str += "," + extraHoursPayments;
            str += "," + otherPayments;
            str += "," + bounus;
            str += "," + delayedPayment;
            str += "," + nonRecurringDeductions;
            str += "," + nonRecurringBonus;
            str += "," + newYearReward;
            str += "," + leaveRedemption;
            str += "," + deductionException;
            str += "," + freeZoneDeduction;
            str += "," + overTaxingDeduction;

            str += "," + Tax;
            str += "," + totalTax;
            str += (char)13 + (char)10;
            return str;
        }


        /// <summary>
        /// برای ساخت فایل WHYYYYMM.TXT
        /// </summary>
        /// <param name="year">سال</param>
        /// <param name="month">ماه</param>
        /// <param name="currentMonthDebt">بدهی مالیاتی ماه جاری</param>
        /// <param name="lastMonthDebt">بدهی مالیاتی ماه گذشته</param>
        /// <param name="dateOfRegistrationInJournal">تاریخ ثبت در دفتر روزنامه</param>
        /// <param name="typeOfPayment">نحوه پرداخت</param>
        /// <param name="checkSerialNumber">شماره سریال چک</param>
        /// <param name="checkDueDate">تاریخ چک</param>
        /// <param name="bankName">کد نام بانک</param>
        /// <param name="bankBranchName">نام شعبه</param>
        /// <param name="bankAccountNumber">شماره حساب</param>
        /// <param name="checkAmount">مبلغ پرداختی/مبلغ چک</param>
        /// <param name="treasuryPaymentDate">تاریخ پرداخت خزانه</param>
        /// <param name="treasuryPaymentAmount">مبلغ پرداختی خزانه</param>
        /// <returns></returns>
        public string SalarySummary(int dateOfRegistrationInJournal, int? year = null, int? month = null, long? currentMonthDebt = null, long? lastMonthDebt = null,
            TypeOfContract typeOfPayment = 0, string checkSerialNumber = null, int? checkDueDate = null, BankName? bankName = null, string bankBranchName = null,
            int? bankAccountNumber = null, int? checkAmount = null, int? treasuryPaymentDate = null, int? treasuryPaymentAmount = null)
        {
            string str = "";
            str += "," + year;
            str += "," + String.Format("{0:00}", month.ToString());
            str += "," + currentMonthDebt;
            str += "," + lastMonthDebt;
            str += "," + dateOfRegistrationInJournal;
            str += "," + typeOfPayment;
            str += "," + checkSerialNumber;
            str += "," + checkDueDate;
            str += "," + bankName;
            str += "," + bankBranchName;
            str += "," + bankAccountNumber;
            str += "," + checkAmount;
            str += "," + treasuryPaymentDate;
            str += "," + treasuryPaymentAmount;
            str += (char)13 + (char)10;
            return str;
        }
    }





    public enum PersonType
    {
        NaturalPerson = 1,
        LegalPerson = 2
    }

    public enum Nationality
    {
        Iranian = 1,
        Foreigner = 2
    }

    public enum Countries
    {
        Afghanistan = 14,
        UAE = 19
    }

    public enum EducationalDegree
    {
        LessThanDiploma = 1,
        Diploma = 2,
        Associate = 3,
        Bachelor = 4,
        Master = 5,
        PHD = 6,
        Doctorate = 7

    }

    public enum InssuranceType
    {
        MedicalServices = 1,
        SocialSecurity = 2,
        HealthInsurance = 3,
        Other = 4,
        None = 5
    }

    public enum EmploymentType
    {
        ShorttermContractual = 1,
        Company = 2,
        Permanent = 3,
        Longtermcontractual = 4,
        OnMission = 5,
        Other = 6
    }

    public enum WorkPlaceStatus
    {
        Normal = 1,
        LessDeveloped = 2,
        CommercialFreeZones = 3
    }

    public enum TypeOfContract
    {
        FullTime = 1,
        PartTime = 2,
        Hourly = 3,
        Contractor = 4,
        Temporary = 5
    }

    public enum EmployeeStatus
    {
        Normal = 1,
        HandicappedInWar = 2,
        MartyrsChildren = 3,
        FormerPow = 4,
        ArmedForces = 5,
        OtherObjectsToClause14Article91 = 6,
        ForeignNationalsSubjectToDoubleTaxtationAvoidance = 7
    }

    public enum PaidType
    {
        Rial = 1,
        ForeignCurrency = 2,
        RialAndForeignCurrency = 3
    }

    public enum HousingType
    {
        none = 1,
        WithFurniture = 2,
        WithoutFurniture = 3
    }

    public enum VehicleType
    {
        None = 1,
        WithDriver = 2,
        WithOutDriver = 3
    }

    public enum Currencies
    {
        AFG = 6,
        IRL = 85,
        USD = 41
    }

    public enum TypeOfPayment
    {
        PersonalCheck = 1,
        PaymentCard = 2,
        BankTransfer = 3,
        PromissoryNote = 4,
        CertifiedCheck = 5,
        CashDeposit = 6,
        Treasury = 7,
        NoPayment = 8
    }
    public enum MonthOfDeclare
    {
        Farvardin = 1,
        Ordibehesht = 2,
        Khordad = 3,
        Tir = 4,
        Mordad = 5,
        Shahrivar = 6,
        Mehr = 7,
        Agan = 8,
        Azar = 9,
        Day = 10,
        Bahman = 11,
        Esfand = 12
    }

    public enum BankName
    {
        BanSar = 1,
        BcdEVE = 2,
        BCentr = 3,
        BCity = 4,
        BDay = 5,
        BEDIRA = 6,
        BEGHTE = 7,
        BGharz = 8,
        BHekma = 9,
        BINDMI = 10,
        BKARAF = 11,
        BKESHA = 12,
        BMASKA = 13,
        BMELLA = 14,
        BMELLI = 15,
        BPARSI = 16,
        BPASAR = 17,
        BPOST = 18,
        BREFAH = 19,
        BSADER = 20,
        BSAMAN = 21,
        BSARMA = 22,
        BSEPAH = 23,
        BSINA = 24,
        BTAT = 25,
        BTEJAR = 26,
        BTOURI = 27,
        BRESALA = 28
    }



}







