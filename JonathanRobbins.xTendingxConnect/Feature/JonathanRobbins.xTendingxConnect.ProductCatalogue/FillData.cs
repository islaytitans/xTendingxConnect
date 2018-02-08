using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JonathanRobbins.xTendingxConnect.ProductCatalogue.Facets;
using Sitecore.XConnect;
using Sitecore.XConnect.Collection.Model;

namespace JonathanRobbins.xTendingxConnect.ProductCatalogue
{
    public class FillData
    {
        public async void SampleModelAsync()
        {
            using (Sitecore.XConnect.Client.XConnectClient xClient = Sitecore.XConnect.Client.Configuration.SitecoreXConnectClientConfiguration.GetClient())
            {
                try
                {
                    Contact contact = new Contact(new ContactIdentifier("website", "email@address", ContactIdentifierType.Known));

                    xClient.AddContact(contact);

                    var flyerInfo = new FrequentFlyerInfo("First1")
                    {
                        Status = FrequentFlyerInfo.FrequentFlyerStatus.Silver
                    };

                    var facetReference = new FacetReference(contact, FrequentFlyerInfo.DefaultFacetKey);

                    xClient.SetFacet(facetReference, flyerInfo);

                    await xClient.SubmitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
