using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace APS_RDG
{
    public class Analysis
    {


        public static void BubbleAnalysis(IEnumerable<Model_Data> UnsortedData, string BaseSource)
        {
            WriteOnDoc(UnsortedData, BaseSource + @"\BBsort\unsortedBase.txt");

            var Analysis = new List<string>();
            var Timmer = new System.Diagnostics.Stopwatch();
            var ListPass = new List<Model_Data>();
            //Sim, isso podia ser um método, mas vamos de procedural



            Timmer.Start();
            Analysis.Add("Analise por Float");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            BubleSort.BubbleSortByFloatField(ListPass.ToArray());
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\BBsort\BaseSorted_FloatField.txt");
            ListPass.Clear();


            Timmer.Start();
            Analysis.Add("Analise por Int");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            BubleSort.BubbleSortByIntField(ListPass.ToArray());
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\BBsort\BaseSorted_IntField.txt");
            ListPass.Clear();


            Timmer.Start();
            Analysis.Add("Analise por String");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            BubleSort.BubbleSortByStringField(ListPass.ToArray());
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\BBsort\BaseSorted_StringField.txt");
            ListPass.Clear();


            Timmer.Start();
            Analysis.Add("Analise por Char");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            BubleSort.BubbleSortByCharField(ListPass.ToArray());
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\BBsort\BaseSorted_CharField.txt");
            ListPass.Clear();


            Timmer.Start();
            Analysis.Add("Analise por Bool");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            BubleSort.BubbleSortByBoolField(ListPass.ToArray());
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\BBsort\BaseSorted_BoolField.txt");
            ListPass.Clear();

            WriteOnDocAnalys(Analysis, BaseSource + @"\BBsort\DataAnalysis.txt");
        }

        public static void MergeAnalysis(IEnumerable<Model_Data> UnsortedData, string BaseSource)
        {
            WriteOnDoc(UnsortedData, BaseSource + @"\MGsort\unsortedBase.txt");

            var Analysis = new List<string>();
            var Timmer = new System.Diagnostics.Stopwatch();
            var ListResult = new List<Model_Data>();
            var ListPass = ForceToLostTheReference(UnsortedData);


            Timmer.Start();
            Analysis.Add("Analise por Float");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListResult = MergeSort.MergeSort_Base(ListPass, MergeSort.TpOperation.decimals);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListResult, BaseSource + @"\MGsort\BaseSorted_FloatField.txt");

            Timmer.Start();
            Analysis.Add("Analise por Int");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListResult = MergeSort.MergeSort_Base(ListPass, MergeSort.TpOperation.integers);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListResult, BaseSource + @"\MGsort\BaseSorted_IntField.txt");

            Timmer.Start();
            Analysis.Add("Analise por String");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListResult = MergeSort.MergeSort_Base(ListPass, MergeSort.TpOperation.text);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms \n");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListResult, BaseSource + @"\MGsort\BaseSorted_StringField.txt");


            Timmer.Start();
            Analysis.Add("Analise por Char");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListResult = MergeSort.MergeSort_Base(ListPass, MergeSort.TpOperation.caracters);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms \n");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListResult, BaseSource + @"\MGsort\BaseSorted_CharField.txt");


            Timmer.Start();
            Analysis.Add("Analise por Bool");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListResult = MergeSort.MergeSort_Base(ListPass, MergeSort.TpOperation.booleans);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms \n");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListResult, BaseSource + @"\MGsort\BaseSorted_BoolField.txt");

            WriteOnDocAnalys(Analysis, BaseSource + @"\MGsort\DataAnalysis.txt");
        }

        public static void QuickAnalysis(IEnumerable<Model_Data> UnsortedData, string BaseSource)
        {
            WriteOnDoc(UnsortedData, BaseSource + @"\QKsort\unsortedBase.txt");

            var Analysis = new List<string>();
            var Timmer = new System.Diagnostics.Stopwatch();
            var ListPass = new List<Model_Data>();

            Timmer.Start();
            Analysis.Add("Analise por Float");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            QuickSort.QuickSortByFloatField(ListPass.ToArray(), 0, ListPass.Count -1);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\QKsort\BaseSorted_FloatField.txt");



            Timmer.Start();
            Analysis.Add("Analise por Int");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            QuickSort.QuickSortByIntField(ListPass.ToArray(), 0, ListPass.Count - 1);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\QKsort\BaseSorted_IntField.txt");


            Timmer.Start();
            Analysis.Add("Analise por String");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            QuickSort.QuickSortByStringField(ListPass.ToArray(), 0, ListPass.Count - 1);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms ");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\QKsort\BaseSorted_StringField.txt");


            Timmer.Start();
            Analysis.Add("Analise por Char");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            QuickSort.QuickSortByCharField(ListPass.ToArray(), 0, ListPass.Count - 1);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms ");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\QKsort\BaseSorted_CharField.txt");


            Timmer.Start();
            Analysis.Add("Analise por Bool");
            Analysis.Add("Iniciado às " + DateTime.Now);
            ListPass = ForceToLostTheReference(UnsortedData);
            QuickSort.QuickSortByBoolField(ListPass.ToArray(), 0, ListPass.Count - 1);
            Timmer.Stop();
            Analysis.Add("Finalizado às " + DateTime.Now);
            Analysis.Add("Tempo Decorrido " + Timmer.ElapsedMilliseconds + " Ms");
            Analysis.Add("");
            Timmer.Reset();
            WriteOnDoc(ListPass, BaseSource + @"\QKsort\BaseSorted_BoolField.txt");


            WriteOnDocAnalys(Analysis, BaseSource + @"\QKsort\DataAnalysis.txt");
        }



        private static List<Model_Data> ForceToLostTheReference(IEnumerable<Model_Data> Data)
        {
            var Dt = new List<Model_Data>();

            foreach (Model_Data Dtn in Data)
            {
                var DtPass = new Model_Data()
                {
                    Titulo = Dtn.Titulo,
                    Valor = Dtn.Valor,
                    Disponibilidade = Dtn.Disponibilidade,
                    Idade = Dtn.Idade,
                    Grupo = Dtn.Grupo
                };
                Dt.Add(DtPass);
            }
            return Dt;
        }

        private static void WriteOnDoc(IEnumerable<Model_Data> Data, string Source)
        {

            using (StreamWriter Writer = new StreamWriter(Source))
            {
                foreach (Model_Data Md in Data)
                {
                    var StringLine =
                        string.Format
                        ("{0}, {1}, {2}, {3}, {4}",
                        Md.Titulo, Md.Idade, Md.Valor, Md.Disponibilidade, Md.Grupo);

                    Writer.WriteLine(StringLine);
                }

                Writer.Close();
            }
        }

        private static void WriteOnDocAnalys(IEnumerable<string> Analysis, string Source)
        {

            using (StreamWriter Writer = new StreamWriter(Source))
            {
                foreach (string Md in Analysis)
                {
                    Writer.WriteLine(Md);
                }

                var txString = Analysis.ToList()[13].ToString().Replace("Tempo Decorrido ", "").Replace(" Ms", "");
                var txFloat = Analysis.ToList()[3].ToString().Replace("Tempo Decorrido ", "").Replace(" Ms", "");
                var txInt = Analysis.ToList()[8].ToString().Replace("Tempo Decorrido ", "").Replace(" Ms", "");
                var txChar = Analysis.ToList()[18].ToString().Replace("Tempo Decorrido ", "").Replace(" Ms", "");
                var txBool = Analysis.ToList()[23].ToString().Replace("Tempo Decorrido ", "").Replace(" Ms", "");

                var LinhaPlanilha = string.Format("{0}, {1}, {2}, {3}, {4}", 
                    txString,
                    txFloat,
                    txInt,
                    txChar,
                    txBool
                    );

                Writer.WriteLine(LinhaPlanilha);

                Writer.Close();
            }
        }
    }
}
