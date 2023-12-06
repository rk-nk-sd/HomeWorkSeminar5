using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Task_004
{
    public class Task_004
    {
        public const int ROWS = 3;
        public const int COLS = 3;
        public const int MIN = 1;
        public const int MAX = 9;
        public static void Main(string[] args) {
            int[][] array = GetTwoDimensionArrayWithRandomValue(ROWS, COLS);

            System.Console.WriteLine("Оригинальный массив: ");
            System.Console.WriteLine(PrintMultiArray(array));

            System.Console.WriteLine("Новый массив: ");
            System.Console.WriteLine(PrintMultiArray(GetNewToDimentionalArray(array)));
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

        public static int[][] GetNewToDimentionalArray(int[][] array) {
            int minVal = int.MaxValue;
            for(int i = 0; i < array.Length; i++) {
                if(minVal > array[i].Cast<int>().Min()) {
                    minVal = array[i].Cast<int>().Min();
                }
            }

            int rowExcluded = 0;
            int colExcluded = 0;
            for(int i = 0; i < array.Length; i++) {
                if(array[i].Min() == minVal) {
                    rowExcluded = i;
                    colExcluded = Array.IndexOf(array[i], minVal);
                    break;
                }
            }

            int rowIndex = 0;
            int[][] newArray = new int[array.Length - 1][];
            for(int i = 0; i < array.Length; i++) {
                if(i != rowExcluded) {
                    newArray[rowIndex] = GetArrayWithoutOneColumn(colExcluded, array[i]);
                    rowIndex ++;
                }
            }
            return newArray;
        }

        public static int[] GetArrayWithoutOneColumn(int colExcluded, int[] array) {
            int colIndex = 0;
            int[] newArray = new int[array.Length - 1];
            for(int i = 0; i < array.Length; i++) {
                if(i != colExcluded) {
                    newArray[colIndex] = array[i];
                    colIndex ++;
                }
            }
            return newArray;
        }


    }
}