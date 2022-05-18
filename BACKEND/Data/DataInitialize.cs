using System.Net;
using COVID.DataContext;
using COVID.Models;

using Newtonsoft.Json;

namespace Covid.Data;

public class DbInitialize {
    
    public static void Initialize(AppDbContext context)
    {
            context.Database.EnsureCreated();
            
            var url = "https://api.covid19api.com/total/country/brazil?from=2021-12-15T00:00:00Z&to=2022-05-15T00:00:00Z";
        
            using(var lista =  new HttpClient()){
                var resposta = lista.GetStringAsync(url);
                // await resposta;
                var retorno = JsonConvert.DeserializeObject<DataCountryModel[]>(resposta.Result).ToList();
                    foreach (var item in retorno)
                    {
                        new DataCountryModel{Id = new Guid(),
                                        Country = item.Country,
                                        CountryCode = item.CountryCode,
                                        Province = item.Province,
                                        City = item.City,
                                        CityCode = item.CityCode,
                                        Lat = item.Lat,
                                        Lon = item.Lon,
                                        Confirmed = item.Confirmed,
                                        Deaths = item.Deaths,
                                        Recovered = item.Recovered,
                                        Active = item.Active,
                                        Date = item.Date};

                                        context.DataCountryModels.Add(item);
                    }
                    context.SaveChanges();

            }
        }
        
}
