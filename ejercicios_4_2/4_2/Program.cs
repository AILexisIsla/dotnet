// See https://aka.ms/new-console-template for more information

int precio, cantidadL, total;
double totalDes;

Console.WriteLine("ingrese precio por Litro: ");
precio = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe la cantidad de litros: ");
cantidadL = int.Parse(Console.ReadLine());

total = precio * cantidadL;
Console.WriteLine("total de la compra es: "+total);

Console.WriteLine("la cantidad de litros es: "+cantidadL);

if(cantidadL < 100)
{
    totalDes = total;
    Console.WriteLine("el precio no tiene descuento y es: "+totalDes);
}

if(cantidadL > 100 && cantidadL < 301)
{
    totalDes = total - (total * 0.1);
    Console.WriteLine("el precio con descuento es: "+totalDes);
}

else if(cantidadL > 300 && cantidadL < 501)
{
    totalDes = total -(total * 0.15);
    Console.WriteLine("el precio con descuento es: "+totalDes);
}

else if(cantidadL > 500)
{
    totalDes = total - (total * 0.25);
    Console.WriteLine("el precio con descuento es: "+totalDes);
}




