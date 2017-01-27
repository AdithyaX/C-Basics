﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    public abstract class Bank{
        public abstract void CreateAccount();
        public abstract void DepositeAmount();
         public abstract void WithDrawAmount();
        public   virtual void CalculateInterest(){
            Console.WriteLine(" Intrest is calculated");

        }
        public  virtual void SetInterest(){
            Console.WriteLine(" Interest is set");
        }

        

    }
    public class BharatiBank:Bank{
       public override void  CreateAccount(){
           Console.WriteLine("Your BaharatiBank account is created");
       }
        public override void  DepositeAmount(){
           Console.WriteLine(" Amount is deposited in BaharatiBank ");
       }
           public override void  WithDrawAmount(){
           Console.WriteLine(" Amount is withdrawn from BaharatiBank in");
       }
           public sealed override void CalculateInterest()
           {
               Console.WriteLine(" Bharati  Interest is claculated");

           }
        

    }



    public class RupeeBank:Bank{
       public override void  CreateAccount(){
           Console.WriteLine("Your RupeeBank account is created");
       }
        public override void  DepositeAmount(){
           Console.WriteLine(" Amount is deposited in RupeeBank ");
       }
           public override void  WithDrawAmount(){
           Console.WriteLine(" Amount is withdrawn from RupeeBank");
       }
           public sealed override void CalculateInterest()
           {
               Console.WriteLine("Rupeebank Interest is claculated");

           }


    }


    class BankTester
    {
        static void Main(string[] args)
        {
            Bank b = new BharatiBank();
            b.CreateAccount();
            b.CalculateInterest();
            Console.ReadKey();
        }
    }
}
  