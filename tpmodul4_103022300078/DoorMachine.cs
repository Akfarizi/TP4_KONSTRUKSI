using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300078
{
    public class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }

        public void KunciPintu()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
