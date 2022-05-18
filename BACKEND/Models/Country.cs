namespace COVID.Models;
public class DataCountryModel {
    public Guid Id { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string CityCode { get; set; }
    public float Lat { get; set; }
    public float Lon { get; set; }
    public int Confirmed { get; set; }
    public int Deaths { get; set; }
    public int Recovered { get; set; }
    public int Active { get; set; }
    public DateTime Date { get; set; }
}