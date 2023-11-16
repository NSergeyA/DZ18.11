namespace DZ18._11
{
    internal abstract class Person
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Person(string name)
        {
            this.name = name;
        }
        public abstract void Print();
    }
}

