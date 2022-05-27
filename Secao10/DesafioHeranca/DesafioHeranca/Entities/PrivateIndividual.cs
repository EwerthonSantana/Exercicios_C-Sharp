namespace DesafioHeranca.Entities
{
    class PrivateIndividual : Taxpayers
    {
        public double HelthExpenditures { get; set; }

        public PrivateIndividual(string name, double anualIncome, double helthExpenditures) : base(name, anualIncome)
        {
            HelthExpenditures = helthExpenditures;
        }

        public override double TotalTax()
        {
            if (AnualIncome <= 20000)
            {
                if (HelthExpenditures > 0)
                {
                    return (AnualIncome * 0.15) - (HelthExpenditures * 0.50);
                }
                return AnualIncome * 0.15;
            }

            if (AnualIncome >= 20000)
            {
                if (HelthExpenditures > 0)
                {
                    return (AnualIncome * 0.25) - (HelthExpenditures * 0.50);
                }
                return AnualIncome * 0.25;
            }

            return 0;
        }
    }
}
