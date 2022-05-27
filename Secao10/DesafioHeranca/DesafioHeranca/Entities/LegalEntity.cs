using DesafioHeranca.Entities;

namespace DesafioHeranca.Entities
{
    class LegalEntity : Taxpayers
    {
        public int NumberEmployees { get; set; }

        public LegalEntity(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TotalTax()
        {

            if (NumberEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            return AnualIncome * 0.16;


        }
    }
}

