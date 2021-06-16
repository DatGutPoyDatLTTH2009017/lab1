namespace lab5.Ex2
{
    public class HighSchoolTeacher: Person, IEmployeeAction
    {
        public string HighSchoolTeacherCode { get; set; }

        public double CalculateSalary()
        {
            return BaseSalary * Skillevel * SeniorLecture * Bonus;
        }
    }
}