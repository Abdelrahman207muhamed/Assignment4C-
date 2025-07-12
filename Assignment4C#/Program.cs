using System.Runtime.InteropServices;

namespace Demo04C_
{
    //1.Classes     ->Function
    //2.Struct      ->Function
    //3.Interfaces  ->Function
    //4.Enum 

    //Entry Point

    //class NewData 
    //{
    //    public int Sum;
    //    public int Mul;




    //}
    internal class Program
    {

        //static void Printshape()
        //{
        //    // Body:
        //    for (int i =0;i<=10;i++)
        //    {
        //        Console.WriteLine("^_^");
        //    }

        //}

        //static void Printshape( string pattern="%_%", int count = 4)
        //{
        //    // Body:
        //    for (int i = 0; i <= count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }

        //}

        //static int SumNumbers(int Number01, int Number02)
        //{ 
        //    return Number01 + Number02; 

        //}


        //static void SWAP(int X, int Y) 
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}





        //static void SWAP(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}





        //static int SumArray(int[] Arr) 
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum; 
        //} 




        //static int SumArray(  int[] Arr)
        //{

        //    int Sum = 0;

        //    Arr = new int[] { 4, 5, 6 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}


        //static int SumArray(ref int[] Arr)
        //{

        //    int Sum = 0;

        //    Arr = new int[] { 4, 5, 6 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}



        //static int[] SumMul(int X, int Y )
        //{
        //    int[] result = { X + Y, X * Y };
        //    return result;  
        //}





        //static NewData SumMul(int X, int Y)
        //{
        //   NewData date =new NewData();
        //    date.Sum = X + Y;
        //    date.Mul = X * Y;

        //    return date;
        //}


        //static void SumMul(int X, int Y,out int Sum,out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;

        //}


