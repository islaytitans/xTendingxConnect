using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JonathanRobbins.xTendingxConnect.ProductCatalogue.Facets;
using Sitecore.XConnect;
using Sitecore.XConnect.Schema;

namespace JonathanRobbins.xTendingxConnect.ProductCatalogue.Models
{
    public class SampleModel
    {
        public static XdbModel Model { get; } = SampleModel.BuildModel();

        private static XdbModel BuildModel()
        {
            XdbModelBuilder modelBuilder = new XdbModelBuilder("SampleModel", new XdbModelVersion(1, 0));

            modelBuilder.ReferenceModel(Sitecore.XConnect.Collection.Model.CollectionModel.Model);
            modelBuilder.DefineFacet<Contact, FrequentFlyerInfo>(FrequentFlyerInfo.DefaultFacetKey);

            return modelBuilder.BuildModel();
        }
    }
}
