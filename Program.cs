namespace Ants
{
    public abstract class Ant
    {
        public abstract string Species();
        public abstract bool isAnt();
    }
    public abstract class Class : Ant
    {
        public abstract string GetClass();
    }

    public abstract class Queen : Class
    {
        public abstract bool hasChildren();
        public abstract Class[] children();
        public abstract Warrior GetWarrior();
        public abstract Worker GetWorker();
        public abstract Baby GetBaby();

    }
    public abstract class Worker : Class
    {
        public abstract Queen WhoIsMum();
        public abstract string WhereWork();
        public abstract string Profession();
    }
    public abstract class Warrior : Class
    {
        public abstract Queen WhoIsMum();
        public abstract bool isHunter();
        public abstract bool isGuardian();
    }
    public abstract class Baby : Class
    {
        public abstract Queen WhoIsMum();
        public abstract Class FutureClass();
    }

    public class ConcreteQueenA : Queen
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Королева/Матка А";
        }
        public override bool hasChildren()
        {
            return true;
        }
        public override Class[] children()
        {
            return new Class[] {new ConcreteBabyA(), new ConcreteWarriorA(),
            new ConcreteWorkerA()};
        }
        public override Warrior GetWarrior()
        {
            return new ConcreteWarriorA();
        }
        public override Worker GetWorker()
        {
            return new ConcreteWorkerA();
        }
        public override Baby GetBaby()
        {
            return new ConcreteBabyA();
        }
    }
    public class ConcreteQueenB : Queen
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Королева/Матка B";
        }
        public override bool hasChildren()
        {
            return true;
        }
        public override Class[] children()
        {
            return new Class[] {new ConcreteBabyB(), new ConcreteWarriorB(),
            new ConcreteWorkerB()};
        }
        public override Warrior GetWarrior()
        {
            return new ConcreteWarriorB();
        }
        public override Worker GetWorker()
        {
            return new ConcreteWorkerB();
        }
        public override Baby GetBaby()
        {
            return new ConcreteBabyB();
        }
    }
    public class ConcreteQueenС : Queen
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей пожарник";
        }
        public override string GetClass()
        {
            return "Королева/Матка C";
        }
        public override bool hasChildren()
        {
            return false;
        }
        public override Class[] children()
        {
            return null;
        }
        public override Warrior GetWarrior()
        {
            return null;
        }
        public override Worker GetWorker()
        {
            return null;
        }
        public override Baby GetBaby()
        {
            return null;
        }
    }
    public class ConcreteWorkerA : Worker
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Рабочий А";
        }
        public override string WhereWork()
        {
            return "Внутри муравейника";
        }
        public override string Profession()
        {
            return "Ухаживающий за выводком";
        }
        public override Queen WhoIsMum()
        {
            return new ConcreteQueenA();
        }
    }
    public class ConcreteWorkerB : Worker
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Рабочий B";
        }
        public override string WhereWork()
        {
            return "Снаружи муравейника";
        }
        public override string Profession()
        {
            return "Ухаживающий за тлей";
        }
        public override Queen WhoIsMum()
        {
            return new ConcreteQueenB();
        }
    }
    public class ConcreteWarriorA : Warrior
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Воин А";
        }
        public override Queen WhoIsMum()
        {
            return new ConcreteQueenA();
        }
        public override bool isGuardian()
        {
            return true;
        }
        public override bool isHunter()
        {
            return false;
        }
    }
    public class ConcreteWarriorB : Warrior
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Воин B";
        }
        public override Queen WhoIsMum()
        {
            return new ConcreteQueenB();
        }
        public override bool isGuardian()
        {
            return false;
        }
        public override bool isHunter()
        {
            return true;
        }
    }
    public class ConcreteBabyA : Baby
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Детеныш A";
        }
        public override Queen WhoIsMum()
        {
            return new ConcreteQueenA();
        }
        public override Class FutureClass()
        {
            return new ConcreteWarriorA();
        }
    }
    public class ConcreteBabyB : Baby
    {
        public override bool isAnt()
        {
            return true;
        }
        public override string Species()
        {
            return "Муравей-пуля";
        }
        public override string GetClass()
        {
            return "Детеныш B";
        }
        public override Queen WhoIsMum()
        {
            return new ConcreteQueenB();
        }
        public override Class FutureClass()
        {
            return new ConcreteWorkerB();
        }
    }
    public static class MainApp
    {
        public static void Main()
        {
            Queen[] queens = { new ConcreteQueenA(), new ConcreteQueenB(),
            new ConcreteQueenС()};
            foreach (Queen queen in queens)
            {
                if (queen.hasChildren())
                {
                    Warrior warrior = queen.GetWarrior();
                    Worker worker = queen.GetWorker();
                    Baby baby = queen.GetBaby();
                    Class[] ants = queen.children();

                    Console.WriteLine(queen.GetClass() + ":");
                    Console.WriteLine(warrior.GetClass());
                    Console.WriteLine(worker.GetClass());
                    Console.WriteLine(baby.GetClass() + " Будущий " + baby.FutureClass().GetClass());
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Одинокая " + queen.GetClass());
            }
        }
    }
}