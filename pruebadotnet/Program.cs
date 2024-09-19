// See https://aka.ms/new-console-template for more information
int J, W, resta, suma, multi;

Console.WriteLine("escriba un numero: ");

J = int.Parse(Console.ReadLine());

Console.WriteLine("escriba otro numero: ");

W = int.Parse(Console.ReadLine());

suma = J + W;
resta = J - W;
multi = J * W;

if (J > W)
{
    Console.WriteLine("numero suma es: "+suma);
}
if(J == W)
{
    Console.WriteLine("numero resta es: "+resta);
}
if(J < W)
{
    Console.WriteLine("numero multi es: "+multi);
}


//int multi = J * W;

//if(J>W){Console.WriteLine("el resultado de la resta es: "+resta);}
//else if(J==W){Console.WriteLine("el resultado de la suma es: "+suma);}
//else(J<W);{Console.WriteLine("el resultado de la multiplicacion es: "+multi);};

// if (J > W)
// {
//     resta = J - W;
    
// }

// Console.WriteLine("el resultado de la resta es: " + resta);





