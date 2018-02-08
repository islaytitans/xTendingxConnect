using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.XConnect;

namespace JonathanRobbins.xTendingxConnect.ProductCatalogue.Facets
{
    [FacetKey(DefaultFacetKey)]
    public class FrequentFlyerInfo : Sitecore.XConnect.Facet
    {
        public const string DefaultFacetKey = "FrequentFlyerInfo";

        public FrequentFlyerInfo(string frequentFlyerId)
        {
            FrequentFlyerID = frequentFlyerId;
        }

        public FrequentFlyerStatus Status { get; set; }
        public string FrequentFlyerID { get; set; } // Example: ABC12345

        public enum FrequentFlyerStatus
        {
            Unknown = 0,
            Bronze,
            Silver,
            Gold
        }
    }
}
