using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter
{
	public class ParkingMeter
	{
		public static void Main()
		{
			decimal amount = 109.34m, deduction = 23.33m;
			Console.WriteLine(ChargeForParking(amount, deduction));
			Console.Read();
		}

		public static string ChargeForParking(decimal amount, decimal deduction)
		{
			if (amount < deduction)
				return $"Please put in an amount of {deduction}, or more!";

			decimal change = amount - deduction;

			return $"Your change is: R{change}";
		}

	}
}
