using System.ServiceModel;

namespace Apollo.ServiceModel.Sample
{
    /// <summary>
    /// Calculator service Contract
    /// </summary>
    [ServiceContract(Namespace = "http://Apollo.ServiceModel.Sample")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Subtract(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
        [OperationContract]
        double Divide(double n1, double n2);
    }
}
