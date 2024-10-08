using System;

namespace MapaDeTerreno
{
    public enum TerrenoEnum
    {
        GRAMA,
        AREIA,
        AGUA,
        PAREDE,
        FLORESTA,
        MONTANHA
    }

    public static class TerrenoEnumExtensoes
    {
        public static ConsoleColor ObterCor(this TerrenoEnum terreno)
        {
            return terreno switch
            {
                TerrenoEnum.GRAMA => ConsoleColor.Green,
                TerrenoEnum.AREIA => ConsoleColor.Yellow,
                TerrenoEnum.AGUA => ConsoleColor.Blue,
                TerrenoEnum.PAREDE => ConsoleColor.DarkGray,
                TerrenoEnum.FLORESTA => ConsoleColor.DarkGreen,
                TerrenoEnum.MONTANHA => ConsoleColor.Gray,
                _ => ConsoleColor.White,
            };
        }

        public static char ObterChar(this TerrenoEnum terreno)
        {
            return terreno switch
            {
                TerrenoEnum.GRAMA => 'G', 
                TerrenoEnum.AREIA => 'S',
                TerrenoEnum.AGUA => 'W', 
                TerrenoEnum.PAREDE => 'X',
                TerrenoEnum.FLORESTA => 'F',
                TerrenoEnum.MONTANHA => 'M', 
                _ => ' ',
            };
        }
    }

    class Programa
    {
        static TerrenoEnum[,] mapa =
        {
            { TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.FLORESTA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.AREIA, TerrenoEnum.GRAMA, TerrenoEnum.AGUA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA },
            { TerrenoEnum.AREIA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.FLORESTA, TerrenoEnum.FLORESTA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.AREIA, TerrenoEnum.AREIA },
            { TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.PAREDE, TerrenoEnum.PAREDE, TerrenoEnum.AGUA, TerrenoEnum.AGUA },
            { TerrenoEnum.AREIA, TerrenoEnum.AREIA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.MONTANHA, TerrenoEnum.MONTANHA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA },
            { TerrenoEnum.FLORESTA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.MONTANHA, TerrenoEnum.MONTANHA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.GRAMA, TerrenoEnum.AREIA },
            { TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.PAREDE, TerrenoEnum.PAREDE, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA, TerrenoEnum.AGUA },
        };

        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int linha = 0; linha < mapa.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mapa.GetLength(1); coluna++)
                {
                    Console.ForegroundColor = mapa[linha, coluna].ObterCor();
                    Console.Write(mapa[linha, coluna].ObterChar() + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray; 
        }
    }
}
