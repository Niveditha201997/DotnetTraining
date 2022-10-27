using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqHandOn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                var sales = new List<Sales>()
            {
                new Sales(){ InvoiceId = "INV102", SalesPerson="Bill", Amount=1200,CommissionPaid=60 },
                new Sales(){ InvoiceId = "INV107", SalesPerson="Dave", Amount=4200,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV106", SalesPerson="Paul", Amount=16000,CommissionPaid=0},
                new Sales(){ InvoiceId = "INV103", SalesPerson="Mark", Amount=18000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV101", SalesPerson="Sayeed", Amount=2000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV109", SalesPerson="Christine", Amount=5200,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV108", SalesPerson="Bill", Amount=6000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV104", SalesPerson="Mary", Amount=9800,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV105", SalesPerson="Bill", Amount=12000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV100", SalesPerson="Melissa", Amount=12000,CommissionPaid=0 }
            };
                /* Display all Bill's Sales Records(Both paid and unpaid).
                */

                // Implement here
                var result = from table in sales
                             where table.SalesPerson == "Bill"
                             select table;
                foreach (var item in result)
                {
                    Console.WriteLine(item.SalesPerson + "\t");
                    Console.WriteLine(item.InvoiceId + "\t");
                    Console.WriteLine(item.Amount + "\t");
                    Console.WriteLine(item.CommissionPaid);
                }

                /* Call a method from SalesRep class to pay the sales commission for Bill(only for the sales records with CommissionPaid=0)
                * Display the total commission that has been paid
                */

                // Implement here
                SalesRep salesrep = new SalesRep("Bill", sales);

                List<Sales> result1 = salesrep.SalesUpdate();
                var res = from table in result
                          where table.SalesPerson == "Bill"
                          select table;

                //var res1 = (from table in result
                //          where table.SalesPerson == "Bill"
                //          select table.CommissionPaid).Sum();
                double totalcommission = salesrep.TotalCommisssion();

                foreach (var item in res)
                {
                    Console.Write(item.SalesPerson + "\t");
                    Console.Write(item.InvoiceId + "\t");
                    Console.Write(item.Amount + "\t");
                    Console.Write(item.CommissionPaid + "\n");
                    Console.WriteLine();
                }
                Console.WriteLine(totalcommission + " is total commission");


            }

        }
        public class Sales
        {
            public string InvoiceId { get; set; }
            public string SalesPerson { get; set; }
            public double Amount { get; set; }
            public double CommissionPaid { get; set; }

        }


        public class SalesRep
        {
            public string SalesPerson { get; }
            public List<Sales> SalesList { get; }

            public SalesRep(string salePerson, List<Sales> salesList)
            {
                SalesPerson = salePerson;
                SalesList = salesList;

            }

            public List<Sales> SalesUpdate()
            {
                foreach (var item in SalesList)
                {
                    if (item.SalesPerson == SalesPerson && item.CommissionPaid == 0)
                    {
                        if (item.Amount <= 2000)
                        { item.CommissionPaid = 0.05 * item.Amount; }
                        else if (item.Amount > 2000 && item.Amount <= 10000)
                        { item.CommissionPaid = 0.04 * item.Amount; }
                        else { item.CommissionPaid = 0.03 * item.Amount; }

                    }

                }



                return SalesList;
            }


            /* Write a method to pay the sales commission for the Sales made by this salesperson
            *
            * Assumptions:
            * Only the unpaid sales(CommissionPaid=0) records will be used for payment
            *
            *
            * Calculation for the CommissionPaid:
            * Sales commission is calculated as described below
            * 5% of the invoice amount <= $2000 +
            * 4% of the invoice amount >$2000 and <=$10000 +
            * 3% of the invoice amount >$10000
            * For examples,
            * 1. If Amount is 1000 then CommissionPaid will be $50
            * 2. If Amount is 6000 then CommissionPaid will be 260
            * 3. If Amount is 12000 then CommissionPaid will be $480
            *
            * Pay
            * _salesList.CommissionPaid should be updated with the correct amount as described above
            * Method should return the total commission just paid.
            */


            // Implement here
            public double TotalCommisssion()
            {

                var res1 = (from table in SalesList
                            where table.SalesPerson == "Bill"
                            select table.CommissionPaid).Sum();

                return res1;
            }

        }

    }

}
    

