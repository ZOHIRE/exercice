using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int64 myvar = 122222;
            //UInt64
            //long myvar4 = 122222;
            //ulong myvar8 = 122222;
            //Int32 myvar1 = 122222;
            //UInt32
            //int myvar3 = 122222;
            //uint myvar9 = 122222;
            //UInt16
            //short myvar5 = 12222;
            //ushort myvar10 = 12222;
            //Int16 myvar2 = 12222;
            //sbyte myvar6 = -122;
            //byte myvar7 = 122;


            string s = @"my name i ""zohire"" ,and i lov programing";
            string s1 = @"C:\Users\walid\Documents\Scanned Documents\Documents";
            string s3 = s1 + s;
            Console.WriteLine($"{s}\n\n, {s1}\n\n, {s3}");


            float flo1 = 10.5f;
            float flo2 = 5.25f;
            float flo3 = 12 / 2;
            float flo9 = (flo1 + flo2) * flo3;

            Console.WriteLine($"{flo1}, \n{flo2}, \n{flo9}");

            //basig operator / *+- %
            //BITWISE OPERATION
            //logical operator boolan trua ou false

            //unaary operands
            //binary operands
            //3 operands

           float imyvar1 = 7;
            float imyvar2 = 2;
            float temp = imyvar1++ / ++imyvar2;
            Console.WriteLine($"{temp}");

           // asignments operation عمليات المهام او عمليات التخصيص

            int myvar1 = 7;
            int myvar2 = 2;
            // myvar1 = myvar2;        
            // myvar1 += myvar2;
            // myvar2 /= myvar1;
            // myvar1 -= myvar2;
            myvar1 /= ++myvar2;




            Console.WriteLine("\t the result = {0}\n\n\t my var2value = {1}", myvar1, myvar2);


           // boolan comporation  == , != , < , > , <= , >= ,
          // boolan condition  &&  ||

            bool theresult1,theresult2,theresult3,theresult4,theresult5,theresult6,theresult7,theresult8,theresult9,theresult10,theresult11,
                theresult12,theresult13,theresult14,theresult15,theresult16;

            int myvare1 = 5, myvare2 = 9;
            theresult1 = myvare1 == 2 && myvare2 == 9;  //  False + True =  False
            theresult2 = myvare1 == 5 && myvare2 == 9;  //  True  + True =  True
            theresult3 = myvare1 == 5 && myvare2 == 29; //  True  + False = False
            theresult4 = myvare1 == 7 && myvare2 == 29; //  False + False = False

            theresult5 = myvare1 == 2 || myvare2 == 9;  //  False + True =  True
            theresult6 = myvare1 == 5 || myvare2 == 9;  //  True  + True =  True
            theresult7 = myvare1 == 5 || myvare2 == 29; //  True  + False = True
            theresult8 = myvare1 == 7 || myvare2 == 29; //  False + False = False
            theresult9 = myvare1 < 8;
            theresult10 = myvare1 > 5;
            theresult11 = myvare1 <= 2;
            theresult12 = myvare1 >= 5;
            theresult13 = myvare2 < 9;
            theresult14 = myvare2 > 7;
            theresult15 = myvare2 <= 9;
            theresult16 = myvare2 >= 9;










            Console.WriteLine($"\n\n\t{theresult1},\n\n\t{theresult2}, \n\n\t{theresult3}, \n\n\t{theresult4},\n\n\n\t{theresult5},\n\n\t{theresult6}, \n\n\t{theresult7}, \n\n\t{theresult8},\n\n\t{theresult9},\n\n\t{theresult10}, \n\n\t{theresult11}, \n\n\t{theresult12},\n\n\n\t{theresult13},\n\n\t{theresult14}, \n\n\t{theresult15}, \n\n\t{theresult16}");







            //if statment   اف الشرطية الجمل الشرطية

            int myvare3 = 10;
            if (myvare3 == 9)
                Console.WriteLine("my vare3 equel 10");
            else
                Console.WriteLine("my vare3 is not equel 10");

            int myvare4 = 12;
            if (myvare4 < 10)

                Console.WriteLine("my variable value lesse than 10");

            else
                if (myvare4 > 10)
                Console.WriteLine("my variable value is greater than 10");

            int myvare5 = 8;
            if (myvare5 < 9)
                Console.WriteLine("my variable value is  less than 9 ");
            if (myvare5 > 6)
                Console.WriteLine("my variable value is  greater than 6 ");
            if (myvare5 == 8)
                Console.WriteLine("my variable value is  equel 8 ");

            //e2xample
            bool theresult17, theresult18;
            int var1 = 10, var2 = 5, var3 = 9;
            theresult17 = ((var1 <= 11) || ((var2 == 5) && (var3 >= 8)));
            theresult18 = ((var1 <= 10) || ((var2 == 6) && (var3 >= 8)));
            Console.WriteLine($"{theresult17}, {theresult18}");



















            Console.ReadKey();






        }
    }
}

