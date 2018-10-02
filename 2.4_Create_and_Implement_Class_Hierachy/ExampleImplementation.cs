using System;
namespace _Create_and_Implement_Class_Hierachy
{
    class ExampleImplementation : IExample
    {

        public int this[string index] 
        { 
            get
            {
                return 45;
            } 
            set
            {

            } 
        }

        public int Value { get; set; }

        public event EventHandler ResultRetrieved;

        public string GetResult()
        {
            return "result";
        }
    }
}
