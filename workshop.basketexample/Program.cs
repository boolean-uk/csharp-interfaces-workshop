using workshop.basketexample;
using workshop.basketexample.Products;

Basket basket = new Basket();

Guitar guitar = new Guitar();
guitar.Name = "Guitar";
guitar.Price = 100;

Drums drumkit = new Drums();
drumkit.Name = "Pearl Export";
drumkit.Price = 300;


basket.Add(guitar);
basket.Add(drumkit);


basket.Products.ForEach(product =>
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
});