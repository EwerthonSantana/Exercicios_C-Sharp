using Conjuntos.Entities;

HashSet<Student> studants = new HashSet<Student>();

Console.Write("How many students for course A? ");
int amountStudentsA = int.Parse(Console.ReadLine());
for (int i = 0; i < amountStudentsA; i++) {
    int idStudant = int.Parse(Console.ReadLine());
    studants.Add(new(idStudant));
}

Console.Write("How many students for course B? ");
int amountStudentsB = int.Parse(Console.ReadLine());
for (int i = 0; i < amountStudentsB; i++) {
    int idStudant = int.Parse(Console.ReadLine());
    studants.Add(new(idStudant));
}

Console.Write("How many students for course C? ");
int amountStudentsC = int.Parse(Console.ReadLine());
for (int i = 0; i < amountStudentsC; i++) {
    int idStudant = int.Parse(Console.ReadLine());
    studants.Add(new(idStudant));
}

Console.WriteLine("Total students: " + studants.Count);