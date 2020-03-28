namespace HerancaPolimorfisboAbstract.Entities
{
    class NaturalPerson : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public NaturalPerson(string name, double annualIncome, double healthExpenditures) 
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            if (AnnualIncome <= 20000)
                return AnnualIncome * 0.15 - HealthExpenditures * 0.50;
            else
                return  AnnualIncome * 0.25 - HealthExpenditures * 0.50;
        }
    }
}
