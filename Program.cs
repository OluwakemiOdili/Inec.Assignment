namespace Inec.Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //number 2//
          
            string[] voters = { };
            var set = new HashSet<string>();
            var dup = voters.Where(x => !set.Add(x)).Distinct();

            Console.WriteLine(string.Join(" ,", dup));


            //number 1//

            string[] names = {"Oluwakemi Odili","Baba Sala", "Toyosi Adetutu","Babawale Olushogbon","Baby Sanders","Tobiloba bakare",
                "Valerie Adesuwa","Hope Chukwu","Joy Azunna","Wale Ola", "Kelvin Hart", "Babs Esther","White Shark", "Small Baby", };
            var duplicates = names.GroupBy(x => x)
            .Where(g => g.Count() > 1)
                .Select(y => new { item = y.Key, count = y.Count() })
                .ToList();

            Console.WriteLine(string.Join(" \n", duplicates));
        }
    }
}