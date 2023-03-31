namespace Assesment2
{
    public class Program
    {

        public static string ConvertToLicensePlate(string inputLicenseNumber,int groupLen)
        {
            string resultLicenseNumber = "";
            var helperStack = new Stack<string>();
            int len = inputLicenseNumber.Length - 1;
            //Console.WriteLine(len);
            int j = 1;
            
            while(len >= 0)
            {
                if (inputLicenseNumber[len] != '-') {
                    helperStack.Push(inputLicenseNumber[len].ToString());
                    
                    if(j < groupLen)
                    {
                        j++;
                    }
                    else if (j == groupLen && len - 1 >=0)
                    {
                        helperStack.Push("-");
                        j = 1;
                    }
                    
                    
                }
                len--;
            }
            while(helperStack.Count > 0)
            {
                var item = helperStack.Pop();
                //Console.WriteLine(item.ToString());
                resultLicenseNumber += item.ToUpper();
            }
            Console.WriteLine(resultLicenseNumber);
            return resultLicenseNumber;
            
        }
        static void Main(string[] args)
        {
            ConvertToLicensePlate("5F3Z-2e-9-w", 4);
            ConvertToLicensePlate("2-5g-3-J", 2);

            ConvertToLicensePlate("2-4A0r7-4k", 3);

            ConvertToLicensePlate("nlj-206-fv", 3);



        }
    }
}