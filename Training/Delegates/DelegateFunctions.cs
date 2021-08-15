namespace Training.Delegates
{
   public static  class DelegateFunctions
    {
        
       public static void InvokeDelegate(TestDelegates.MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World From Invoke Delegate ,");
        }
    }
}
