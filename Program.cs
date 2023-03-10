namespace StringTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Difference Between 2 time
            var time = new Time();

            Console.Write("Start ucun vaxt qeyd edin:");
            string time1 = Console.ReadLine();
            Console.Write("Finish ucun vaxtin qeyd edin:");
            string time2 = Console.ReadLine();

            var diff = time.Difference(time1, time2);
            time.PrintArray(diff);
            #endregion
            #region CeaserCipher
            var ceaserCipher = new CeaserCipher();

            Console.Write("Enter String for Code:");
            string str = Console.ReadLine();

            var code = ceaserCipher.Code(str, 3);
            ceaserCipher.Print(code);

            Console.Write("Enter String for deCode:");
            string str1 = Console.ReadLine();

            var decode = ceaserCipher.DeCode(str1, 3);
            ceaserCipher.Print(decode);
            #endregion
        }
    }
}