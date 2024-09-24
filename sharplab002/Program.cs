using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


class Programm
{
    static void Main(string[] args)
    {
        Pupil excellentPupil = new ExcelentPupil();
        Pupil goodPupil = new GoodPupil();
        Pupil badPupil = new BadPupil();
        Pupil[] pupuils = new Pupil[] { excellentPupil, goodPupil, badPupil, badPupil };
        ClassRoom classRoom = new ClassRoom(pupuils);

        classRoom.ShowInfo();
    }
}




public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ученик читает");
    }

    public virtual void Write()
    {
        Console.WriteLine("Ученик пишет");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает");
    }
}

public class ExcelentPupil : Pupil{
    public override void Study()
    {
        Console.WriteLine("Ученик учится на одни пятерки!");
    }

    public override void Read()
    {
        Console.WriteLine("Ученик выполняет все устные задания!");
    }

    public override void Write()
    {
        Console.WriteLine("Ученик пишет красиво и аккуратно!");
    }

    public override void Relax()
    {
        Console.WriteLine("Ученик отдыхает в свое свободное время!");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Ученик учится на четверки и пятерки!");
    }

    public override void Read()
    {
        Console.WriteLine("Ученик выполняет не все устные задания!");
    }

    public override void Write()
    {
        Console.WriteLine("Ученик пишет неплохо и грамотно!");
    }

    public override void Relax()
    {
        Console.WriteLine("Ученик иногда отдыхает во время занятий!");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Ученик учится на двойки и тройки");
    }

    public override void Read()
    {
        Console.WriteLine("Ученик не выполняет устные задания!");
    }

    public override void Write()
    {
        Console.WriteLine("Ученик пишет ужасно некрасиво!");
    }

    public override void Relax()
    {
        Console.WriteLine("Ученик отдыхает во время занятий!");
    }
}

public class ClassRoom
{
    private List<Pupil> pupils;
    public ClassRoom(Pupil[] pupils)
    {
        this.pupils = new List<Pupil>();

        foreach (var pupil in pupils)
        {
            if (pupil != null)
            {
                this.pupils.Add(pupil);
            }
        }
    }
    public void ShowInfo()
    {
        for (int i = 0; i < pupils.Count; i++)
        {
            Console.WriteLine($"Ученик {i + 1}:");
            pupils[i].Study();
            pupils[i].Write();
            pupils[i].Read();
            pupils[i].Relax();
            Console.WriteLine();
        }
    }
}

//int[] numbers = new int[5]