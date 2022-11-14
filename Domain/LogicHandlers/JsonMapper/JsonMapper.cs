using System.Text.RegularExpressions;
using Model.Entities;
using serializer = Newtonsoft.Json.JsonConvert;

namespace Domain.LogicHandlers.JsonMapper;

public sealed class JsonMapper{
    private JsonMapper(){}

    private static JsonMapper? _instance;
    
    public static JsonMapper GetInstance()
    {
        return _instance ??= new JsonMapper();
    }
    
    public List<Stock?> MapToCompanyStocks(string json){
        json = json.Substring(1,json.Length - 2);
        json = json.Substring(1,json.Length - 2);
        var jsonSplit = Regex.Split(json, "},{");
        for (var i = 0; i < jsonSplit.Length; i++){
            jsonSplit[i] = "{" + jsonSplit[i] + "}";
        }
        return jsonSplit.Select(serializer.DeserializeObject<Stock>).ToList();
    }

}