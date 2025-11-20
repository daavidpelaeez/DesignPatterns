
using Builder;
using Builder.Builders;

var basicBuilder = new BasicHoodieBuilder();

var director = new Director();
director.setBuilder(basicBuilder);

director.Make("Basic");
Hoodie basicHoodie = basicBuilder.GetResult();

Console.WriteLine("Basic Hoodie:");
Console.WriteLine($"Has Hood: {basicHoodie.HasHood}");
Console.WriteLine($"Has Pockets: {basicHoodie.HasHood}");
Console.WriteLine($"Has Hood: {basicHoodie.HasHood}");
