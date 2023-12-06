using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_003
{
    public class Task_003
    {
        public const int ROWS = 3;
        public const int COLS = 3;
        public const int MIN = 1;
        public const int MAX = 9;
        public static void Main(string[] args) {
            int[][] array = GetTwoDimensionArrayWithRandomValue(ROWS, COLS);

            System.Console.WriteLine("Оригинальный массив: ");
            System.Console.WriteLine(PrintMultiArray(array));

            int index = GetIndexStringInArrayWithMinSum(array);
            System.Console.WriteLine($"Строка с индексом {index}");
        }

        public static int[][] GetTwoDimensionArrayWithRandomValue(int rows, int cols) {
            int[][] twoDimensionalArray = new int[rows][];
            for(int i = 0; i < rows; i++) {
                twoDimensionalArray[i] = GetArrayWithRandomValue(cols);
            }
            return twoDimensionalArray;
        }

        public static int[] GetArrayWithRandomValue(int size) {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;
        }

        public static string PrintArray(int[] array) {
            string result = "";
            foreach(int item in array) {
                result = result + item + "\t";
            }
            return result.Trim();
        }

        public static string PrintMultiArray(int[][] array) {
            string result = "";
            for(int i = 0; i < array.Length; i++) {
                result = result + PrintArray(array[i]) + "\n";
            }
            return result;
        }

        public static int GetIndexStringInArrayWithMinSum(int[][] array) {
            int[] sum = GetArrayWithMinSum(array);
            return Array.IndexOf(sum, sum.Min());
        }

        public static int[] GetArrayWithMinSum(int[][] array) {
            int[] sum = new int[array.Length];
            for(int i = 0; i < array.Length; i++) {
                sum[i] = GetSum(array[i]);
            }
            return sum;
        }

        public static int GetSum(int[] array) {
            int sum = 0;
            foreach(int item in array) {
                sum = sum + item;
            }
            return sum;
        }
    }
}