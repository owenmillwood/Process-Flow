using System;
using System.Collections.Generic;
using logic;
using xmlIO;

namespace processFlow {
  public class Program {

    public static void Main(String[] args) {
      try {  // do not remove this try-catch statement, do not add any code outside try-block
        List<IFlowOperation> inputs = ProcessFlowFactory.LoadInput("flow.xml");  // reinstate this line before submission
        //List<IFlowOperation> inputs = ProcessFlowFactory.LoadInput(args[0]);       // remove this line before submission
        ProcessFlow flow = null;
        foreach (IFlowOperation input in inputs) {
          if (input is ProcessFlow) {
            flow = (ProcessFlow)input;
            flow.Init();
          }
          else if (flow != null
                   && input is Operation) {
            Operation op = (Operation)input;
            Object result = null;
            try {
              result = op.Do(flow);
            }
            catch (Exception e) {
            }
            if (result != null) {
              ProcessFlowFactory.Output(op.Output(result));
            }
          }
        }
      }
      catch (Exception e) {
        // do not modify the code in this catch block except to comment two lines at end of block
        Console.WriteLine("Unhandled exception: " + e.Message);
        // comment following two lines before final build and submission
        //Console.WriteLine("Press any key to exit program.");
        //Console.ReadKey();
      }
    }
  }

}

