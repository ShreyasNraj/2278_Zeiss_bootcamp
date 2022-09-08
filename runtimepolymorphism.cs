

class TataCar
{
    //Dependency
    //RevtronEngine _engine = new RevtronEngine(); //composition
    public void Ignite(Engine _engine)
    {
        _engine.Start();
    }
    public void Halt(Engine _engine)
    {
        _engine.Stop();
    }
}
    public class Engine
    {


    void Start();
    void Stop();
}

    class RevtronEngine: Engine
    {
        public void Start() { 
    }
        public void Stop() { 
    }
    }
    class VericoreEngine: Engine
    {
    public void Start()
    {
    }
    public void Stop()
    {
    }

}
    class KrytoechEngine: Engine
    {
    public void Start()
    {
    }
    public void Stop()
    {
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
            TataCar _nexon = new TataCar();
         Engine _parentInstance = new Engine();

        _parentInstance = new RevtronEngine(); //Runtime Polymorphism
        _nexon.iginte(_parentInstance);

        TataCar _harrier = new TataCar(); //Kryotech engine
        _parentInstance = new KrytoechEngine(); //Runtime Polymorphism
        _harrier.ignite(_parentInstance);

        TataCar _hexa = new TataCar();//vericore engine
        _parentInstance = new VericoreEngine(); //Runtime Polymorphism
        _hexa.ignite(_parentInstance);





        FamilyOccassion _family = new FamilyOccassion();
            Parent _parentInstance = new Parent();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_One(); //Runtime Polymorphism
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Two();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Three();
            _family.Visit(_parentInstance);

        }
    }


    public class FamilyOccassion
    {

        public void Visit(Parent familyMember)
        {
            familyMember.Participate(); //Runtime Polymorphism

        }

    }

    public class Parent
    {

        public virtual void Participate()
        {
            Console.WriteLine("Parent ...Participate ");
        }
    }
    public class Child_One : Parent
    {

        public override void Participate()
        {
            Console.WriteLine("ChildOne...Participate");
        }
        public void Smoke()
        {

        }
    }
    public class Child_Two : Parent
    {

        public override void Participate()
        {
            Console.WriteLine("ChildTwo...Participate");
        }

    }
    public class Child_Three : Parent
    {
        public override void Participate()
        {
            Console.WriteLine("ChildThree...Participate");
        }

    }



