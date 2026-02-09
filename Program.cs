Wizard wizardA = new Wizard("Mak Lampir", 20);
Wizard wizardB = new Wizard("Wicth", 30);

Console.WriteLine("Permainan diMulai. . .\n");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.attack(wizardB);
wizardB.attack(wizardA);
wizardA.attack(wizardB);
wizardB.Heal();
wizardB.Heal();
wizardB.Heal();


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

    public void Heal()
    {
        Energi += 5;

        if (Energi <= 100)
        {
            Console.WriteLine($"{Name} Melakukan Heal Energi Meningkat menjadi {Energi}");
        }
        else
        {
            Console.WriteLine("Sudah Mencapai Energi Masimum!!");
            Energi = 100;
        }
    }
}

