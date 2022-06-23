namespace LitwareLib
{
    public class Employee
    {
        private int EmpNo;
        public int EmployeeNo { get; set; }
        private string EmpName;
        public string EmployeeName { get; set; }
        private double Salary;
        public double EmployeeSalary { get; set; }
        private double HRA;
        public double EmployeeHRA { get; set; }
        private double TA;
        public double EmployeeTA { get; set; }
        private double DA;
        public double EmployeeDA { get; set; }
        private double PF;
        public double EmployeePF { get; set; }
        private double TDS;
        public double EmployeeTDS { get; set; }
        private double NetSalary;
        public double EmployeeNetSalary { get; set; }
        private double GrossSalary;
        public double EmployeeGrossSalary { get; set; }

        public double EmployeeInfo(int EmpNo, string EmpName, double Salary)
        {
            if(Salary < 5000)
            {
                HRA = Salary * 0.1;
                TA = Salary * 0.05;
                DA = Salary * 0.15;
                GrossSalary = Salary + HRA+ TA+ DA;
                return GrossSalary;
            }
            else if(EmployeeSalary<10000)
            {
                HRA = Salary * 0.15;
                TA = Salary * 0.1;
                DA = Salary * 0.20;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else if(EmployeeSalary<15000)
            {
                HRA = Salary * 0.2;
                TA = Salary * 0.15;
                DA = Salary * 0.25;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else if(EmployeeSalary<20000)
            {
                HRA = Salary * 0.25;
                TA = Salary * 0.2;
                DA = Salary * 0.3;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
            else
            {
                HRA = Salary * 0.3;
                TA = Salary * 0.25;
                DA = Salary * 0.35;
                GrossSalary = Salary + HRA + TA + DA;
                return GrossSalary;
            }
        }
        public void CalculateSalary()
        {
            double data = EmployeeInfo(1, "Vinayak", 9000);
            PF = data * 0.1;
            TDS = data * 0.18;
            NetSalary = data -(PF + TDS);
            Console.WriteLine("Net Salary is:{0}",NetSalary);
        }

    }
}