using System;
public class Program{
    public static void Main(string [] args){
        Console.WriteLine("Enter Your Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Number of subjects");
        int subjects = int.Parse(Console.ReadLine());
        
        Dictionary<string, int> store = buildDictionary(subjects);
        int grade = calculator(store);
        display(store, name, grade);

    }
    public static Dictionary<string, int> buildDictionary(int subjects){
        Dictionary<string, int> store =  new Dictionary<string, int>();
        
        for (int i = 1; i <= subjects; i++){
            Console.WriteLine("Enter the subject");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter the grade");
            int grade = int.Parse(Console.ReadLine());

            while(grade < 0 || grade > 100){
                Console.WriteLine("Invalid grade please enter the correct grade");
                grade = int.Parse(Console.ReadLine());
            }
            store.Add(subject, grade);
        }
        return store;
    }

    public static int calculator(Dictionary<string, int> store){
        int sum = 0;
        int count = 0;

         foreach (KeyValuePair<string, int> kvp in store)
            {
                sum += kvp.Value;
                count += 1;
            }
        return sum / count;
}
public static void display(Dictionary<string, int> store, string name, int grade){
    Console.WriteLine();
    Console.WriteLine($"{name}'s Report Card");

    foreach (KeyValuePair<string, int> kvp in store){
        Console.WriteLine("   {0}--------{1}", kvp.Key, kvp.Value);
    }

    Console.WriteLine($"   Average result------{grade}");

}
}

