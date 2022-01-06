using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.AbstractFactory;
using Training.Adapter;
using Training.Bridge;
using Training.Builder;
using Training.ChainOfResponsibility;
using Training.Command;
using Training.Composite;
using Training.Decorator;
using Training.Delegates;
using Training.FactoryMethod;
using Training.Flyweight;
using Training.Interpreter;
using Training.Iterator;
using Training.Mediator;
using Training.Memento;
using Training.Observer;
using Training.Proxy;
using Training.Singleton;
using Training.State;
using Training.Template;

namespace Training
{

    class Program
    {
        static void Main(string[] args)
        {

            //TestDelegates.Test();

            //TestObserver.Test();

            //MementoTester.Test();

            //StateTester.Test();

            //ChainOfResponsibilityTester.Test();

            //FactoryMethodTester.Test();

            //AbstractFactoryTester.Test();
            //SingletonTester.Test();
            //BuilderTester.Test();

            //AdapterTester.Test();
            //CompositeTester.Test();


            //DecoratorTester.Test();
            //BridgeTester.Test();

            //ProxyTester.Test();

            //TemplateTester.Test();

            //FlyWeightTester.Test();

            //MediatorTester.Test();

            //InterpreterTester.Test();

            //CommandTester.TestUndoableCommand();
            IteratorTester.Test();

        }




    }
}
