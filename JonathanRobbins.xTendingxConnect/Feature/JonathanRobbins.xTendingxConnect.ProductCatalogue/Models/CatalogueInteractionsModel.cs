using System;
using JonathanRobbins.xTendingxConnect.ProductCatalogue.Facets;
using Sitecore.XConnect;
using Sitecore.XConnect.Schema;

namespace JonathanRobbins.xTendingxConnect.ProductCatalogue.Models
{
    [Serializable]
    public class CatalogueInteractionsModel
    {
        public const string ModelKey = "CatalogueInteractionsModel";
        public static XdbModel Model => BuildModel();

        private static XdbModel BuildModel()
        {
            var modelBuilder = new XdbModelBuilder(ModelKey, new XdbModelVersion(0, 1));

            modelBuilder.ReferenceModel(Sitecore.XConnect.Collection.Model.CollectionModel.Model);
            modelBuilder.DefineFacet<Interaction, SampleOrder>(SampleOrder.DefaultFacetKey);

            return modelBuilder.BuildModel();
        }
    }
}
