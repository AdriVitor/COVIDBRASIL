using COVID.Models;
using Microsoft.AspNetCore.Mvc;
namespace COVID.Controllers;
using System.Text.Json;

using COVID.DataContext;


[ApiController]
public class HomeControllers : ControllerBase
{
    [HttpGet("/{Week:DateTime}")]
    public List<CalculosModels> ReturnTeste([FromServices]AppDbContext context,[FromRoute] DateTime Week)
    {
        var varSemana = context.DataCountryModels.FirstOrDefault(x=>x.Date == Week);
        var varDia1 = context.DataCountryModels.FirstOrDefault(x=>x.Date == Week.AddDays(-1));
        var varDia2 = context.DataCountryModels.FirstOrDefault(x=>x.Date == Week.AddDays(-2));
        var varDia3 = context.DataCountryModels.FirstOrDefault(x=>x.Date == Week.AddDays(-3));
        var varDia4 = context.DataCountryModels.FirstOrDefault(x=>x.Date == Week.AddDays(-4));
        var varDia5 = context.DataCountryModels.FirstOrDefault(x=>x.Date == Week.AddDays(-5));
        var varDia6 = context.DataCountryModels.FirstOrDefault(x=>x.Date == Week.AddDays(-6));
        
        var CalculationConfirmads = (varDia1.Confirmed + 
        varDia2.Confirmed +
        varDia3.Confirmed +
        varDia4.Confirmed +
        varDia5.Confirmed +
        varDia6.Confirmed)/7;

        var CalculationDeaths = (varDia1.Deaths+
        varDia2.Deaths+
        varDia3.Deaths+
        varDia4.Deaths+
        varDia5.Deaths+
        varDia6.Deaths)/7;

        List<CalculosModels> ListDataCovid = new();
        CalculosModels listCalculation = new CalculosModels();
        listCalculation.MediaConfirmados = CalculationConfirmads;
        listCalculation.MediaMortos = CalculationDeaths;

        ListDataCovid.Add(listCalculation);
        return ListDataCovid;
         
    }
    
}

