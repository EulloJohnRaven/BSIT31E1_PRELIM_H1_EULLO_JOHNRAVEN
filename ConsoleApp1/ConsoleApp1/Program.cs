List<string> Lnames = new List<string>();
List<int[]> Lgrades = new List<int[]>();

while (true)
{
    Console.WriteLine("===== STUDENT SYSTEM =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Compute Average Grade");
    Console.WriteLine("4. Find Highest Grade");
    Console.WriteLine("5. Exit");
    Console.WriteLine("==========================");
    Console.WriteLine("Choose an option:");

    string Selection = Console.ReadLine();

    if (Selection == "1")
    {
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter grade 1:");
        int g1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter grade 2:");
        int g2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter grade 3:");
        int g3 = Convert.ToInt32(Console.ReadLine());

        Lnames.Add(name);
        Lgrades.Add(new int[] { g1, g2, g3 });

        Console.WriteLine("Student added successfully!");
    }
    else if (Selection == "2")
    {
        for (int i = 0; i < Lnames.Count; i++)
        {
            double average = Lgrades[i].Average();

            Console.WriteLine("Name: " + Lnames[i]);
            Console.WriteLine("Grades: " + Lgrades[i][0] + ", " + Lgrades[i][1] + ", " + Lgrades[i][2]);
            Console.WriteLine("Average: " + average.ToString("F2"));
        }
    }
    else if (Selection == "3")
    {
        double total = 0;
        int count = 0;

        for (int i = 0; i < Lgrades.Count; i++)
        {
            total += Lgrades[i][0] + Lgrades[i][1] + Lgrades[i][2];
            count += 3;
        }

        Console.WriteLine("===== CLASS AVERAGE =====");
        Console.WriteLine("Overall Average Grade: " + (total / count).ToString("F2"));
    }
    else if (Selection == "4")
    {
        int highestGrade = Lgrades[0][0];
        string topStudent = Lnames[0];

        for (int i = 0; i < Lnames.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (Lgrades[i][j] > highestGrade)
                {
                    highestGrade = Lgrades[i][j];
                    topStudent = Lnames[i];
                }
            }
        }

        Console.WriteLine("===== HIGHEST GRADE =====");
        Console.WriteLine("Top Student: " + topStudent);
        Console.WriteLine("Highest Grade: " + highestGrade);
    }
    else if (Selection == "5")
    {
        Console.WriteLine("Exiting program...");
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid Input!!! Please Enter Again");
    }
}

//Trying Ramones New Code