        //static int SumArray(params int[] Arr)
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];

        //    }
        //    return Sum;
        //}



        static void Main()
        {

            #region One D Array
            // int[] Numbers;
            //Declare for Reference (Pointer) From Type 'Array Of Integers'
            //Numbers:Can Refer to object from type 'Array of integre'
            //Numbers:Refer to NULL

            //8 byte will be Allocated at Stack for the reference 'Numbers'
            //0 byte will be Allocated at HEAP

            //Numbers =new int[size];
            // Numbers = new int[5];
            //new
            //1.Allocate the number of required bytes for the object at HEAP (4 Bytes*5 )       
            //2.Initialized the Allocated Bytes With The Default value OF the Datatypes
            //3.Call User -defined Constructor  if exists
            //4.Assign the object to the reference 'Numbers'

            // Console.WriteLine(Numbers[0]);

            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[3] = 11;
            //Numbers[4] = 19;
            //// Numbers[5] = 20;    //System.IndexOutOfRangeException: Index was outside the bounds of the array (invalid)
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] Numbers02 = new int[4] { 1, 2, 3, 4 };
            //int[] Numbers03 = new int[6] { 1, 2, 3, 4, 0 ,0};
            //int[] Numbers04 = new int[6];

            //Console.WriteLine("Enter  Numbers [0] ");
            //Numbers[0] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter  Numbers [1] ");
            //Numbers[1] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter  Numbers [2] ");
            //Numbers[2] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter  Numbers [3] ");
            //Numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter  Numbers [4] ");
            //Numbers[4] = int.Parse(Console.ReadLine());

            //for (int i =0;i <Numbers.Length;i++)
            //{

            //    Console.Write(value:$"Enter Numbers[{i}]: ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(value:"==============");
            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    Console.Write(value:$"{Numbers[i]} ");

            //}


            //One D Arrray 

            //Console.WriteLine(Numbers.Length); //Size
            //Console.WriteLine(Numbers.Rank); //Dimension

            // Console.WriteLine(Numbers); //System.Int32[] 
            #endregion


            #region two D Array
            //Two  D Array

            //int[,] Marks = new int[3, 3];

            //Marks[0, 0] = 99;
            //Marks[0, 1] = 80;
            //Marks[0, 2] = 29;

            //Marks[1, 0] = 70;
            //Marks[1, 1] = 60;
            //Marks[1, 2] = 50;

            //Marks[2, 0] = 98;
            //Marks[2, 1] = 80;
            //Marks[2, 2] = 97;

            //Console.WriteLine(Marks[0, 0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);


            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);

            //for (int i =0; i < 3;i++) 
            //{
            //    for (int j = 0; j < 3;j++)
            //    {
            //        Console.Write($"Enter Marks[{i},{j}] : ");
            //        Marks[i, j] = int.Parse(Console.ReadLine());

            //    }

            //}
            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0 ; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i,j]}  ");


            //    }
            //    Console.WriteLine();
            // 
            #endregion}

            #region Two D Juddge Array 
            ////int[][] Marks = = new int[3][];
            ////Marks[0] = new int[] { 1, 2, 3 };
            ////Marks[1] = new int[] { 1, 2 };
            ////Marks[2] = new int[] { 1, 2, 3, 4 };

            //int[][] Marks = new int[3][];
            //Marks[0] = new int[2];
            //Marks[1] = new int[5];
            //Marks[2] = new int[1];

            //for (int i = 0; i < 3; i++)
            //{

            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"Marks[{i}][{j}] :  ");
            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }

            //}

            //for (int i = 0; i < 3; i++)

            //{

            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine($"{Marks[i][j]}");
            //    }
            //}

            #endregion

            #region Functions Prototype And Calling
            //Function: Block OF  Code  That Have  Name If U Need To Execute This Code 
            //U Need To Call The Function By The Name
            //DRY :Don't repeat yourself

            //Function Prototype
            //1.Signature:
            //1.1. Name
            //1.2. return type
            //1.3. parameters (inputs)
            //2.Body(Code)

            //Calling for the functions
            // Printshape(3, "^_^"); //Passing By Order 

            //Printshape(pattern:"^_^",count:3); //Passing by Name
            //Printshape(pattern:"#_#"); //Defualt count
            //Printshape();

            //Methods
            //1.Class member method (Static method)
            //2.Object member method (Non static method)

            //int sum ;

            //Console.WriteLine(SumNumbers(2,3)); 
            #endregion

            #region Passing By Value Type

            ////SumNumbers(10, 20);

            ////Passing By Value
            ////Passing By Reference

            ////Passing Parameter Value Type
            ////1.passing By Value :

            ////int A = 4, B = 5;

            ////Console.WriteLine($"A:{A}");
            ////Console.WriteLine($"B:{B}");

            ////Console.WriteLine("--------After SWAP-------");

            //////SWAP(4,5); // Passing By Value
            ////SWAP(A,B); // Passing By Value


            ////Console.WriteLine($"A:{A}");
            ////Console.WriteLine($"B:{B}");











            ////2.passing By Ref


            //int A = 4, B = 5;

            //Console.WriteLine($"A:{A}");//4
            //Console.WriteLine($"B:{B}");//5

            //Console.WriteLine("--------After SWAP-------");

            ////SWAP(A,B); // Passing By Value
            //SWAP(ref A,ref B); // Passing By Value


            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}"); 
            #endregion

            #region Passing Parameter Reference Type

            //Passing Parameter Reference Type

            //1.Passing By Value

            //int[] Numbers = { 1, 2, 3 };

            //int Result= SumArray(Numbers);  //Passing By Value 

            //Console.WriteLine(Result);

            //Console.WriteLine(Numbers[0]);
            #endregion


            #region Passing By Parameter Reference Type
            //2.Passing By Reference

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(ref Numbers);  //Passing By Ref 
            //// The Address Of The Numbers

            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);


            //Passing Parameters References Type




            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers)); //Passing By Value
            //Console.WriteLine(Numbers[0]);


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers)); //Passing By ref
            ////Copy  Of Numbers 
            //Console.WriteLine(Numbers[0]); 
            //
            #endregion


            #region Passing By  Out
            //int A = 3, B = 4;

            //int[] result = SumMul(A, B);
            //Console.WriteLine(result[0]);  //System.Int32[] ( NameSpace)
            //Console.WriteLine(result[1]);  


            //int A = 3, B = 4;

            //NewData result = SumMul(A, B);

            //Console.WriteLine(result.Mul); 
            //Console.WriteLine(result.Sum);



            //Output Parameter

            //Passing By Out

            //int A = 4, B = 5;

            //SumMul(A, B, out int Sum, out int _);

            //Console.WriteLine(Sum);
            ////Console.WriteLine(Mul);


            #endregion

            #region Params

            //Params


            //int[] Numbers = { 1, 3, 4, 5, 6, 7 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(SumArray(1,2,3,4,5,6,7)); 
            #endregion

        }
    }
}

