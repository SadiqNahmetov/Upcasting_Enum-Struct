using System;
using Upcasting.Models;
using static Upcasting.Models.Roless;

namespace Upcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //int[] arr = { 1, 2, 3, 4, };
            //GetElements(1, 2, 3, 4, 5, 5, 6, 7, 8, 10);

            //Sum(arr);
            #endregion

            //Test test = new Test();
            //Console.WriteLine(test.Number);
            //string name = null;
            //int? age = null;
            //Console.WriteLine(age);

            ////var result = age == null ? 55 : 60;
            //var result = age ?? Sum();
            //Console.WriteLine(result);

            Test test = null;
            Console.WriteLine(test.Word.ToString());

        }
        static int Sum()
        {
            return 1;
        }

        #region Params
        //private static void Sum(int[] arr)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void GetElements(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9, int v10)
        //{
        //    throw new NotImplementedException();
        //}


        #endregion
       
        #region Params 
        //public static void GetElements(params int[] nums)
        //{
        //    foreach(var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //static void Sum(int[] arr)
        //{

        //}

        #endregion
        #region Roles   
        //public static void CheckRole(int roleId)
        //{

        //    switch (roleId)
        //    {
        //        case (int)Roles.SuperAdmin:
        //            Console.WriteLine("Super admin");
        //            break;

        //        case (int)Roles.Admin:
        //            Console.WriteLine("Admin");
        //            break;

        //        case (int)Roles.Menber:
        //            Console.WriteLine("Menber");
        //            break;

        //        default:
        //            Console.WriteLine("Not found role id");
        //            break;
        //    }

        #endregion


    }

 }


