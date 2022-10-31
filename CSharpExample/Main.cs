using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExample
{
    //Test Comment
    /*
     * 
     * AGWDAWDWNHRDSSDAWGAWE
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    enum ExampleEnum
    {
        ENUM_A,
        ENUM_B,
        ENUM_C
    }

    struct ExampleStruct
    {
        int a;
        float b;
        short c;
        byte d;
        ushort e;
        long f;
        ulong g;
        sbyte h;
        uint i;
        double j;
        ushort k;
    }

    public interface hehe
    {

    }

    public class Main
    {
        private ExampleStruct es = new ExampleStruct();
        private Bruh b = new Bruh();
        const int a = 10;
        hehe z;
        private Action<int> intAction;
        static int staticInt = 0;
        int nonStaticInt = 0;
        string testString = "Hello world!";

        public Main()
        {
        
        }

        public void Bruh<Type>()
        {
            Type b;
        }
        public static int AddStatic(int a, int b)
        {
            int result = (int)ExampleEnum.ENUM_B;
            result = a + b;

            return result;
        }


        public void CallIntAction(int i)
        {
            intAction(b.bruh);
        }

        public void SubscribeAction(int i)
        {
            intAction += SubscribeAction;
        }

        public int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }
    }

    public class Bruh
    {
    public int bruh { get { return 0; } }
    }

}
