using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.XConnect;

namespace JonathanRobbins.xTendingxConnect.ProductCatalogue.Facets
{
[Serializable]
[FacetKey(DefaultFacetKey)]
public class SampleOrder : Sitecore.XConnect.Facet
{
    public const string DefaultFacetKey = "SampleOrder";

    public SampleOrder(string rangeId, string productId)
    {
        RangeId = rangeId;
        ProductId = productId;
    }

    private SampleOrder()
    {
            
    }

    public string RangeId { get; private set; }
    public string ProductId { get; private set; }
}
}
