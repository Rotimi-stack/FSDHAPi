using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHAPi.Models
{
    public class Payload
    {
        public string AccountNumber { get; set; }
    }

    public class Banks
    {
        public string number { get; set; }
    }

    public class Funds
    {
        public string TransactionId { get; set; }
        public string PaymentReference { get; set; }
    }

    public class FundsTransfer
    {
        public string nameEnquiryRef { get; set; }
        public string destinationInstitutionCode { get; set; }
        public string beneficiaryAccountName { get; set; }
        public string beneficiaryAccountNumber { get; set; }
        public string beneficiaryBankVerificationNumber { get; set; }
        public string beneficiaryKYCLevel { get; set; }
        public string originatorAccountName { get; set; }
        public string originatorAccountNumber { get; set; }
        public string originatorAccountBranch { get; set; }
        public string originatorBankVerificationNumber { get; set; }
        public string paymentReference { get; set; }
        public string transactionAmount { get; set; }
        public string narration { get; set; }
    }

    public class TransactionHistory
    {
        public string accountNumber { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
    }

    public class TransferHistory
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Pagenumber { get; set; }
        public int PageSize { get; set; }
    }

    public class UpdateDynamicAccount
    {
        public string accountName { get; set; }
        public string bvn { get; set; }
        public string accountNumber { get; set; }
        public string collectionAccountNumber { get; set; }
        public string uniqueReference { get; set; }
        public DateTime validTill { get; set; }
        public Validfor validFor { get; set; }

    }

    public class CreateDynamicAccountPayload
    {
        public string accountName { get; set; }
        public string bvn { get; set; }
        public string accountNumber { get; set; }
        public string collectionAccountNumber { get; set; }
        public string uniqueReference { get; set; }
        public DateTime validTill { get; set; }
        public Validfor validFor { get; set; }
        public bool isOneTimePaymentAccount { get; set; }

    }

    public class GetDynamicAccount
    {
        public string AccountNumber { get; set; }
        public string version { get; set; }
    }

    public class GetDynamicAccountBVN
    {
        public string BVN { get; set; }
        public int Skip { get; set; }
        public int take { get; set; }
        public string version { get; set; }
    }

    public class GetAllStaticAccountBVN
    {
        public string AccountNumber { get; set; }
        public int Skip { get; set; }
        public int take { get; set; }
        public string version { get; set; }
    }

    public class GetDynamicAccountByAccountNum
    {
        public string BVN { get; set; }
        public int Skip { get; set; }
        public int take { get; set; }
        public string apiversion { get; set; }
    }

    public class GetUnAssignedDynamicAccount
    {
        public int Skip { get; set; }
        public int take { get; set; }
        public string apiversion { get; set; }
    }

    public class Validfor
        {
            public int years { get; set; }
            public string months { get; set; }
            public string days { get; set; }
            public string hours { get; set; }
            public string minutes { get; set; }
        }

    public class BVN
    {
        public string bvn { get; set; }
        public DateTime birthDate { get; set; }
    }

    public class GetAccountByBVN
    {
        public string bvn { get; set; }
    }

    public class Otp
    {
        public string OTP { get; set; }
        public string RecordReference { get; set; }
    }

    public class verifySingleBVN
    {
        public string bvn { get; set; }
        public string requestReference { get; set; }
    }

    public class verifySingleBVNdate
    {
        public string bvn { get; set; }
        public string requestReference { get; set; }
        public DateTime birthDate { get; set; }
    }

    public class ValidateBvnPayload
    {
        public string requestReference { get; set; }
        public string bvn { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
        public string gender { get; set; }
    }

    public class ErrorResponse
    {
        public string message { get; set; }
        public bool status { get; set; }
        public string statuscode { get; set; }
    }

}
