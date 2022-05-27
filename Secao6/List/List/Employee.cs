using System.Globalization;

namespace List
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }



        public void IncreaseSalary(double porcent)
        {
             Salary += Salary * porcent / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
