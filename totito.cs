using System;

namespace Totito
{
    class Totito
    {
        static void Main(string[] args)
        {
            // Variables
            Random rand = new Random();
            char[][] tablero = new char[][] { new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' } };
            char ganador = ' ';
            bool juega_cpu = rand.Next(2) == 1;
            int i, j, turnos;

            // Bucle del juego
            for (turnos = 0; turnos < 9 && ganador != 'O' && ganador != 'X'; turnos++)
            {
                // Jugada de la CPU
                if (juega_cpu)
                {
                    do
                    {
                        i = rand.Next(3);
                        j = rand.Next(3);
                    } while (tablero[i][j] != ' ');
                    tablero[i][j] = 'O';
                }

                // Jugada del usuario
                else
                {
                    imprimirTablero(tablero);
                    do
                    {
                        i = leerNumero("renglón");
                        j = leerNumero("columna");
                        if (tablero[i][j] != ' ')
                            Console.WriteLine("La casilla seleccionada ya está ocupada.\n");
                    } while (tablero[i][j] != ' ');
                    tablero[i][j] = 'X';
                }

                // Revisar ganador
                for (i = 0; ganador == ' ' && i < 3; i++)
                    if (tablero[i][0] != ' ' && tablero[i][0] == tablero[i][1] && tablero[i][1] == tablero[i][2])
                        ganador = tablero[i][0];
                for (i = 0; ganador == ' ' && i < 3; i++)
                    if (tablero[0][i] != ' ' && tablero[0][i] == tablero[1][i] && tablero[1][i] == tablero[2][i])
                        ganador = tablero[0][i];
                if (ganador == ' ' && tablero[0][0] != ' ' && tablero[0][0] == tablero[1][1] && tablero[1][1] == tablero[2][2])
                    ganador = tablero[0][0];
                if (ganador == ' ' && tablero[0][2] != ' ' && tablero[0][2] == tablero[1][1] && tablero[1][1] == tablero[2][0])
                    ganador = tablero[0][2];

                // Cambiar turno
                juega_cpu = !juega_cpu;
            }

            // Mostrar tablero final y ganador
            imprimirTablero(tablero);
            switch (ganador)
            {
                case 'O': Console.WriteLine("¡La computadora ha ganado!"); break;
                case 'X': Console.WriteLine("¡Felicidades, has ganado!"); break;
                case ' ': Console.WriteLine("Empate."); break;
            }

            // Fin del juego
            Console.Write("\nPresione una tecla para terminar . . . ");
            Console.ReadKey();
        }

        static void imprimirTablero(char[][] tablero)
        {
            int i, j;
            Console.Clear();
            Console.WriteLine("   \u2554{0}{0}{0}{1}{0}{0}{0}{1}{0}{0}{0}\u2557", '\u2550', '\u2566');
            Console.WriteLine("   {0} 1 {0} 2 {0} 3 {0}", '\u2551');
            Console.WriteLine("   \u255A{0}{0}{0}{1}{0}{0}{0}{1}{0}{0}{0}\u255D", '\u2550', '\u2569');
            Console.WriteLine();



