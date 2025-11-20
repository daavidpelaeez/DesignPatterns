using AbstractFactory.Factory;
using AbstractFactory.Product.Hoodies;
using AbstractFactory.Product.Sneakers;

//Designer Hoodies

Clothing_Factory designerFactory = new DesignerClothingFactory();

Hoodie createdHoodie = designerFactory.CreateHoodie();

DesignerHoodie? designerHoodie = createdHoodie as DesignerHoodie;

designerHoodie!.SetBrand();
designerHoodie.SetDiscount();

Console.WriteLine(" (Designer Hoodie) Brand: " + designerHoodie.Brand + " Discount: " + designerHoodie.hasDiscount);

//Sports Hoodies

Clothing_Factory sportsFactory = new SportsClothingFactory();

Hoodie hoodie = sportsFactory.CreateHoodie();

SportHoodie? sportsHoodie = hoodie as SportHoodie;

sportsHoodie!.SetBrand();
sportsHoodie.SetDiscount();

Console.WriteLine(" (Sports Hoodie) Brand: " + sportsHoodie.Brand + " Discount: " + sportsHoodie.hasDiscount);

//Designer Sneakers

Clothing_Factory sneakerDesignerFactory = new DesignerClothingFactory();

Sneaker createdSneaker = designerFactory.CreateSneaker();

DesignerSneaker? designerSneaker = createdSneaker as DesignerSneaker;

designerSneaker!.SetBrand();
designerSneaker.SetDiscount();

Console.WriteLine(" (Designer Sneaker) Brand: " + designerSneaker.Brand + " Discount: " + designerSneaker.hasDiscount);

//Sports Sneakers 

Clothing_Factory sneakerSportsFactory = new SportsClothingFactory();

Sneaker Sneaker = sportsFactory.CreateSneaker();

SportSneaker? sportSneaker = Sneaker as SportSneaker;

sportSneaker!.SetBrand();
sportSneaker.SetDiscount();

Console.WriteLine(" (Sport Sneaker) Brand: " + sportSneaker.Brand + " Discount: " + sportSneaker.hasDiscount);


