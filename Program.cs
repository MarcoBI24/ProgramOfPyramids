using System;				
public class Program
{
	public static void Main()
	{   /*      1.- Solicita al usuario la cantidad de filas de la pirámide (Del 1 al 9)
                2.- Imprime en pantalla la pirámide de números como se muestra 
                    el siguiente ejemplo

        Filas = 3                         1
                                         121
                                        12321                                           */

        // Hacer una funcion para que digite el numero de filas                                    
        int n=0;
		Console.WriteLine("Digite el numero de filas que desea para la piramide: ");
        int nFilas=Convert.ToInt32(Console.ReadLine());
        if (nFilas <= 0)
        {
            Console.WriteLine("Numero incorrecto");
        }
        for (n=1;n<=nFilas;n++)
        {   
            //funcion para simular los espacios de la piramide
            for (int z=1;z<=nFilas-n;z++)
            {
                Console.Write(" ");
            }
            // funcion para escribir los numero en la linea
            for(int y=1;y<=n;y++)
            {   
                //FUNCION PARA QUE EL NUMERO VAYA SUBIENDO 
                if(y==1)
                {
                    for(int a=1;a<n;a++)
                {
                    Console.Write(a);
                }       
                Console.Write(n); 
                }         
                
            }
            //funcion para escribir los numero del otro lado de la piramide
            for(int i=1;i<=n-1;i++)
            {   
                if(i==1)
                {
                    
                    //FUNCION PARA QUE EL NUMERO BAJE
                    for (int l=1;l<n;l++)
                    {
                        Console.Write(n-l);
                    }
                }
            }
            Console.WriteLine();

        }
        Console.ReadKey();
      
        /*Console.WriteLine("digite el numero");
        int num=Convert.ToInt32(Console.ReadLine());*/
       
        
	}
    
}

//poner un for dentro del for con n y ese n sumar a la i que se va a mostrar
//hacer listas 
