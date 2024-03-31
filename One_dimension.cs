using System;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;
namespace Task3_1
{
	public class One_dimension<Tip>
	{
        private Tip[] array;
        public  const int sizeOf = 8;
        public One_dimension() : this(sizeOf)
        {
        }
        public One_dimension(int sizeOf2){
            array = new Tip[sizeOf2];

        }
        public void Count_Length_Massive(){
            int count = 0;
            for(int i =0; i<array.Length; i++){
                count++;
            }
            Console.WriteLine(count);
        }
        public 
        public void GetMaxMin(){
            int min = 999999999;
            int max = -999999999;
            for(int i = 0;i < array.Length; i++ )
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        public void GetElemetsFromIndex(int index, int count){
            int[] resultArray = new int[count];
            Array.Copy(array, index, resultArray, 0, count);
            foreach (int element in resultArray){
                Console.WriteLine(element);
            }
        }

         public void PEREVOROT(){
            for (int i = 0; i < array.Length; i++){
                array[i] = array[array.Length-1-i];
            }
            for (int i = 0; i < array.Length; i++){
                Console.Write($"{array[i]} ");
            }
        }
        public void ElementInArray(Predicate<Tip> M)
        {
            bool elementin = false;
            for (int i = 0; i < array.Length; i++){
                if (M(array[i])){
                    elementin = true;
                }
            }
            Console.WriteLine(elementin);
        }

        public void Elem1inarray(Predicate<Tip> M){
            int count = 0;
            while (!M(array[count])){
                count+=1;
            }
            Console.WriteLine(array[count]);
        }
        public void ActionForAll(Action<Tip> Action){
            for (int i = 0; i < array.Length; i++){
                Action(array[i]);
            }
        }
       static void AddElementToArray(ref int[] array, int element){
            bool isFull = true;
            for (int i = 0; i < array.Length; i++){
                if (array[i] == 0)
                {
                    array[i] = element;
                    isFull = false;
                    break;
                }
            }

            if (isFull){
                int newCapacity = array.Length * 2 + 1;
                int[] newArray = new int[newCapacity];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
                AddElementToArray(ref array, element);
            }
        }
        public void SORTARRAY(){
            Array.Sort(array);

            Console.WriteLine("Отсортированный массив:");
            for(int i = 0; i< array.Length; i++){
                Console.Write(i + " ");
            }
        }
        public void CheckForAlll(Predicate<Tip> M)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (M(array[i]))
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

    }

}



