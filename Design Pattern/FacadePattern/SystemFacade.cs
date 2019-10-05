using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class SystemFacade
    {
        private AuthorizationSystemA AuthorizationSystemA;
        private SecuritySystemB SecuritySystemB;
        private NetBankSystemC NetBankSystemC;
        public SystemFacade()
        {
            AuthorizationSystemA = new AuthorizationSystemA();
            SecuritySystemB = new SecuritySystemB();
            NetBankSystemC = new NetBankSystemC();
        }

        public void Buy()
        {
            AuthorizationSystemA.MethodA();
            SecuritySystemB.MethodB();
            NetBankSystemC.MethodC();
            Console.WriteLine("购买成功!");
        }
    }
}
