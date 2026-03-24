public class FeatureCollection
{
    public List<Feature> Features { get; set; }
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public string Place { get; set; }
    public decimal Mag { get; set; }
}
