﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CalculatorServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Apollo.ServiceModel.Sample", ConfigurationName="CalculatorServiceRef.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Add", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Add", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Subtract", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/SubtractResponse")]
        double Subtract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Subtract", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Multiply", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Multiply", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Divide", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Apollo.ServiceModel.Sample/ICalculator/Divide", ReplyAction="http://Apollo.ServiceModel.Sample/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : Client.CalculatorServiceRef.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<Client.CalculatorServiceRef.ICalculator>, Client.CalculatorServiceRef.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Subtract(double n1, double n2) {
            return base.Channel.Subtract(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double n1, double n2) {
            return base.Channel.SubtractAsync(n1, n2);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2) {
            return base.Channel.MultiplyAsync(n1, n2);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2) {
            return base.Channel.DivideAsync(n1, n2);
        }
    }
}
