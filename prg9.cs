using System;
abstract class OfferLetter
{
    public abstract string Name(string name);
    public abstract string Designation(string designation);
    public abstract int Payment(int pay);
    public abstract string DOJ(string doj);
    public string CompanyName()
    {
        return "XYZ Corporation Pvt. Ltd.";
        
    }
    public string OfficeAddress()
    {
     return "512, Manhattan, NY";
        
    }
    public string CompanyBranding()
    {
        return this.CompanyName() + " is a privately owned regsitered corporation operating \n under the license provided by the state of New York.";
    }
    public string Disclaimer()
    {
      return "This letter and its contents are confidential in nature and are intended only \n for the recipient."+"\nIf you are not the correct recipient, kindly return it immediately \n to " + this.CompanyName() + " " + this.OfficeAddress() + ".";
    }
    }
    class PrintOfferLetter : OfferLetter
    {
        public override string Name(string name)
        {
            return name;
            
        }
        public override string Designation(string designation)
        {
            return designation;
            
        }
        public override int Payment(int pay)
        {
            return pay;
            
        }
        public override string DOJ(string doj)
        {
            return doj;
            }
        
    }
    public class Program
    {
        public static void Main()
        {
            PrintOfferLetter ltr = new PrintOfferLetter();
            string empName = "Mr. ABC", designation = "Senior Consultant", doj = "20-02-2020";int pay = 50000;
            Console.WriteLine(ltr.CompanyName() + " is very happy to extend this offer letter to \n" + ltr.Name(empName)+ " at the designation of " + ltr.Designation(designation) + " with an annual pay of " + ltr.Payment(pay) + "$.");
            Console.WriteLine("\nYou are required to report at " + ltr.OfficeAddress() + " from " + ltr.DOJ(doj) + " (dd-mm-yyyy).");
            Console.WriteLine("\n\n" + ltr.CompanyBranding());
            Console.WriteLine("\n\n" + ltr.Disclaimer());
}
}
Output-
  XYZ Corporation Pvt. Ltd. is very happy to extend this offer letter to 
Mr. ABC at the designation of Senior Consultant with an annual pay of 50000$.

You are required to report at 512, Manhattan, NY from 20-02-2020 (dd-mm-yyyy).


XYZ Corporation Pvt. Ltd. is a privately owned regsitered corporation operating 
 under the license provided by the state of New York.


This letter and its contents are confidential in nature and are intended only 
 for the recipient.
If you are not the correct recipient, kindly return it immediately 
 to XYZ Corporation Pvt. Ltd. 512, Manhattan, NY.
