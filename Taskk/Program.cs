namespace Taskk
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          List<string> NameList = new List<string> { "Moa", "Shadi", "Faris" };
          string[] stringArray = ListToArray(NameList);
          
          List<int> NumbersList = new List<int> { 1, 2, 3, 4, 5 };
          int[] intArray = ListToArray(NumbersList);
          
          List<User> UserList = new List<User>
          {
            new User { Name = "Moa", Age = 15 },
            new User { Name = "Shadi", Age = 26 }
          };
          User[] UserArray = ListToArray(UserList);
          
        }
        static T[] ListToArray<T>(List<T> list)
        {
            T[] array = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            return array;
        }

    }
}