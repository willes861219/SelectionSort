using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("歡迎使用 SelectionSort 排列程式");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n");

            List<int> selectionSort = new List<int>();
            int num = 0;
            while (true)
            {
                num++;
                Console.WriteLine("請輸入要加入列表的第"+ num +"項的值 (限定整數)");

                int number;
                bool success = Int32.TryParse(Console.ReadLine(),out number);
                while(!success)
                {
                     Console.WriteLine("請輸入正確整數值！");
                     success = Int32.TryParse(Console.ReadLine(), out number);
                }

                selectionSort.Add(number);


                Console.Write("目前列表清單 List：");
                for (int i = 0; i < selectionSort.Count; i++)
                {
                    if ( i != selectionSort.Count-1)
                    {
                        Console.Write(selectionSort[i] + ",");
                    }
                    else
                    {
                        Console.Write(selectionSort[i]);
                    }
                }

                Console.WriteLine("\n");
                Console.WriteLine("是否繼續加入整數值？ Y / N");

                bool isTrueAns = false ;
                string inputAns = Console.ReadLine();
                Console.WriteLine("\n");
                while (!isTrueAns)
                {
                    if (inputAns == "Y" || inputAns == "y" ||inputAns == "N" || inputAns == "n")
                    {
                        isTrueAns = true;
                    }
                    else
                    {
                        Console.WriteLine("請輸入Y/y 或 N/n！");
                        inputAns = Console.ReadLine();
                        Console.WriteLine("\n");
                        isTrueAns = false;
                    }
                }

                if (inputAns == "Y" || inputAns == "y")
                {
                    continue;
                }
                else if (inputAns == "N" || inputAns == "n")
                {
                    break;
                }

            }

            for(int i = 0; i < selectionSort.Count; i++) //從第 i 筆資料開始跑
            {
                int minIndex = i;

                for (int j = i+1; j < selectionSort.Count; j++) //跟第 i 筆資料之後的值 做比較
                {
                    if (selectionSort[minIndex] > selectionSort[j]) // i筆資料 如果大於 比較的值
                    {
                        minIndex = j;
                    }
                }
                Swap(selectionSort, i, minIndex); //將最小值和第一個未排序的元素交換位置
            }

            Console.WriteLine("下列為已排序過的List：");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n");
            for (int k = 0; k < selectionSort.Count; k++)
            {
                if (k != selectionSort.Count - 1)
                {
                    Console.Write(selectionSort[k] + ",");
                }
                else
                {
                    Console.Write(selectionSort[k]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("輸入任意建退出");
            Console.ReadKey();
        }

        /// <summary>
        /// 元素交換位置
        /// </summary>
        /// <param name="list">要交換的列表</param>
        /// <param name="index1"> 第一個未排序的元素index </param>
        /// <param name="index2"> 最小值的index</param>
        public static void Swap(List<int> list, int index1, int index2) 
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
