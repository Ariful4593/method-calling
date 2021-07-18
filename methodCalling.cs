using System;
namespace MethodCalling{
	public class NumberManipulator{
		
		public int Findmax(int num1, int num2){
			int result;
			if(num1 > num2){
				result = num1;
			}else{
				result = num2;
			}
			return result;
		}
		
		public static void Main(string[] args){
			int a = 100;
			int b = 200;
			int ret;
			NumberManipulator number = new NumberManipulator();
			ret = number.Findmax(a, b);
			Console.WriteLine("Max value is: {0}", ret);
			
		}
	}
}

