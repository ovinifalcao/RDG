using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APS_RDG
{
    public class MergeSort
    {
        public enum TpOperation
        {
            integers,
            text,
            caracters,
            decimals,
            booleans
        };


        public static List<Model_Data> MergeSort_Base(List<Model_Data> Data, TpOperation Field)
        {

            if (Data.Count <= 1)
            {
                return Data;
            }

            var left = new List<Model_Data>();
            var right = new List<Model_Data>();

            int middle = Data.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(Data[i]);
            }
            for (int i = middle; i < Data.Count; i++)
            {
                right.Add(Data[i]);
            }

            left = MergeSort_Base(left, Field);
            right = MergeSort_Base(right, Field);
            return Merge(left, right, Field);
        }


        private static List<Model_Data> Merge(List<Model_Data> Left, List<Model_Data> Right, TpOperation Field)
        {
            switch (Field)
            {
                case TpOperation.integers:
                    return MergeInt(Left, Right);

                case TpOperation.decimals:
                    return MergeFloat(Left, Right);
                
                case TpOperation.booleans:
                    return MergeBool(Left, Right);

                case TpOperation.text:
                    return MergeText(Left, Right);

                case TpOperation.caracters:
                    return MergeChar(Left, Right);
            }
            return null;
        }


        private static List<Model_Data> MergeInt(List<Model_Data> left, List<Model_Data> right)
        {
            var rep = new List<Model_Data>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().Idade <= right.First().Idade)  
                    {
                        rep.Add(left.First());
                        left.Remove(left.First());      
                    }
                    else
                    {
                        rep.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    rep.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    rep.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return rep;
        }

        private static List<Model_Data> MergeBool(List<Model_Data> left, List<Model_Data> right)
        {
            var rep = new List<Model_Data>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (GreaterThanBool(left.First().Disponibilidade, right.First().Disponibilidade))
                    {
                        rep.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        rep.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    rep.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    rep.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return rep;
        }

        private static List<Model_Data> MergeFloat(List<Model_Data> left, List<Model_Data> right)
        {
            var rep = new List<Model_Data>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().Valor <= right.First().Valor)
                    {
                        rep.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        rep.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    rep.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    rep.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return rep;
        }

        private static List<Model_Data> MergeChar(List<Model_Data> left, List<Model_Data> right)
        {
            var rep = new List<Model_Data>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (GreaterThanString(left.First().Grupo.ToString(), right.First().Grupo.ToString()))
                    {
                        rep.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        rep.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    rep.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    rep.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return rep;
        }

        private static List<Model_Data> MergeText(List<Model_Data> left, List<Model_Data> right)
        {
            var rep = new List<Model_Data>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (GreaterThanString(left.First().Titulo,right.First().Titulo))
                    {
                        rep.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        rep.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    rep.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    rep.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return rep;
        }


        private static bool GreaterThanBool(bool LeftItem, bool RightItem)
        {
            var lft = Convert.ToInt16(Convert.ToBoolean(LeftItem.ToString()));
            var Rgt = Convert.ToInt16(Convert.ToBoolean(RightItem.ToString()));

            if (lft <= Rgt)
            {
                return true;
            }

            return false;
        }

        private static bool GreaterThanString(string LeftItem, string RightItem)
        {
            var lft = LeftItem.ToCharArray();
            var Rgt = RightItem.ToCharArray();

            for (int i = 0; i < lft.Length; i++)
            {
                if (lft[i] == Rgt[i]) continue;

                if (Convert.ToInt32(lft[i]) <= Convert.ToInt32(Rgt[i]))
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}

