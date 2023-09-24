using System.Security.Cryptography.X509Certificates;

namespace CSharpSelection
{
	public static class SelectionExamples
	{
		public static string FizzBuzz(int num)
		{
			// if statement version for reference
			if (num % 3 == 0 && num % 5 == 0)
			{
				return "FizzBuzz";
			}
			else if (num % 3 == 0)
			{
				return "Fizz";
			}
			else if (num % 5 == 0)
			{
				return "Buzz";
			}
			else
			{
				return Convert.ToString(num);
			}
		}

		public static bool IsVowel(char letter)
		{
			bool isVowel;
			switch (letter)
			{
				case 'a':
					isVowel = true;
					break;
				case 'e':
					isVowel = true;
					break;
				case 'i':
					isVowel = true;
					break;
				case 'o':
					isVowel = true;
					break;
				case 'u':
					isVowel = true;
					break;
				default:
					isVowel = false;
					break;

			}
			return isVowel;
		}



		public static void DiceRoller()
		{
			Random rnd = new Random();
			//Doesn't go to 7, starts at 1
			int num1 = rnd.Next(1, 7);
			int num2 = rnd.Next(1, 7);
			int num3 = rnd.Next(1, 7);

			if (num1 == num2 && num2 == num3)
			{
				Console.WriteLine("three of a kind");
			}
			else if (num1 == num2 || num1 == num3 || num2 == num3)
			{
				Console.WriteLine($"Your numbers are {num1}, {num2} and {num3}");
				Console.WriteLine("you have a pair!");
			}
			
		}
		
		public enum TypeOfAngle
		{
			Acute,
			RightAngle,
			Obtuse,
			Reflex
		}
		public static string DetermineAngle(int angle)
		{
			Console.WriteLine("Enter an integer for an angle (between 1 and 360)");
			Console.ReadLine();

			string type;
			switch (angle)
			{
				case TypeOfAngle.Acute:
					type = "Acute";
					break;
				case TypeOfAngle.RightAngle:
					type = "Right Angle";
					break;
                case TypeOfAngle.Obtuse:
                    type = "Obtuse";
					break;
                case TypeOfAngle.Reflex:
                    type = "Reflex";
					break;
            }
			//use switch statements
		}

		public static void DetermineType(int angle1, int angle2, int angle3)
		{
			if (angle1 == angle2 || angle2 == angle3)
			{
				Console.WriteLine("Triangle is equilateral");
			}
			else if (angle1 == angle2 || angle2 == angle3 || angle1 == angle3)
			{
				Console.WriteLine("Triangle is Isoceles");
			}
			else
			{
				Comsole.WriteLine("Triangle is scalene");
			}
		}

		public static void TotalSales(double ticketsSold, double ticketsPrice)
		{
			if (double.TryParse(ticketsSold) == false || double.TryParse(ticketsPrice) == false)
			{
				Console.WriteLine("Invalid input");
			}
			else
			{
                Console.WriteLine($"£{ticketsSold * ticketsPrice}");
            }

		}

		public static void IsEligible(DateTime birthday)
		{
			if (DateTime.Today - birthday >= )
				//Not finished as struggled to find resource to do this online
		}

	}
}



//        public static void ConditionalOperations(bool hasBrothers, bool hasSisters)
//		{
//			// Conditional OR
//			if (hasBrothers || hasSisters)
//			{
//				Console.WriteLine("You have siblings");
//			}
//			// Conditional AND
//			if (hasBrothers && hasSisters)
//			{
//				Console.WriteLine("You have both brothers and sisters");
//			}
//			// Conditional XOR
//			if (hasBrothers ^ hasSisters)
//			{
//				Console.WriteLine("You have brothers or sisters but not both");
//			}
//			// Conditional NOT
//			if (!hasBrothers)
//			{
//				Console.WriteLine("You do not have brothers");
//			}
//			if (!hasSisters)
//			{
//				Console.WriteLine("You do not have sisters");
//			}
//			if (!hasBrothers && !hasSisters)
//			{
//				Console.WriteLine("You are an only child");
//			}

//		}
//		public static string AssignLetterGrade(int mark)
//		{
//			if (mark < 0 || mark > 100)
//			{
//				throw new ArgumentOutOfRangeException($"Mark should be between 0 and 100");
//			}
//			string grade;
//			if (mark > 80)
//			{
//				grade = "Distinction";
//			}
//			else if (mark > 70)
//			{
//				grade = "Merit";
//			}
//			else if (mark >= 60)
//			{
//				grade = "Pass";
//			}
//			else
//			{
//				grade = "Fail";
//			}
//			return grade;
//		}

//		public static string LiftTakeoff(int numberOfPassengers, double averageWeightInPounds)
//		{
//			// Use of constants
//			const double PoundsToKg = 0.454d;
//			const int LiftCapacity = 600;

//			double weightInKg = averageWeightInPounds * PoundsToKg;
//			double totalWeight = weightInKg * numberOfPassengers;

//			// Ternary operator
//			string message = totalWeight < LiftCapacity ? "Lift good to go" : "Too many people in lift";
//			return message;
//		}

//		//A switch statement is more efficient
//		// The compiler will optimize it to a lookup table
//		// whereas with if/else statements it cannot
//		// Probably will make little difference if the number of cases is small
//		public static decimal DetermineTip(string service)
//		{
//			decimal tip;
//			service = service.ToLower();
//			switch (service)
//			{
//				case "excellent":
//					tip = 0.2m;
//					break;
//				case "good":
//					tip = 0.15m;
//					break;
//				case "ok":
//					tip = 0.1m;
//					break;
//				default:
//					tip = 0m;
//					break;
//			}
//			return tip;
//		}

//		public enum ServiceLevel
//		{
//			Excellent,
//			Good,
//			Ok,
//			Rubbish
//		}
//		public static decimal DetermineTip(ServiceLevel service)
//		{
//			decimal tip;
//			switch (service)
//			{
//				case ServiceLevel.Excellent:
//					tip = 0.2m;
//					break;
//				case ServiceLevel.Good:
//					tip = 0.15m;
//					break;
//				case ServiceLevel.Ok:
//					tip = 0.1m;
//					break;
//				default:
//					tip = 0m;
//					break;
//			}
//			return tip;
//		}

//	}
//}



//public static string FizzBuzz2(int num)
//{
//    string answer;
//    num = num.ToLower();
//    switch (num)
//    {
//        case num % 3 == 0 && num % 5 == 0:
//            answer = "FizzBuzz";
//            break;
//        case num % 3 == 0 && num % 5 != 0:
//            answer = "Fizz";
//            break;
//        case num % 5 == 0 && num % 3 != 0:
//            answer = "Buzz";
//            break;
//        default:
//            answer = Convert.ToString(num);
//            break;
//    }
//    return answer;
//}
