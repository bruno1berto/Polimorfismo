using System.Text;

namespace Polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; protected set; }
        public int Hours { get; protected set; }
        public double ValuePerHour { get; protected set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

       public virtual double Payment()
       {
           return ValuePerHour * Hours;
       }

       public override string ToString()
       {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + Name);
            sb.Append(", Hours: " + Hours);
            sb.Append(", Value per hour: $ " + ValuePerHour);
            sb.Append(", Payment: $ " + Payment());
            sb.Append(", Type Contract: Employee");
            return base.ToString();
       }
    }
}
