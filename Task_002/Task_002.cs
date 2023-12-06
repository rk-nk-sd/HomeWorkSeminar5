using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_002
{
    public class Task_002
    {
        public const int ROWS = 3;
        public const int COLS = 3;
        public const int MIN = 1;
        public const int MAX = 9;
        public static void Main(string[] args) {
            int[][] array = GetTwoDimensionArrayWithRandomValue(ROWS, COLS);

            System.Console.WriteLine("Оригинальный массив: ");
            System.Console.WriteLine(PrintMultiArray(array));

            System.Console.WriteLine("Первая и последняя строка в двумерном массиве поменялись местами: ");
            System.Console.WriteLine(PrintMultiArray(ChangeFirstAndLastStrings(array)));

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

        public static int[][] ChangeFirstAndLastStrings(int[][] arrays) {
            int[] temp = arrays[0];
            int lastRow = arrays.Length - 1;

            arrays[0] = arrays[lastRow];
            arrays[lastRow] = temp;

            return arrays;
        }
    }
}