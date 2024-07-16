namespace Eco.Products.Helpers.Json;

public static class JsonHelper<T> 
{
    public static T? DecodeJsonData(string file) {
        using (StreamReader r = new StreamReader(file))
        {
            string json = r.ReadToEnd();
            T? items = JsonConvert.DeserializeObject<T>(json);
            return items;
        }
    }
}