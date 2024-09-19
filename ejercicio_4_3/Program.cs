// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese un numero para indiocar el procesador deseado 1:INTEL I3, 2:INTEL I5, 3:INTEL I7");
int procesador = int.Parse(Console.ReadLine());


// if(procesador == 1)
// {
//     Console.WriteLine("el procesador es: INTEL I3");
// }
// else if(procesador == 2)
// {
//     Console.WriteLine("el procesador es: INTEL I5");
// }
// else if(procesador == 3)
// {
//     Console.WriteLine("el procesador es: INTEL I7");
// }
// else
// {
//     Console.WriteLine("el procesador no existe");
// }

switch(procesador)
{
    case 1:
        Console.WriteLine("el procesador seleccionado es: INTEL I3");
         Console.WriteLine("elija otro numero para la memoria RAM");
        Console.WriteLine("1: 16GB");
        Console.WriteLine("2: 32GB");
        Console.WriteLine("3: 64GB");
        int ram = int.Parse(Console.ReadLine());
       
        
        switch(ram)
        {
            case 1:
                Console.WriteLine("la memoria RAM seleccionada es: 16GB");
                
                break;
            case 2:
                Console.WriteLine("la memoria RAM seleccionada es: 32GB");
                break;
            case 3:
                Console.WriteLine("la memoria RAM seleccionada es: 64GB");
                break;
            default:
                Console.WriteLine("la memoria RAM no existe");
                break;
        }
        break;
    case 2:
        Console.WriteLine("el procesador seleccionado es: INTEL I5");
        Console.WriteLine("elija otro numero para la memoria RAM");
        Console.WriteLine("1: 16GB");
        Console.WriteLine("2: 32GB");
        Console.WriteLine("3: 64GB");
        int ram2 = int.Parse(Console.ReadLine());
        
        
        switch(ram2)
        {
            case 1:
                Console.WriteLine("la memoria RAM seleccionada es: 16GB");
                break;
            case 2:
                Console.WriteLine("la memoria RAM seleccionada es: 32GB");
                break;
            case 3:
                Console.WriteLine("la memoria RAM seleccionada es: 64GB");
                break;
            default:
                Console.WriteLine("la memoria RAM no existe");
                break;
        }
        break;
    case 3:
        Console.WriteLine("el procesador seleccionado es: INTEL I7");
        Console.WriteLine("elija otro numero para la memoria RAM");
        Console.WriteLine("1: 16GB");
        Console.WriteLine("2: 32GB");
        Console.WriteLine("3: 64GB");
        
        int ram3 = int.Parse(Console.ReadLine());
        
        switch(ram3)
        {
            case 1:
                Console.WriteLine("la memoria RAM seleccionada es: 16GB");
                break;
            case 2:
                Console.WriteLine("la memoria RAM seleccionada es: 32GB");
                break;
            case 3:
                Console.WriteLine("la memoria RAM seleccionada es: 64GB");
                break;
            default:
                Console.WriteLine("la memoria RAM no existe");
                break;
        }
        break;
    default:
        Console.WriteLine("el procesador no existe");
        break;
}

Console.WriteLine("externder disco 1:si 2:no");
int disco = int.Parse(Console.ReadLine());
                
                if(disco == 1)
                {
                    Console.WriteLine("el disco se extendio");
                }
                else if(disco == 2)
                {
                    Console.WriteLine("el disco NO se externdio");
                }

int valor1;
int vram;
int vdisco;


if(procesador == 1)
{
    valor1=500;
}
else if(procesador == 2)
{
    valor1=600;
}
else if(procesador == 3 )
{
    valor1=700;
}
else
{
    Console.WriteLine("computadora no existe");
}

if(ram == 1)
{
    vram=1000;
}
else if(ram == 2)
{
    vram=2000;
}
else if(ram == 3)
{
    vram=3000;
}
else
{
    Console.WriteLine("memoria RAM no existe");
}

if(disco == 1)
{
    vdisco=1000;
}
else if(disco == 2)
{
    vdisco=0;
}

int valortotal = valor1 + vram + vdisco;
Console.WriteLine("el total de la computadora es: "+valortotal);