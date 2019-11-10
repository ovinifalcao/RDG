using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace APS_RDG
{
   public class Program
    {


        static void Main(string[] args)
        {
            BuildAnalysis(10, 3);
            BuildAnalysis(100, 3);
            BuildAnalysis(1000, 3);
            BuildAnalysis(2000, 3);

            BuildAnalysis(4000, 3);
        }

        static void BuildAnalysis(int VetorLenght, int Iteracao)
        {
            var RadomAsciiArr = repetiveisRandom(VetorLenght * 4, 65, 91);
            var RadomAsciiArrCh = repetiveisRandom(VetorLenght, 65, 91);
            var ArrTitulo = TransformToString(RadomAsciiArr, 4);
            var ArrValor = doubleRandom(VetorLenght);
            var ArrDisponibilidade = repetiveisRandom(VetorLenght, 0, 2);
            var ArrIdade = intRandom(VetorLenght);
            var ArrGrupo = TransformToString(RadomAsciiArrCh, 1);


            Model_Data[] Data = new Model_Data[VetorLenght];
            for (int i = 0; i < VetorLenght; i++)
            {
                var DtPass = new Model_Data()
                {
                    Titulo = ArrTitulo[i],
                    Valor = (float)ArrValor[i],
                    Disponibilidade = Convert.ToBoolean(Convert.ToInt16(ArrDisponibilidade[i])),
                    Idade = ArrIdade[i],
                    Grupo = char.Parse(ArrGrupo[i]),
                };
                Data[i] = DtPass;
            }

            string BaseSource = @"C:\Users\Vinícius\Desktop\" + "APS_4sem";
            Directory.CreateDirectory(BaseSource + "\\" + Iteracao + "Iteracao");
            Directory.CreateDirectory(BaseSource + "\\" + Iteracao + "Iteracao" + "\\" + VetorLenght + " Objects");

            string BBSource = Path.Combine(BaseSource + "\\" + Iteracao + "Iteracao" + "\\" + VetorLenght + " Objects" );
            Directory.CreateDirectory(BBSource + "\\BBsort");
            Analysis.BubbleAnalysis(Data, BBSource);

            string MGSource = Path.Combine(BaseSource + "\\" + Iteracao + "Iteracao" + "\\" + VetorLenght + " Objects");
            Directory.CreateDirectory(MGSource + "\\MGsort");
            Analysis.MergeAnalysis(Data, MGSource);

            string QKSource = Path.Combine(BaseSource + "\\" + Iteracao + "Iteracao" + "\\" + VetorLenght + " Objects");
            Directory.CreateDirectory(QKSource + "\\QKsort");
            Analysis.QuickAnalysis(Data, QKSource);
        }

        static int[] intRandom(int ArrLenght)
        {
            var IntArr = new int[ArrLenght];
            int Counter = 0;

            while(Counter < ArrLenght)
            { 
                Random random = new Random();
                var Rd = random.Next(0, ArrLenght+1);


                if (!IntArr.Contains(Rd))
                {
                    IntArr[Counter] = Rd;
                    Counter++;
                }
            }
            return IntArr;
        }

        static double[] doubleRandom(int ArrLenght)
        {
            var DobArr = new double[ArrLenght];
            int Counter = 0;

            while (Counter < ArrLenght)
            {
                Random random = new Random();
                var Rd = (double)random.NextDouble() * ArrLenght;

                if (!DobArr.Contains(Rd))
                {
                    DobArr[Counter] = Rd;
                    Counter++;
                }
            }
            return DobArr;
        }

        static int[] repetiveisRandom(int ArrLenght,int floor, int Ceiling)
        {
            var IntArr = new Int32[ArrLenght];
            int Counter = 0;
            Random random = new Random();

            while (Counter < ArrLenght)
            {
                var Rd = random.Next(floor, Ceiling);

                    IntArr[Counter] = Rd;
                    Counter++;
            }
            return IntArr;
        }

        static string[] TransformToString(int[] AsciiArr, int 
            )
        {
            int Divided = (AsciiArr.Length / Divisor);
            string[] FinalArr = new string[Divided];

            for (int i = 0; i < Divided; i++)
            {
                string FinalCaracter = null;
                for (int j = 0; j < Divisor; j++)
                {
                    FinalCaracter += AsciiToString(AsciiArr[i + (j * Divided)]);
                }

                FinalArr[i] = FinalCaracter;
            }

            return FinalArr;
        }

        public static char AsciiToString(int Number)
        {
            var byrr = new byte[1];
            byrr[0] = byte.Parse(Number.ToString());
            return Encoding.ASCII.GetChars(byrr)[0];
        }

    }
}
