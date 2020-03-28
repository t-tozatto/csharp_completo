namespace HerancaPolimorfisboAbstract.Entities
{
    class LegalPerson : Taxpayer
    {
        public int EmployessNumber { get; set; }

        public LegalPerson(string name, double annualIncome, int employessNumber)
            : base(name, annualIncome)
        {
            EmployessNumber = employessNumber;
        }

        public override double Taxes()
        {
            if (EmployessNumber > 10)
                return AnnualIncome * 0.14;
            else
                return AnnualIncome * 0.16;
        }
    }
}
