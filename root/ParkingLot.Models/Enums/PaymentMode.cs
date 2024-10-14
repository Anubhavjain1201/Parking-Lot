using System.Runtime.Serialization;

namespace ParkingLot.Models.Enums
{
    public enum PaymentMode
    {
        [EnumMember(Value = "CreditCard")]
        CREDIT_CARD,

        [EnumMember(Value = "DebitCard")]
        DEBIT_CARD,

        [EnumMember(Value = "Upi")]
        UPI,

        [EnumMember(Value = "Fastag")]
        FASTAG,

        [EnumMember(Value = "Cash")]
        CASH
    }
}
