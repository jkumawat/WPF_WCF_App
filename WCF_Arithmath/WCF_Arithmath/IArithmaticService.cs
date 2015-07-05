using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Arithmath
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IArithmaticService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        int GetAddition(Operand operands);
        [OperationContract]
        int GetSubtraction(Operand operands);
        [OperationContract]
        int GetMultiplicaiton(Operand operands);
        [OperationContract]
        int GetDivide(Operand operands);                
    }

    [DataContract]
    public class Operand
    {
        [DataMember]
        public int Operand_one
        {
            get;
            set;
        }

        [DataMember]
        public int Operand_two
        {
            get;
            set;
        }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
