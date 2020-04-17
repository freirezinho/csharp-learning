using System;

namespace nullables
{
  class Program
  {
    static void Main(string[] args)
    {
      Customer customerA = new Customer();
      customerA.PermanentAddress = "Permanent address for Customer A.";
      Customer customerB = new Customer();
      customerB.LocalAddress = "Local address for Customer B.";
      Customer customerC = new Customer();
      customerC.OfficeAddress = "Office Address for Customer C.";
      Customer customerD = new Customer();

      string addressForCustomerA = null;
      string addressForCustomerB = null;
      string addressForCustomerC = null;
      string addressForCustomerD = null;

      addressForCustomerA = customerA.PermanentAddress ?? customerA.LocalAddress ?? customerA.OfficeAddress ?? "No address provided for Customer A.";
      addressForCustomerB = customerB.PermanentAddress ?? customerB.LocalAddress ?? customerB.OfficeAddress ?? "No address provided for Customer B.";
      addressForCustomerC = customerC.PermanentAddress ?? customerC.LocalAddress ?? customerC.OfficeAddress ?? "No address provided for Customer C.";
      addressForCustomerD = customerD.PermanentAddress ?? customerD.LocalAddress ?? customerD.OfficeAddress ?? "No address provided for Customer D.";


      Console.WriteLine("Address for Customer A : " + addressForCustomerA);
      Console.WriteLine("Address for Customer B : " + addressForCustomerB);
      Console.WriteLine("Address for Customer C : " + addressForCustomerC);
      Console.WriteLine("Address for Customer D : " + addressForCustomerD);

    }
  }
  class Customer
  {
    string permanentAddress = null;
    string localAddress = null;
    string officeAddress = null;

    public string PermanentAddress
    {
      get
      {
        return permanentAddress;
      }
      set
      {
        permanentAddress = value;
      }
    }
    public string LocalAddress
    {
      get
      {
        return localAddress;
      }
      set
      {
        localAddress = value;
      }
    }
    public string OfficeAddress
    {
      get
      {
        return officeAddress;
      }
      set
      {
        officeAddress = value;
      }
    }
  }
}
