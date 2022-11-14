using System.Net.Http.Headers;
using Model.Entities;
using mapper = Domain.LogicHandlers.JsonMapper.JsonMapper;

namespace Domain.LogicHandlers.API;

public sealed class TiingoApi{
    private TiingoApi(){
    }

    private static TiingoApi? _instance;

    private static readonly HttpClient Client = new (){
        DefaultRequestHeaders ={Accept ={new MediaTypeWithQualityHeaderValue("application/json")}}
    };

    private const string Token = "d3cf3605f03eadc70bb9a0803ae63832a3f5e294";
    private const string Token2 = "b5bbfb49331a2b27ffe3919b6456efceda0cf361";
    
    public static TiingoApi GetInstance()
    {
        return _instance ??= new TiingoApi();
    }
    
    private static string GetToken()
    {
        var random = new Random();
        var token = random.Next(0, 2);
        return token == 0 ? Token : Token2;
    }

    public List<Stock>? GetCompanyStocks(string ticker, DateTime startTime, DateTime endTime){
        var url = $"https://api.tiingo.com/tiingo/daily/{ticker}/prices?startDate={startTime.Date.ToString("yyyy-MM-dd")}&endDate={endTime.Date.ToString("yyyy-MM-dd")}&token={GetToken()}";
        var response = Client.GetAsync(url).Result;
        var json = response.Content.ReadAsStringAsync().Result;
        return mapper.GetInstance().MapToCompanyStocks(json);
    }
    
}