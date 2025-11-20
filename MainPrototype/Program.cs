using Prototype;

var hoodie = new DecodedHoodiePrototype();
hoodie.Brand = "Nike";
hoodie.DecodedHood = true;

IPrototype cloned = hoodie.Clone();

var clonedHoodie = cloned as DecodedHoodiePrototype;
clonedHoodie!.Brand = "Adidas";

Console.WriteLine($"Original hoodie --> Brand: {hoodie.Brand} Decoded: {hoodie.DecodedHood} ");

Console.WriteLine($"Cloned hoodie --> Brand: {clonedHoodie!.Brand} Decoded: {clonedHoodie.DecodedHood} ");

