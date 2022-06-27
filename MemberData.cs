using MemberMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberMicroservice
{
    public class MemberData
    {
        public static List<Member> members = new List<Member>()
        {
            new Member()
            {
                MemberID = 1,
                MemberName = "Syed",
                MemberAddress1 = "412 Street",
                MemberAddress2 = "Victorious",
                MemberCity = "California",
                MemberPhone = 0124345454,
                Username = "Syed",
                Password = "syed@123"
            },
            new Member()
            {
                MemberID = 2,
                MemberName = "Saraswathi",
                MemberAddress1 = "4432 main Street",
                MemberAddress2 = "Sholingannalur",
                MemberCity = "Chennai",
                MemberPhone = 0432345242,
                Username = "Saras",
                Password = "saras@123"
            },
            new Member()
            {
                MemberID = 3,
                MemberName = "Sumitha",
                MemberAddress1 = "4432 main Street",
                MemberAddress2 = "Sholingannalur",
                MemberCity = "Chennai",
                MemberPhone = 0432345242,
                Username = "Sumitha",
                Password = "sumi@123"
            },
            new Member()
            {
                MemberID = 4,
                MemberName = "Ritik",
                MemberAddress1 = "4432 main Street",
                MemberAddress2 = "Sholingannalur",
                MemberCity = "Chennai",
                MemberPhone = 0432345242,
                Username = "Ritik",
                Password = "ritik@123"
            }

        };
        public static List<MemberPremium> premiumDetails = new List<MemberPremium>()
        {
            new MemberPremium()
            {
                MemberID = 1,
                PolicyID = 1,
                PremiumDue = 43242.0,
                PaymentDetails = "UPI Mode",
                DueDate = new DateTime(2020, 12, 20),
                LastPremiumPaidDate = new DateTime(2019, 12, 21)
            },
            new MemberPremium()
            {
                MemberID = 2,
                PolicyID = 1,
                PremiumDue = 54342.0,
                PaymentDetails = "Cheque Mode",
                DueDate = new DateTime(2021, 04, 16),
                LastPremiumPaidDate = new DateTime(2020, 04, 22),
            },
            new MemberPremium()
            {
                MemberID = 3,
                PolicyID = 2,
                PremiumDue = 58543.0,
                PaymentDetails = "UPI Mode",
                DueDate = new DateTime(2022, 06, 16),
                LastPremiumPaidDate = new DateTime(2022, 04, 22)
            },
            new MemberPremium()
            {
                MemberID = 4,
                PolicyID = 3,
                PremiumDue = 83456.0,
                PaymentDetails = "UPI Mode",
                DueDate = new DateTime(2022, 07, 03),
                LastPremiumPaidDate = new DateTime(2022, 05, 20)
            }

        };
    }
}
