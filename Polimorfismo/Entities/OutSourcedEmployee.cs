using System.Text;
using Polimorfismo.Entities;

namespace Polimorfismo.Entities
{
    class OutSourcedEmployee : Employee // (: Employee) Indica a herança da Classe principal Employee
    {
        public double AditionalCharge { get; protected set; } // (Protected) Encapsula o atributo permitindo acesso a alterações apenas pelo construtor ou funções

        public OutSourcedEmployee() // Construtor vázio
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour) // Construtor com parâmetros herdados
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment() // Subscrição da Função Payment da classe principal
        {
            return base.Payment() + AditionalCharge * 1.1;
        }

        public override string ToString() // Subscrição ToString para formatar a apresentação da classe
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + Name);
            sb.Append(", Hours: " + Hours);
            sb.Append(", Value per hour: $ " + ValuePerHour);
            sb.Append(", Payment: $ " + Payment());
            sb.AppendLine(", Type Contract: Out Sourced");
            return base.ToString();
        }
    }
}
