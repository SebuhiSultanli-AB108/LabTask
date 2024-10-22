namespace Table;

class Program
{
    static void Main()
    {
        Colum[] Colums =
            [
            new Colum("Sabuhi", "Sultanli", 19),
            new Colum("Aliyev", "Osman", 30),
            new Colum("Rick", "Astley", 55),
            new Colum("Matsubara", "Miki", 45),
            ];

        bool canContinue = true;
        while (canContinue)
        {
            Console.WriteLine("""
                0 - add new person to the list
                1 - remove a person from the list
                2 - print the table
                3 - exit
                """);
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 0:
                    AddToTheList(ref Colums);
                    break;
                case 1:
                    RemoveFromTheList(ref Colums);
                    break;
                case 2:
                    PrintTable(ref Colums);
                    break;
                case 3:
                    canContinue = false;
                    break;
                default:
                    Console.WriteLine("""
                0 - adding new person to the list
                1 - removing a person from the list
                2 - exit
                """);
                    break;
            }
        }
    }

    public static void PrintTable(ref Colum[] colums)
    {
        Console.WriteLine("┌───┬────────────┬───────────────┬───┐");
        for (int i = 0; i < colums.Length; i++)
        {
            Console.WriteLine($"│{i.ToString().PadLeft(3, '0')}│{colums[i].Name.PadRight(12, ' ')}│{colums[i].Surname.PadRight(15, ' ')}│{colums[i].Age.ToString().PadRight(3, ' ')}│");
            if (i < colums.Length - 1)
                Console.WriteLine("├───┼────────────┼───────────────┼───┤");
        }
        Console.WriteLine("└───┴────────────┴───────────────┴───┘");
    }

    public static void AddToTheList(ref Colum[] colums)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Surname: ");
        string surname = Console.ReadLine();
        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Colum[] newColums = new Colum[colums.Length + 1];
        for (int i = 0; i < colums.Length; i++)
            newColums[i] = colums[i];
        newColums[newColums.Length - 1] = new Colum(name, surname, age);
        colums = newColums;
    }
    public static void RemoveFromTheList(ref Colum[] colums)
    {
        Console.Write("Please enter the id: ");
        int index = Convert.ToInt32(Console.ReadLine());
        Colum[] newColums = new Colum[colums.Length - 1];

        int count = 0;
        foreach (Colum colum in colums)
        {
            if (count <= index) newColums[count] = colum;
            else newColums[count - 1] = colum;
            count++;
        }
        colums = newColums;
    }
}