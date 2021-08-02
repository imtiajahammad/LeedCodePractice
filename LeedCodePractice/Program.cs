using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#random1->start--Remove Duplicates from Sorted Array");
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            Remove_Duplicates_from_Sorted_Array random1 = new Remove_Duplicates_from_Sorted_Array(nums);
            Console.WriteLine("#random1->end--Remove Duplicates from Sorted Array");

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("#random2->start--ValidSudoku");
            Console.WriteLine();
            ValidSudoku random2 = new ValidSudoku();
            Console.WriteLine();
            Console.WriteLine("#random2->end--ValidSudoku");




            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("#random3->start--transpose-matrix");
            Console.WriteLine();
            Transpose_Matrix transposematrix = new Transpose_Matrix();
            Console.WriteLine();
            Console.WriteLine("#random3->end--transpose-matrix");


            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("#random3->start--Rotate_Image");
            Console.WriteLine();
            Rotate_Image Rotate_Image = new Rotate_Image();
            Console.WriteLine();
            Console.WriteLine("#random3->end--Rotate_Image");


            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("#random3->start--Reverse_String");
            Console.WriteLine();
            Reverse_String Reverse_String = new Reverse_String();
            Console.WriteLine();
            Console.WriteLine("#random3->end--Reverse_String");
            

            Console.ReadKey();
        }
    }
}
