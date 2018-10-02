using System;
namespace _Create_and_Implement_Class_Hierachy
{
    interface IExample : ITest
    {
        /*Possible things we can put in an interface
         * Functions
         * Properties
         * Events
         * Indexers
         */

        string GetResult(); //Function
        int Value { get; set; } //Property
        event EventHandler ResultRetrieved; //Event
        int this[string index] { get; set; }
    }

    interface ITest
    {

    }
}
