using Newtonsoft.Json.Linq;
using PerformanceBiller.Entities;
using System;
using System.Globalization;

namespace PerformanceBiller
{
    public class Statement
    {
        public string Run(JObject invoice, JObject plays)
        {
            var totalAmount = 0;
            var volumeCredits = 0;
            var result = $"Statement for {invoice.GetValue("customer")}\n";
            var cultureInfo = new CultureInfo("en-US");

            foreach (JObject performace in invoice.GetValue("performances")) {
                var play = (JObject) plays.GetValue(performace.GetValue("playID").ToString());
                var thisAmount = 0;
                switch (play.GetValue("type").ToString()) {
                    case "tragedy":
                        var tragedy = new Tragedy(null);
                       // var performance1 = new Performance(tragedy, Convert.ToInt32(performace.GetValue("audience")));
                        //thisAmount = performance1.CalculatePlayCost();
                        break;
                    case "comedy":
                        var comedy = new Comedy(null);
                        //var performance2 = new Performance(comedy, Convert.ToInt32(performace.GetValue("audience")));
                        //thisAmount = performance2.CalculatePlayCost();
                        break;
                    default:
                        throw new Exception($"unknown type: { play.GetValue("type").ToString()}");
                }
                // add volume credits
                volumeCredits += Math.Max(Convert.ToInt32(performace.GetValue("audience")) - 30, 0);
                // add extra credit for every ten comedy attendees
                if ("comedy" == play.GetValue("type").ToString()) volumeCredits += Convert.ToInt32(performace.GetValue("audience")) / 5;
                // print line for this order
                result += $" {play.GetValue("name")}: {(thisAmount/100).ToString("C", cultureInfo)} ({performace.GetValue("audience")} seats)\n";
                totalAmount += thisAmount;
             }
             result += $"Amount owed is {(totalAmount/100).ToString("C", cultureInfo)}\n";
             result += $"You earned {volumeCredits} credits\n";

             return result;
        }
    }

    

    
}
