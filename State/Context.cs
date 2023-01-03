using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Context
    {
        //赋初始状态
        private State _state;
        public Context(State state)
        {
            _state = state;
        }
        public State State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine("当前的状态是{0}", _state.GetType().Name);
            }
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
}
