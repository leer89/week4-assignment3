using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * CITP180 - Assignment 3
 * Programming Exercises, Problems 3, 4, 6, 7, and 10
 */

namespace week4_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            displayProblem(3);
            problem3();
            displayProblem(4);
            problem4();
            displayProblem(6);
            problem6();
            displayProblem(7);
            problem7();
            displayProblem(10);
            problem10();
        }

        public static void problem3()
        {
            /*
            Write an application that allows a user to input the height and width of a
            rectangle and output the area and perimeter. Use methods for entering the
            values, performing the computations, and displaying the results. Results
            should be formatted and printed in a tabular display.
            */

            int height, width, area, perimeter;

            Console.WriteLine("Height: ");
            var h = Console.ReadLine(); // var is local variable to this function

            Console.WriteLine("Width: ");
            var w = Console.ReadLine(); // var is local variable to this function

            height = int.Parse(h);
            width = int.Parse(w);

            area = height * width;
            perimeter = (2 * height) + (2 * width);

            Console.WriteLine("Height:\t\t" + height);
            Console.WriteLine("Width:\t\t" + width);
            Console.WriteLine("Area:\t\t" + area);
            Console.WriteLine("Perimeter:\t" + perimeter);
        }

        public static void problem4()
        {
            int secs, minutes, hours;

            Console.WriteLine("Seconds: ");
            var s = Console.ReadLine();

            secs = int.Parse(s);

            minutes = secs / 60;

            var leftoverSeconds = secs % 60;

            hours = minutes / 60;

            var leftoverMinutes = minutes % 60;

            Console.WriteLine("Hours:\t\t" +  hours + "\nMinutes:\t" + leftoverMinutes + "\nSeconds:\t" + leftoverSeconds);
        }   

        public static void problem6()
        {
            double meters;
            Console.WriteLine("Meters: ");
            var m = Console.ReadLine();
            meters = Double.Parse(m);
            metersToFeet(meters);
        }

        // Problem 6's meters to feet/inches method
        public static void metersToFeet(double meters)
        {
            double feet;
            double inches;
            feet = meters * 3.28084;
            inches = feet * 12;

            Console.WriteLine("Meters:\t" + meters + "\nFeet:\t" + feet + "\nInches:\t" + inches);
        }

        public static void problem7()
        {
            /*  
            Write a program that can be used to determine the tip amount that should
            be added to a restaurant charge. Allow the user to input the total, before
            taxes and the tip percentage (15% or 20%). Produce output showing the
            calculated values including the total amount due for both the 15% and the
            20% tips. Tax of 9% should be added to the bill before the tip is determined.
            Write appropriate methods for your solution.
            */

            // Problem 7

            double bill, taxedBill, bill15, bill20;
            const double tax = 1.09;
            const double tip15 = 1.15;
            const double tip20 = 1.2;

            Console.WriteLine("Bill: ");
            var b = Console.ReadLine();
            bill = Double.Parse(b); // initialize bill

            taxedBill = bill * tax;
            Console.WriteLine("Bill with 9% tax:\t" + taxedBill.ToString("C"));

            bill15 = taxedBill * tip15;
            Console.WriteLine("Bill with 15% tip:\t" + bill15.ToString("C"));

            bill20 = taxedBill * tip20;
            Console.WriteLine("Bill with 20% tip:\t" + bill20.ToString("C"));
        }

        public static void problem10()
        {
            /*
            Write an application that helps landowners determine what their property
            tax will be for the current year. Taxes are based on the property’s assessed
            value and the annual mileage rate. The established mileage rate for the
            current year is $10.03 per $1000 value. Homeowners are given a $25,000
            tax exemption, which means they may subtract $25,000 from the assessed
            value prior to calculating the taxable value. Enable users to enter the
            property address and the prior year’s assessed value. The township has
            decided to increase all properties’ assessed value 2.7% for the current year
            to add additional monies to the school budget line. Provide methods to
            compute and return the new assessed value and the proposed taxes for the
            current year. Provide another method that displays the formatted values.
            */

            // Problem 10
            // miliage = 10.03 per 1000 dollars
            // const taxExemption = 25000
            // const township bonus = 0.027

            double lastYearHouseValue, currentYearHouseValue, finalHouseValue;
            string addr;

            const double townshipPercentBonus = 1.027;

            Console.WriteLine("Property Address: ");
            addr = Console.ReadLine();

            Console.WriteLine("Prior Year's Assesed Value: ");
            var priorValue = Double.Parse(Console.ReadLine());

            // get last year house value
            lastYearHouseValue = getLastYearAssessedValue(priorValue);
            // get current house value
            currentYearHouseValue = getThisYearAssessedValue(priorValue);

            // final value
            finalHouseValue = currentYearHouseValue * townshipPercentBonus;

            printValues(addr, lastYearHouseValue, currentYearHouseValue, finalHouseValue);
        }

        public static void printValues(string addr, double lastYearHouseValue, double currentYearHouseValue, double finalHouseValue)
        {
            double mileage;

            Console.WriteLine("Address: " + addr);
            Console.WriteLine("Last Year House Value With No Bonus:\t" + lastYearHouseValue.ToString("C"));
            Console.WriteLine("Current House Value with Bonus:\t\t" + currentYearHouseValue.ToString("C"));
            Console.WriteLine("House Value with SchoolTax Increase:\t" + finalHouseValue.ToString("C"));

            mileage = finalHouseValue / 1000;
            mileage = mileage * 10.03;

            Console.WriteLine("Tax Owed:\t\t\t\t" + mileage.ToString("C"));
        }

        public static double getLastYearAssessedValue(double priorValue)
        {
            double x = 0;

            x = priorValue;

            return x;
        }

        public static double getThisYearAssessedValue(double priorValue)
        {
            double x = 0;
            const int townshipBonus = 25000;

            x = priorValue - townshipBonus;
            
            return x;
        }

        public static void displayProblem(int problemNumber)
        {
            Console.WriteLine("\n/// Problem " + problemNumber);
        }
    }
}