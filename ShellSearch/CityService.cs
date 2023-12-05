using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSearch;

public class CityService
{
    private List<string> cityList = new List<string>() { "Borlänge", "Falun", "Leksand", "Mora", "Stockholm", "Göteborg", "Malmö", "Gävle", "Örebro", "Halmstad", "Kalmar", "Uppsala", "Växjö", "Karlstad", "Varberg", "Ludvika", "Sundsvall", "Säter", "Avesta", "Kiruna", "Luleå", "Piteå" };

    public Task<List<string>> SearchCity(string query)
    {
        var result = cityList.Where(x => x.ToLower().Contains(query.ToLower())).ToList();
        return Task.FromResult(result);
    }
}
