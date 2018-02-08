using Sitecore.XConnect.Serialization;

namespace JonathanRobbins.xTendingxConnect.Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = XdbModelWriter.Serialize(JonathanRobbins.xTendingxConnect.ProductCatalogue.Models.SampleModel.Model);

            int i = 0;
        }
    }
}
