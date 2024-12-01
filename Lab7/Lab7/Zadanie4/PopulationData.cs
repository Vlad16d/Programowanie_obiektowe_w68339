using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

public class PopulationData
{
    private List<PopulationRecord> records;

    public PopulationData(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var rawData = JsonConvert.DeserializeObject<List<dynamic>>(json);
        records = rawData.Select(r => new PopulationRecord
        {
            Country = r["country"]["value"].ToString(),
            Year = r["date"].ToString(),
            Population = r["value"] != null ? long.Parse(r["value"].ToString()) : (long?)null
        }).ToList();
    }

    public long? GetPopulation(string country, string year)
    {
        return records.FirstOrDefault(r => r.Country == country && r.Year == year)?.Population;
    }

    public long? GetPopulationDifference(string country, string yearStart, string yearEnd)
    {
        var start = GetPopulation(country, yearStart);
        var end = GetPopulation(country, yearEnd);

        if (start.HasValue && end.HasValue)
        {
            return end.Value - start.Value;
        }

        return null;
    }

    public Dictionary<string, double> GetYearlyGrowth(string country)
    {
        var countryData = records.Where(r => r.Country == country && r.Population.HasValue)
                                 .OrderBy(r => int.Parse(r.Year))
                                 .ToList();

        var growthRates = new Dictionary<string, double>();
        for (int i = 1; i < countryData.Count; i++)
        {
            var previous = countryData[i - 1];
            var current = countryData[i];
            var growth = ((double)(current.Population - previous.Population) / previous.Population) * 100;
            growthRates[current.Year] = growth;
        }

        return growthRates;
    }

    public List<PopulationRecord> GetRecords()
    {
        return records;
    }
}
