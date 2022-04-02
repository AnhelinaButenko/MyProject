using System;

namespace REF
{
    class Program
    {
        //Изменить размер

        //static void Resize<T>(ref T[] array, int newSize)
        //{
        //    T[] newArray = new T[newSize];
        //    for (int i = 0; i < newArray.Length && i < array.Length; i++)
        //    {
        //        newArray[i] = array[i];
        //    }
        //    array = newArray;
        //}

        //static void Main(string[] args)
        //{
        //    //int[] myArray = { 4, 7, 9, 8};
        //    //Resize(ref myArray, 8);


        //    string[] strArray = { "fgh", "tyuk", "fghjk" };
        //    Resize(ref strArray, 8);
        //}




        //ДОБАВИТЬ ЭЛЕМЕНТ В МАССИВ | в конец массива |  по индексу


        //static int[] addElement(ref int[] myArray, int newElement)
        //{
        //    int[] newArray = new int[myArray.Length + 1];

        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //       newArray[i] = myArray[i];
        //    }
        //    newArray[newArray.Length - 1] = newElement;

        //    ////myArray = newArray;

        //    return newArray;
        //}

        //static void Main(string[] args)
        //{
        //    int[] Array = { 1, 2, 3 };
        //     Array = addElement(ref Array, 4);
        //}


        //ДОБАВИТЬ ЭЛЕМЕНТ В МАССИВ в начало массива 

        //static int[] eddElementToTheBegining(ref int[] myArray, int newElement)
        //{
        //    int[] newArray = new int[1 + myArray.Length];
        //    newArray[0] = newElement;


        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        newArray[i + 1] = myArray[i];
        //    }

        //    return newArray;
        //}


        //static void Main(string[] args)
        //{
        //    int[] array = { 2, 7, 1 };
        //    array = eddElementToTheBegining(ref array, 4);
        //}




        //ДОБАВИТЬ ЭЛЕМЕНТ В МАССИВ  по индексу 2

        //static int[] AddElementByIndex(int[] myArray, int index,int newElement)
        //{
        //    int[] newArray = new int[1 + myArray.Length];

        //    for (int i = 0; i < index; i++)
        //    {
        //        newArray[i] = myArray[i];               
        //    }

        //    newArray[index] = newElement;

        //    for (int i = index; i < myArray.Length; i++)
        //    {                
        //        newArray[i + 1] = myArray[i];
        //    }

        //    return newArray;
        //}

        //static void Main(string[] args)
        //{
        //    int[] Array = { 5, 4, 3, 2 };
        //    Array = AddElementByIndex(Array, 2, 8);
        //}





        //УДАЛИТЬ ЭЛЕМЕНТ ИЗ МАССИВА  первый элемент 

        static void DeleteByFirstElement(ref int[] myArray)
        {
            if (myArray.Length == 0)
            {
                return;
            }
            
            int[] newArray = new int[myArray.Length - 1];

            for (int i = 1; i < myArray.Length; i++)
            {
                newArray[i - 1] = myArray[i];
            }
            myArray = newArray;
        }


        //УДАЛИТЬ ЭЛЕМЕНТ ИЗ МАССИВА последний элемент 

        static void DeleteByLastElement(ref int[] myArray)
        {
            if (myArray.Length == 0)
            {
                return;
            }

            int[] newArray = new int[myArray.Length - 1];

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                newArray[i] = myArray[i];
            }
            myArray = newArray;
        }

        //УДАЛИТЬ ЭЛЕМЕНТ ИЗ МАССИВА по индексу

        static void DeleteByIndexElement(ref int[] myArray, int index)
        {

            if (myArray.Length == 0)
            {
                return;
            }

            int[] newArray = new int[myArray.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int i = index + 1; i < myArray.Length; i++)
            {
                newArray[i - 1] = myArray[i];
            }

            myArray = newArray;
        }      

        static void Main(string[] args)
        {
            //int[] array = { 8, 7, 4, 9 };
            int[] array = new int[0];
            
            DeleteByIndexElement(ref array, 0);

            DeleteByLastElement(ref array);

            DeleteByFirstElement(ref array);

            Console.ReadKey();

        }

        
    }
}
