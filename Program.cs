Wizard wizardA = new Wizard("Mak Lampir", 20);
Wizard wizardB = new Wizard("Wicth", 30);

Console.WriteLine("Permainan diMulai. . .\n");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.attack(wizardB);
//wizardB.attack(wizardA);
//wizardA.attack(wizardB);
//wizardB.Heal();
//wizardB.Heal();
//wizardB.Heal();

string pilihan;

while (wizardA.Energi > 0 && wizardB.Energi > 0)
{
    Console.WriteLine("Pilih Aksimu");
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA}");
    Console.WriteLine($"3. {wizardA.Name} melakukan Heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan Heal");

    Console.Write("\nMasukkan Pilihanmu (1/2/3/4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        wizardA.attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan tidak valid");
    }
}

Console.WriteLine("Permainan Berakhir. . .\n");
wizardA.ShowStats();
wizardB.ShowStats();

if (wizardA.Energi > wizardB.Energi)
    {
        Console.WriteLine($"{wizardA.Name} Memenangkan Pemainan");
    }
else
{
    Console.WriteLine($"{wizardB.Name} Memenangkan Permainan");
}

class Wizard
{
    public string Name;
    public int Energi;
    public int Damage;

    public Wizard(string name, int damage)
    {
        Name = name;
        Energi = 50;
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

        if (Energi <= 50)
        {
            Console.WriteLine($"{Name} Melakukan Heal Energi Meningkat menjadi {Energi}");
        }
        else
        {
            Console.WriteLine("Sudah Mencapai Energi Masimum!!");
            Energi = 50;
        }
    }
}

