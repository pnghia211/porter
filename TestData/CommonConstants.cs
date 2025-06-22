using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace DynamicItinerary.TestData
{
    class CommonConstants
    {

        public const string gmailUserName = "dynamicitinerary@gmail.com";
        public const string gmailPassword = "gspj atun jymt aqzl";

        public const string expectedFileDirectory = "..//..//TestData//ExpectedFiles//";
        public const string actuaFileDirectory = "..//..//_OutputFiles//Email//";


        public const int maxRetries = 5;
        public const int delayMilliseconds = 30000; // 30 seconds

        public static class TestingData
        {

            public static class CancelBooking
            {
                public const string PNRCode = "V68BYS";
                public const string HtmlName = "Your booking has been successfully cancelled";
            }

            public static class PorterPassPurchase
            {
                public const string PNRCode = "R37ZQL";
                public const string HtmlName = "Receipt for your Porter Pass purchase";
            }

            public static class CultureENUS
            {
                public const string PNRCode = "QF7FQE";
                public const string HtmlName = "Booking details- Wed Mar 26, 2025 - Toronto-City (YTZ) to Calgary (YYC)";
            }

            public static class PorterPassRedeem
            {
                public const string PNRCode = "R9SU8Q";
                public const string HtmlName = "Porter Airlines Itinerary - Toronto - Ottawa - Thu 29 Mar 2018";
            }

            public static class PorterPassRedeemFlexibleEN
            {
                public const string PNRCode = "V8K5UZ";
                public const string HtmlName = "                                                               Booking details- Thu Apr 24, 2025 - Montréal-Trudeau (YUL) to Las Vegas (LAS)";
            }

            public static class PorterPassRedeemFlexibleFR
            {
                public const string PNRCode = "V8K5UZ";
                public const string HtmlName = "                                                               Booking details- Thu Apr 24, 2025 - Montréal-Trudeau (YUL) to Las Vegas (LAS)";
            }

            public static class TravelAgent
            {
                public const string PNRCode = "G3J2XI";
                public const string HtmlName = "Booking details- Thu Sep 26, 2024 - Toronto-City (YTZ) to Ottawa (YOW)";
            }

            public static class BookingB6Inbound
            {
                public const string PNRCode = "UB6RHQ";
                public const string HtmlName = "Booking details- Thu Jan 16, 2025 - San Francisco (SFO) to Toronto-City (YTZ)";
            }

            public static class SSR_UMNR
            {
                public const string PNRCode = "Q7RKHZ";
                public const string HtmlName = "Booking details- Thu Mar 13, 2025 - Ottawa (YOW) to Sudbury (YSB)";
            }
        }

        public static string[] pnrList =
        {
            
       
//            //40 emails 
//            //     "UB6RHQ", //Booking B6 inbound
//            //   "R39YTL", //Booking B6 outbound
//            //"G3J2XI", //GDS booking --not sending emails
//            //     "QCFZ7K", //Connecting_DomesticFlight
//            //     "Q99L4T", //Connecting_TransborderFlight
//            //     "MB5JXQ", //TransborderFlight
//            //     "PE9UVH", //Domestic_BasicFare
//            //     "D6NMPM", //Domestic_StandardFare
//            //    "Q4632F", //Domestic_FlexibleFare
//            //     "EBZJVA", //Domestic_FreedomFare
//            //     "C2M8SY", //Domestic_NavigateFare
//            //     "O9FGMG", //Domestic_UltimateFare
//            //     "U12FHR", //Roundtrip_BasicFare
//            //     "VBCD9A", //Roundtrip_StandardFare
//            //     "X48I6V", //Roundtrip_FlexibleFare
//            //     "ZB3R9Q", //Roundtrip_NavigateFare
//            //     "FYGS3N", //Roundtrip_UltimateFare
//            //     "QF7FQE", //Culture en-us
//            //     "H46KFF", // Culture en-fr
//            //"G3J2XI", //IROPed booking
//            //"G3J2XI", //Open jaws booking
//            //      "O9FGMG", //multiple pax
//            //     "**********E5I5YC", //PAx- Standby
//            //     "HDWE3E", //Gift Receipt
//            //     "V8K5UZ", //porterpass redeem flexible_fr --
//            //     "V8K5UZ", //porterpass Redeem flexible_En
//            //     "BEJ6MR", //Porterpass freedom _redeem --VIPorterpass firmfare
//            //     "R37ZQL", //Porterpass purchase
//            //"G3J2XI", //Porterpass -redeem-firm -VIFirstaccount  -- shows complimentary for SDC , should show not permittable
//            //"G3J2XI", //groups
//            //"G3J2XI", //Media fams
//            //"G3J2XI", //Waivers
//            //"G3J2XI", // Product regular - SOS - Firm firm
//            //"G3J2XI", // Product regular - SOS - firm_Flex
//            //"G3J2XI", // Product regular - SOS - Flex_Freedom
//            //"G3J2XI", // Product regular - SOS - firm_freedom
//            //"G3J2XI", // Product - External Nets
//            //***"ZDILHK", //SSR_Multiple
//            //*** "ZDILHK", // SSR Multiple_notes
//            //"G3J2XI", //SSR_Paid_Bike
//            //*************"ZDILHK", //SSR_PETC
//            //"G3J2XI", //SSR_PETS_French
//            //"Q7RKHZ", //SSR_UMNR
//            //"G3J2XI", //SSR_UMNR_Fr
//            //"G3J2XI", //SSR Out of Scope: LEO
//            //"G3J2XI", //Station name_Thunderbay
//            //"G3J2XI", //Different timezones
//            //"G3J2XI", //Staff travel business
//            //"G3J2XI", //Travel agent
//            //    "DEU1SR", //VIBase_Points booking
//            //     "G3GCRI", //VIFirst
//            //     "V68BYS",//cancelled booking -generate email
//            //"G3J2XI", //decline cc NO email 
//            //"G3J2XI", //booking with 1.declined creditcard , 1. use approved cc(email sent) - generate email
//            //"G3J2XI", //(a)booking with 1.declined creditcard 1. use approved cc(email sent), (b). Cancel entire booking(cancel email sent)
//           // "SBDYTQ", //Voluntary Cancellation Staff Pass

//            //"NCMSHK", //Voluntary cancellation VIPorter
////"B49Y6C", //Voluntary Cancellation Porter Pass 
////"VD8L8X", //Voluntary cancellation Voucher and CC  
////"CYDEFA", //Voluntary cancellation Basic - Refundable  
////"SDGITK", //Voluntary cancellation Standard - Refundable   
////"V9WDGG", //Voluntary cancellation Flexible - Refundable   
////"Z5FSGF", //Voluntary cancellation Navigate - Refundable   
//"T5IPGS", //Voluntary cancellation Ultimate - Refundable   
//"D6NMPM", //Voluntary cancellation Standard - Non Refundable   
//"WYPFWT", //Voluntary cancellation Flexible - Non Refundable   
//"D8C84T", //Voluntary cancellation Navigate - Non Refundable   
//"V9WDGG", //Voluntary cancellation Connecting  
//"Z5FSGF", //Voluntary cancellation Transborder 
//"LDZT3H", //Voluntary cancellation Porter Reserve certificate and Credit card  *****error*******
//"Z5FSGF", //Voluntary cancellation Multipax    
//"RFBK2B", //Voluntary cancellation VIPorter Points 
//"R48IRI", //Voluntary cancellation VIPorter cash and points    
//"HCPFWK", //Voluntary cancellation Interline   
//"D1BT5L", //Voluntary cancellation Round trip  
//"I9DE9D", //Voluntary cancellation Culture_CA - FR 
//"H4YMKF", //Voluntary cancellation EN_US   
//"I9DE9D" //Voluntary cancellation Gift certificate   *******error********  
//"RFK9KR", //Voluntary cancellation Multi Credit card   
//"F8JF6T", //Voluntary cancellation Reservation Credit  
"Y5CKGF",  //  Voluntary cancellation Account credit

////"DB13HN", //PorterPass Standard
////"W44H3V", // PorterPass Flexible
////"BBT98X", //PorterPass Navigate    
//"DB13HN",   //PorterPass 10 pass package
//"YECBUX",  //PorterPass 20 pass package
//"I3D5NI", //50 pass package
//"O7HV3J", //100 pass package
 //"M2IC7Y",         //PorterPass Everywhere 
//"DYF7UQ",          //PorterPass Canada  
 //"Z728KP",         //PorterPass Ontario 
//"JYKCNQ"          //PorterPass Triangle  U.S.
// "E2G9YL",         //PorterPass Northeast US <> Triangle    
// "X91SNJ",         //PorterPass Western US <> Triangle
// "ECUYRX",         //PorterPass Credit card 
//  "ECUYRX"        //PorterPass Culture_CA - FR ******already PorterPass_French scenario is there******


//            //"HDWE3E" //GiftReceipt VISA
//            //"IB9ZFN", //GiftReceipt Mastercard

////"P6QW7M", //GiftReceipt Travel Credit and CC    
//  "E3HBGV"//GiftReceipt Amex  - *****No Booking Contact Details******   
//"U3I5WL", //GiftReceipt Multiple Credit cards
      //   "Q5Q9XS",//GiftReceipt French  
        // "OE573E" //GiftReceipt USD 
         };

    }
}
