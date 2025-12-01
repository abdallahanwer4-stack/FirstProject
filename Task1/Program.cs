

int smallCarbets = Convert.ToInt32(Console.ReadLine());

int largeCarbets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number of large carbets : {largeCarbets}");

Console.WriteLine($"Number of small carbets : {smallCarbets}");


Console.WriteLine($"Price per small carbets : 25$");
Console.WriteLine($"Price per large carbets : 35$");

int priceSmallcarbets = Convert.ToInt32(smallCarbets * 25);

int priceLargecarbets = Convert.ToInt32(largeCarbets * 35);


Decimal  total = Convert.ToDecimal(priceSmallcarbets + priceLargecarbets);

Console.WriteLine($"Cost : {total}");

decimal tax = Convert.ToDecimal(0.06);

Console.WriteLine($"Tax : {tax}$");


decimal totaltax = Convert.ToDecimal(tax * total);
Console.WriteLine($"Tax : {totaltax}$");


decimal totalEstimatedcost = Convert.ToDecimal(totaltax + total);

Console.WriteLine($"totalEstimatedcost {totalEstimatedcost}$");
Console.WriteLine("this estimae is valid for 30 days");