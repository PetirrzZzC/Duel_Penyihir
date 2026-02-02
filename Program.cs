Wizard wizardA = new Wizard("Mak Lampir", 20);
Wizard wizardB = new Wizard("Wicth", 30);

Console.WriteLine("Permainan diMulai. . .\n");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.attack(wizardB);
wizardB.attack(wizardA);
wizardA.attack(wizardB);

Console.WriteLine("Permainan Berakhir. . .\n");
wizardA.ShowStats();
wizardB.ShowStats();

class Wizard
{
    public string Name;
    public int Energi;
    public int Damage;

    public Wizard(string name, int damage)
    {
        Name = name;
        Energi = 100;
        Damage = damage;
    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energi}\n");
    }

    public void attack(Wizard wizardlawanObj)
    {
        wizardlawanObj.Energi -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardlawanObj.Name}");
        Console.WriteLine($"Sisa energi {wizardlawanObj.Name} adalah {wizardlawanObj.Energi}");
    }

}

