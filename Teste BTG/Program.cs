using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_BTG
{
    internal class Program
    {
        public static void Main()
        {


            List<List<int>> lista = new List<List<int>>();
            lista.Add(new List<int> { 1, 2, 2, 1 });
            lista.Add(new List<int> { 3, 1, 2 });
            lista.Add(new List<int> { 1, 3, 2 });
            lista.Add(new List<int> { 2, 4 });
            lista.Add(new List<int> { 3, 1, 2 });
            lista.Add(new List<int> { 1, 3, 1, 1 });

            menosTijolos(lista);


        }


        static void menosTijolos(List<List<int>> wall)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int res = 0;

            foreach (List<int> subList in wall)
            {
                int width = 0;
                for (int i = 0; i < subList.Count - 1; i++)
                {
                    width += subList[i];
                    if (map.ContainsKey(width))
                        map[width]++;
                    else
                        map.Add(width, 1);
                    res = Math.Max(res, map[width]);
                }
            }

            Console.Write(wall.Count - res);
            Console.Read();
        }
    }
}
