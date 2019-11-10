using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APS_RDG
{
    public class QuickSort
    {
        public static void QuickSortByIntField(Model_Data[] data, int first , int last)
        {
            int up = last,
                down = first,
                middle, 
                pivot, 
                rep;

            middle = (int)((first + last) / 2);

            pivot = data[middle].Idade;

            while (down <= up)
            {
                while (data[down].Idade < pivot)
                    down++;
                while (data[up].Idade > pivot)
                    up--;
                if (down < up)
                {
                    rep = data[down].Idade;
                    data[down++].Idade = data[up].Idade;
                    data[up--].Idade = rep;
                }
                else
                {
                    if (down == up)
                    {
                        down++;
                        up--;
                    }
                }
            }

            if (up > first)
                QuickSortByIntField(data, first, up);
            if (down < last)
                QuickSortByIntField(data, down, last);
        }

        public static void QuickSortByFloatField(Model_Data[] data, int first, int last)
        {
            int up = last,
                down = first,
                middle;

            float rep, pivot;

            middle = (int)((first + last) / 2);

            pivot = data[middle].Valor;

            while (down <= up)
            {
                while (data[down].Valor < pivot)
                    down++;
                while (data[up].Valor > pivot)
                    up--;
                if (down < up)
                {
                    rep = data[down].Valor;
                    data[down++].Valor = data[up].Valor;
                    data[up--].Valor = rep;
                }
                else
                {
                    if (down == up)
                    {
                        down++;
                        up--;
                    }
                }
            }

            if (up > first)
                QuickSortByFloatField(data, first, up);
            if (down < last)
                QuickSortByFloatField(data, down, last);
        }

        public static void QuickSortByBoolField(Model_Data[] data, int first, int last)
        {
            int up = last,
                down = first,
                middle;

            bool rep, pivot;

            middle = (int)((first + last) / 2);

            pivot = data[middle].Disponibilidade;

            while (down <= up)
            {
                //Comp Original : data[down].Valor < pivot
                while (Model_Data.GreaterThanBool(pivot, data[down].Disponibilidade))
                    down++;
                while (Model_Data.GreaterThanBool(data[up].Disponibilidade, pivot))
                    up--;
                if (down < up)
                {
                    rep = data[down].Disponibilidade;
                    data[down++].Disponibilidade = data[up].Disponibilidade;
                    data[up--].Disponibilidade = rep;
                }
                else
                {
                    if (down == up)
                    {
                        down++;
                        up--;
                    }
                }
            }

            if (up > first)
                QuickSortByBoolField(data, first, up);
            if (down < last)
                QuickSortByBoolField(data, down, last);
        }

        public static void QuickSortByStringField(Model_Data[] data, int first, int last)
        {
            int up = last,
                down = first,
                middle;

            string rep, pivot;

            middle = (int)((first + last) / 2);

            pivot = data[middle].Titulo;

            while (down <= up)
            {
                //Comp Original : data[down].Titulo < pivot
                while (Model_Data.GreaterThanString(pivot, data[down].Titulo))
                    down++;
                while (Model_Data.GreaterThanString(data[up].Titulo, pivot))
                    up--;
                if (down < up)
                {
                    rep = data[down].Titulo;
                    data[down++].Titulo = data[up].Titulo;
                    data[up--].Titulo = rep;
                }
                else
                {
                    if (down == up)
                    {
                        down++;
                        up--;
                    }
                }
            }

            if (up > first)
                QuickSortByStringField(data, first, up);
            if (down < last)
                QuickSortByStringField(data, down, last);
        }

        public static void QuickSortByCharField(Model_Data[] data, int first, int last)
        {
            int up = last,
                down = first,
                middle;

            char rep, pivot;

            middle = (int)((first + last) / 2);

            pivot = data[middle].Grupo;

            while (down <= up)
            {
                //Comp Original : data[down].Grupo < pivot
                while (Model_Data.GreaterThanString(pivot.ToString(), data[down].Grupo.ToString()))
                    down++;
                while (Model_Data.GreaterThanString(data[up].Grupo.ToString(), pivot.ToString()))
                    up--;
                if (down < up)
                {
                    rep = data[down].Grupo;
                    data[down++].Grupo = data[up].Grupo;
                    data[up--].Grupo = rep;
                }
                else
                {
                    if (down == up)
                    {
                        down++;
                        up--;
                    }
                }
            }

            if (up > first)
                QuickSortByCharField(data, first, up);
            if (down < last)
                QuickSortByCharField(data, down, last);
        }
    }
}
