using System;
abstract class OfferLetter
{
    public abstract string Name(string name);
    public abstract string Designation(string designation);
    public abstract string DOJ(string doj);
    public string CompanyName()
    {
        return "Globrin System and solution ltd";

    }
    public string CompanyAddress()
    {
        return "Sohna Road,Gurugram";

    }
    public string CompanyBranding()
    {
        return this.CompanyName() + " Globrin is UK-owned and managed, software development company with its core development operation based in Gurgaon";
    }
    public string Disclaimer()
    {
        return "This letter and its contents are confidential in nature and are intended only \n for the recipient." + "\nIf you are not the correct recipient, kindly return it immediately \n to " + this.CompanyName() + " " + this.CompanyAddress() + ".";
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
        string empName = "Ms Shruti", designation = "Software Developer", doj = "20-03-2025"; 
        Console.WriteLine(ltr.CompanyName() + " is very happy to extend this offer letter to \n" + ltr.Name(empName) + " at the designation of " + ltr.Designation(designation));
        Console.WriteLine("\nYou are required to report at " + ltr.CompanyAddress() + " from " + ltr.DOJ(doj) + " (dd-mm-yyyy).");
        Console.WriteLine("\n\n" + ltr.CompanyBranding());
        Console.WriteLine("\n\n" + ltr.Disclaimer());
    }
}
