namespace lab5.Ex2
{
    public class UniversityTeacher: Person, IEmployeeAction
    {
        public string UniversityTeacherCode { get; set; } 
        
        public int EnglishSkillLever { get; set; }

        public double CalculateSalary()
        {
            if (SeniorLecture < 60000)
            {
                throw new AmountException("Senior lecture can not get less than 60,000 salary", Fullname);
            }
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is more than 10,000", Fullname);
            }

            return BaseSalary * Skillevel + ((BaseSalary / 10) * EnglishSkillLever) + SeniorLecture + Bonus;
        }
    }
}