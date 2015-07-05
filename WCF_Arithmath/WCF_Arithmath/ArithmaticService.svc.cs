using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Arithmath
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ArithmaticService : IArithmaticService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public int GetAddition(Operand operands)
        {
            return operands.Operand_one + operands.Operand_two;
        }

        public int GetSubtraction(Operand operands)
        {
            return operands.Operand_one - operands.Operand_two;
        }

        public int GetMultiplicaiton(Operand operands)
        {
            return operands.Operand_one * operands.Operand_two;
        }

        public int GetDivide(Operand operands)
        {
            return operands.Operand_one / operands.Operand_two;
        }
    }
}
