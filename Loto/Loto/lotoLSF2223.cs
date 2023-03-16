﻿using System;

namespace LotoClassNS
{
    // Clase que almacena una combinación de la lotería
    //
    public class lotoLSF2223
    {
        // definición de constantes
        public const int MAX_NUMEROS = 6;
        public const int NUMERO_MENOR = 1;
        public const int NUMERO_MAYOR = 49;
        
        private int[] _nums = new int[MAX_NUMEROS];   // numeros de la combinación
        public bool ok = false;      // combinación válida (si es aleatoria, siempre es válida, si no, no tiene porqué)


     
        public int[] Nums { 
            get => _nums; 
            set => _nums = value; 
        }

       
        /// <summary>
        /// Constructor por defecto de la clase. En el caso de que el constructor sea vacío, se genera una combinación aleatoria correcta.
        /// </summary>
        public lotoLSF2223()
        {
            Random r = new Random();    // clase generadora de números aleatorios

            int i, j, num;
            i = 0; 

            do             // generamos la combinación
            {                       
                num = r.Next(NUMERO_MENOR, NUMERO_MAYOR + 1);     // generamos un número aleatorio del 1 al 49
                for (j=0; j<i; j++)
                {
                    if (Nums[j] == num)
                    {
                        break; // comprobamos que el número no está
                    }
                       
                }    
                    
                if (i==j)               // Si i==j, el número no se ha encontrado en la lista, lo añadimos
                {
                    Nums[i]=num;
                    i++;
                }
            } while (i<MAX_NUMEROS);

            ok=true;
        }

        
        /// <summary>
        /// La segunda forma de crear una combinación es pasando el conjunto de números
        // misnums es un array de enteros con la combinación que quiero crear (no tiene porqué ser válida)
        /// </summary>
        /// <param name="misnums">Son los números que introduce el usuario.</param>
        public lotoLSF2223(int[] misnums)  // misnumeros: combinación con la que queremos inicializar la clase
        {
            int j;
            for (int i = 0; i < MAX_NUMEROS; i++)
                if (misnums[i] >= NUMERO_MENOR && misnums[i] <= NUMERO_MAYOR) {
                   
                    for (j = 0; j<i; j++) 
                        if (misnums[i] == Nums[j])
                            break;
                    if (i == j)
                        Nums[i] = misnums[i]; // validamos la combinación
                    else {
                        ok = false;
                        return;
                    }
                }
                else
                {
                    ok = false;     // La combinación no es válida, terminamos
                    return;
                }
	    ok = true;
        }



        /// <summary>
        ///  Método que comprueba el número de aciertos premi es un array con la combinación ganadora se devuelve el número de aciertos
        /// </summary>
        /// <param name="premi">La combinación de números ganadora.</param>
        /// <returns></returns>
        public int comprobar(int[] premi)
        {
            int a = 0;                    // número de aciertos
            for (int i = 0; i < MAX_NUMEROS; i++)
                for (int j = 0; j < MAX_NUMEROS; j++)
                    if (premi[i] == Nums[j]) a++;
            return a;
        }
    }

}
