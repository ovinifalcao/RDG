
using System;
using System.Text;

namespace APS_RDG
{
     public class Model_Data
    {
        public string Titulo { get; set; }
        public float Valor { get; set; }
        public bool Disponibilidade { get; set; }
        public int Idade { get; set; }
        public char Grupo { get; set; }

        public static bool GreaterThanBool(bool LeftItem, bool RightItem)
        {
            var lft = Convert.ToInt16(Convert.ToBoolean(LeftItem.ToString()));
            var Rgt = Convert.ToInt16(Convert.ToBoolean(RightItem.ToString()));

            if (lft > Rgt)
            {
                return true;
            }

            return false;
        }

        public static bool GreaterThanString(string LeftItem, string RightItem)
        {
            var lft = LeftItem.ToCharArray();
            var Rgt = RightItem.ToCharArray();

            for(int i = 0; i < lft.Length; i++)
            {
                if (lft[i] == Rgt[i]) continue;

                if (Convert.ToInt32(lft[i]) > Convert.ToInt32(Rgt[i]))
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
