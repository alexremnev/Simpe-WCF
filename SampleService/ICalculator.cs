using System.ServiceModel;

namespace SampleService
{
    [ServiceContract(Namespace = "http://localhost/WCF")]
    public interface ICalculator
    {
        [OperationContract]
        string TestConnection();

        [OperationContract]
        double Addition(double a, double b);

        [OperationContract]
        double Subtraction(double a, double b);

        [OperationContract]
        double Multiplication(double a, double b);

        [OperationContract]
        double Division(double a, double b);
    }
}