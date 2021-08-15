using System;

namespace Training.State
{
    public class ConcreteState1 : State
    {
        public override void DoThis()
        {
            Console.WriteLine("To This From ConcreteState1");
            this._context.ChangeState(new ConcreteState2());
        }

        public override void DoThat()
        {
            Console.WriteLine("Do That From ConcreteState1");

        }
    }
}
