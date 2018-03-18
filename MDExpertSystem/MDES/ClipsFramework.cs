using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mommosoft.ExpertSystem;
using CLIPSNet;

namespace MDES
{
    public class ClipsFramework
    {
        private Mommosoft.ExpertSystem.Environment _theEnv = new Mommosoft.ExpertSystem.Environment();
        //private CLIPSNet.Environment _theEnv = new CLIPSNet.Environment();

        public void Load(string fileName)
        {
            //_theEnv.AddRouter(new DebugRouter());
            _theEnv.Load(fileName);
            _theEnv.Reset();
        }

        public void Run()
        {
            //START trying to initialize the buffer
            _theEnv.InputBuffer iB = new _theEnv.InputBuffer();
            _theEnv.InputBufferCount iBC = new _theEnv.InputBufferCount();
            //END
            _theEnv.Run();
        }

        public void Reset()
        {
            _theEnv.Reset();
        }

        public string GetResponse()
        {
            try
            {
                string evalStr = string.Format("(find-all-facts ((?f UI-control))(eq ?f:id 1))");
                using (FactAddressValue allFacts = (FactAddressValue)((MultifieldValue)_theEnv.Eval(evalStr))[0])
                {
                    return allFacts.GetFactSlot("message").ToString();

                }
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        public string GetFact(string template, string propertyToSearch, string valueToSearch, string tagResponse, string notFoundMessage, string compOperator)
        {
            try
            {
                string evalStr = string.Format("(find-all-facts ((?f "+ template + "))("+ compOperator + " ?f:"+ propertyToSearch + " "+valueToSearch+"))");
                using (var muf = ((MultifieldValue)_theEnv.Eval(evalStr)))
                {                    
                    var index = muf.Count - 1;
                    using(FactAddressValue fv = (FactAddressValue)muf[index])
                        return fv.GetFactSlot(tagResponse).ToString();
                }
                //using (FactAddressValue allFacts = (FactAddressValue)((MultifieldValue)_theEnv.Eval(evalStr))[0])
                //{
                //    return allFacts.GetFactSlot(tagResponse).ToString();
                //}
            }
            catch (Exception ex)
            {

                return notFoundMessage;
            }
        }

        public void CreateAssert(string assertString)
        {
            _theEnv.AssertString(assertString);
        }
    }
}
