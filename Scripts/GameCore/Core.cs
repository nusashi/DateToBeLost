using System;

namespace GameCore
{
    class Core
    {
        public int CoreData { get; private set; }
        public Core (int data)
        {
            CoreData = data;
        }
        public void Out ()
        {
            Console.WriteLine (CoreData);
        }
    }
}