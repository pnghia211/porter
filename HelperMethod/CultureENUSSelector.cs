using System.Collections.Generic;
using DynamicItinerary.TestData;

public  class CultureENUSSelector : ISelectorProvider
{
    public static string ConfirmedNumberSel { get; set; } = $"//*[contains(text(),'{CommonConstants.TestingData.CultureENUS.PNRCode}')]";
    public static string ReceiptSummarySel { get; set; } = $"//*[contains(text(),'Receipt summary')]";
    public static string FlightDetailFromCitySel { get; set; } = $"//*[contains(text(),'422.31')][1]";

    public List<string> getAllSelectors()
    {
        return new List<string>
        {
            ConfirmedNumberSel, ReceiptSummarySel, FlightDetailFromCitySel
        };
    }
}
