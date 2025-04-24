namespace TreeMapPositionTheLegend;

public class PopulationDetails
{
	public PopulationDetails()
	{
        Continent = string.Empty;
        Country = string.Empty;
	}
    public string Country { get; set; }
    public string Continent { get; set; }
    public double Population { get; set; }
}