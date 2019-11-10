namespace APS_RDG
{
    public class BubleSort
    {
        public static void BubbleSortByFloatField(Model_Data[] AllData)
        {
            int length = AllData.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (AllData[j].Valor > AllData[j + 1].Valor)
                    {
                        float switcher = 0;
                        switcher = AllData[j].Valor;
                        AllData[j].Valor = AllData[j + 1].Valor;
                        AllData[j + 1].Valor = switcher;
                    }
                }
            }
        }


        public static void BubbleSortByIntField(Model_Data[] AllData)
        {
            int length = AllData.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (AllData[j].Idade > AllData[j + 1].Idade)
                    {
                        int switcher = 0;
                        switcher = AllData[j].Idade;
                        AllData[j].Idade = AllData[j + 1].Idade;
                        AllData[j + 1].Idade = switcher;
                    }
                }
            }
        }


        public static void BubbleSortByBoolField(Model_Data[] AllData)
        {
            int length = AllData.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (Model_Data.GreaterThanBool(AllData[j].Disponibilidade, AllData[j + 1].Disponibilidade))
                    {
                        bool switcher = false;
                        switcher = AllData[j].Disponibilidade;
                        AllData[j].Disponibilidade = AllData[j + 1].Disponibilidade;
                        AllData[j + 1].Disponibilidade = switcher;
                    }
                }
            }
        }


        public static void BubbleSortByStringField(Model_Data[] AllData)
        {
            int length = AllData.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (Model_Data.GreaterThanString(AllData[j].Titulo, AllData[j + 1].Titulo))
                    {
                        string switcher = null;
                        switcher = AllData[j].Titulo;
                        AllData[j].Titulo = AllData[j + 1].Titulo;
                        AllData[j + 1].Titulo = switcher;
                    }
                }
            }
        }


        public static void BubbleSortByCharField(Model_Data[] AllData)
        {
            int length = AllData.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (Model_Data.GreaterThanString(AllData[j].Grupo.ToString(), AllData[j + 1].Grupo.ToString()))
                    {
                        char switcher;
                        switcher = AllData[j].Grupo;
                        AllData[j].Grupo = AllData[j + 1].Grupo;
                        AllData[j + 1].Grupo = switcher;
                    }
                }
            }
        }
    }
}
