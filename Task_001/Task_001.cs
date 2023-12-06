using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_001
{
    public class Task_001
    {
        public const int ROWS = 2;
        public const int COLS = 3;
        public const int MIN = 1;
        public const int MAX = 9;
        public static void Main(string[] args) {
            int[][] array = GetTwoDimensionArrayWithRandomValue(ROWS, COLS);

            System.Console.WriteLine("Оригинальный массив: ");
            System.Console.WriteLine(PrintMultiArray(array));

            System.Console.WriteLine("В какой строке ищем: ");
            int rowPosition = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Из какой колонки выведем значение: ");
            int colPosition = Convert.ToInt32(Console.ReadLine());


            System.Console.Write($"Позиция элемента ({rowPosition},{colPosition}), значение элемента: ");
            string value;
            try {
                value = GetValueInTwoDimensionArray(rowPosition, colPosition, array).ToString();
            } catch(IndexOutOfRangeException e) {
                value = "Вы вышли за пределы массива. " + e;
            }
            System.Console.WriteLine(value);
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

        public static int GetValueInTwoDimensionArray(int row, int col, int[][] array) {
            int result = -1;
            for(int i = 0; i < array.Length; i++) {
                if(i == row) {
                    result = GetValueInArray(col, array[i]);
                }
            }
            return ValidateValue(result);
        }

        public static int GetValueInArray(int position, int[] array) {
            int value = -1;
            for(int i = 0; i < array.Length; i++) {
                if(i == position) {
                    value = array[i]; 
                }
            }
            return ValidateValue(value);
        }

        public static int ValidateValue(int value) {
            if(value == -1) throw new IndexOutOfRangeException();
            return value;
        }

    }
}