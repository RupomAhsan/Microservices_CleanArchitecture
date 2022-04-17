using CleanArchitecture.Utility.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Enumerations
{
    public enum LookupMasterEnum
    {
        [LocalizedDescription("Car Make")]
        [LocalizedDescriptionValue("Make")]
        Make,

        [LocalizedDescription("Car Model")]
        [LocalizedDescriptionValue("Model")]
        Model,

        [LocalizedDescription("Car Variant")]
        [LocalizedDescriptionValue("Variant")]
        Variant,

        [LocalizedDescription("Car Color")]
        [LocalizedDescriptionValue("CarColor")]
        CarColor,

        [LocalizedDescription("Owner Type")]
        [LocalizedDescriptionValue("OwnerType")]
        OwnerType,

        [LocalizedDescription("Address Type")]
        [LocalizedDescriptionValue("AddressType")]
        AddressType,

        [LocalizedDescription("Contact Type")]
        [LocalizedDescriptionValue("ContactType")]
        ContactType,

        [LocalizedDescription("Transaction Type")]
        [LocalizedDescriptionValue("TransactionType")]
        TransactionType,

        [LocalizedDescription("Transaction SubType")]
        [LocalizedDescriptionValue("TransactionSubType")]
        TransactionSubType,

        [LocalizedDescription("TransactionSource")]
        [LocalizedDescriptionValue("TransactionSource")]
        TransactionSource,

        [LocalizedDescription("TransactionStatus")]
        [LocalizedDescriptionValue("TransactionStatus")]
        TransactionStatus,

        [LocalizedDescription("Wallet Type")]
        [LocalizedDescriptionValue("WalletType")]
        WalletType,

        [LocalizedDescription("Package")]
        [LocalizedDescriptionValue("Package")]
        Package,

        [LocalizedDescription("Rental Type")]
        [LocalizedDescriptionValue("RentalType")]
        RentalType,

        [LocalizedDescription("Zone")]
        [LocalizedDescriptionValue("Zone")]
        Zone,

        [LocalizedDescription("Location Type")]
        [LocalizedDescriptionValue("LocationType")]
        LocationType,

        [LocalizedDescription("Voucher Type")]
        [LocalizedDescriptionValue("VoucherType")]
        VoucherType,

        [LocalizedDescription("Redemption Type")]
        [LocalizedDescriptionValue("RedemptionType")]
        RedemptionType,

        [LocalizedDescription("Car Body Type")]
        [LocalizedDescriptionValue("CarBodyType")]
        CarBodyType,

        [LocalizedDescription("AC Status")]
        [LocalizedDescriptionValue("ACStatus")]
        ACStatus,

        [LocalizedDescription("Ride Status")]
        [LocalizedDescriptionValue("RideStatus")]
        RideStatus,

        [LocalizedDescription("DocumentStore")]
        [LocalizedDescriptionValue("Document Store")]
        DocumentStore,

        [LocalizedDescription("File Mime Type")]
        [LocalizedDescriptionValue("FileMimeType")]
        FileMimeType,

        [LocalizedDescription("File Extension")]
        [LocalizedDescriptionValue("FileExtension")]
        FileExtension,

        [LocalizedDescription("File Size Metric")]
        [LocalizedDescriptionValue("FileSizeMetric")]
        FileSizeMetric,

        [LocalizedDescription("File Size Metric")]
        [LocalizedDescriptionValue("FileSizeMetric")]
        DistanceMetric,
        [LocalizedDescription("File Size Metric")]
        [LocalizedDescriptionValue("FileSizeMetric")]
        ReedemptionType,
        [LocalizedDescription("File Size Metric")]
        [LocalizedDescriptionValue("FileSizeMetric")]
        CabOwnershipType,
        [LocalizedDescription("File Size Metric")]
        [LocalizedDescriptionValue("FileSizeMetric")]
        Bank,
        [LocalizedDescription("TacFor")]
        [LocalizedDescriptionValue("TacFor")]
        TacFor,
        [LocalizedDescription("TacType")]
        [LocalizedDescriptionValue("TacType")]
        TacType,
        [LocalizedDescription("TacSource")]
        [LocalizedDescriptionValue("TacSource")]
        TacSource,
        [LocalizedDescription("Currency")]
        [LocalizedDescriptionValue("Currency")]
        Currency,
        [LocalizedDescription("Wallet Status")]
        [LocalizedDescriptionValue("WalletStatus")]
        WalletStatus
    }
    public enum LookupDetailEnum
    {
        [LocalizedDescription("Mobile")]
        [LocalizedDescriptionValue("Mobile")]
        Mobile,
        [LocalizedDescription("Web")]
        [LocalizedDescriptionValue("Web")]
        Web,
        [LocalizedDescription("SMS")]
        [LocalizedDescriptionValue("SMS")]
        SMS,
        [LocalizedDescription("Email")]
        [LocalizedDescriptionValue("Email")]
        Email,
        [LocalizedDescription("Registration")]
        [LocalizedDescriptionValue("Registration")]
        Registration,
        [LocalizedDescription("Authentication")]
        [LocalizedDescriptionValue("Authentication")]
        Authentication,
        [LocalizedDescription("Login")]
        [LocalizedDescriptionValue("Login")]
        Login,
        [LocalizedDescription("Rider")]
        [LocalizedDescriptionValue("Rider")]
        Rider,
        [LocalizedDescription("Driver")]
        [LocalizedDescriptionValue("Driver")]
        Driver,
        [LocalizedDescription("Vendor")]
        [LocalizedDescriptionValue("Vendor")]
        Vendor,
        [LocalizedDescription("Advisor")]
        [LocalizedDescriptionValue("Advisor")]
        Advisor,
        [LocalizedDescription("WalletDeposit")]
        [LocalizedDescriptionValue("WalletDeposit")]
        WalletDeposit,

        [LocalizedDescription("Deposit")]
        [LocalizedDescriptionValue("Deposit")]
        Deposit,

        [LocalizedDescription("OnlineTransaction")]
        [LocalizedDescriptionValue("OnlineTransaction")]
        OnlineTransaction,

        [LocalizedDescription("Successful")]
        [LocalizedDescriptionValue("Successful")]
        Successful
    }
}
