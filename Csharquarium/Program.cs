
using Csharquarium.Enumeration;
using Csharquarium.classes;
using Csharquarium.StreamReadWrite;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Sole sole1 = new Sole (Sexe.Femelle, "fifie", 16);
Sole sole2 = new Sole(Sexe.Male, "Riri", 12);
Sole sole3 = new Sole(Sexe.Femelle, "Riri", 13);

Carpe carpe1 = new Carpe(Sexe.Femelle,"Mel", 12);
Carpe carpe2 = new Carpe(Sexe.Male,"Maxime", 8);
Carpe carpe3 = new Carpe(Sexe.Male,"Stef", 10);

Bar bar1 = new Bar(Sexe.Male, "Val", 15);
Bar bar2 = new Bar(Sexe.Femelle, "Clito", 10);
Bar bar3 = new Bar(Sexe.Male, "JF", 12);

PoissonClown pc1 = new PoissonClown(Sexe.Male, "greg",18);
PoissonClown pc2 = new PoissonClown(Sexe.Femelle, "gigi", 9);
PoissonClown pc3 = new PoissonClown(Sexe.Male, "roco", 12);

Thon t1 = new Thon(Sexe.Male, "Johny", 4);
Thon t2 = new Thon(Sexe.Femelle, "Mirabelle", 4);
Thon t3 = new Thon(Sexe.Male, "Boris", 4);

Merou m1 = new Merou(Sexe.Male, "bris", 12);
Merou m2 = new Merou(Sexe.Femelle, "briselda", 16);
Merou m3 = new Merou(Sexe.Femelle, "hernesta", 19);

Algue a1 = new Algue(10, 6);
Algue a2 = new Algue(10, 3);
Algue a3 = new Algue(10, 5);
Algue a4 = new Algue(10, 10);
Algue a5 = new Algue(10, 13);
Algue a6 = new Algue(10, 8);
Algue a7 = new Algue(10, 7);

Aquarium aqua1 = new Aquarium("aquaTest");

aqua1.AjoutEtreVivant(a1);
aqua1.AjoutEtreVivant(a2);
aqua1.AjoutEtreVivant(a3);
aqua1.AjoutEtreVivant(a4);
aqua1.AjoutEtreVivant(a5);
aqua1.AjoutEtreVivant(a6);
aqua1.AjoutEtreVivant(a7);
aqua1.AjoutEtreVivant(m1);
aqua1.AjoutEtreVivant(m2);
aqua1.AjoutEtreVivant(m3);
aqua1.AjoutEtreVivant(t1);
aqua1.AjoutEtreVivant(t2);
aqua1.AjoutEtreVivant(t3);
aqua1.AjoutEtreVivant(sole1);
aqua1.AjoutEtreVivant(sole2);
aqua1.AjoutEtreVivant(sole3);
aqua1.AjoutEtreVivant(pc1);
aqua1.AjoutEtreVivant(pc2);
aqua1.AjoutEtreVivant(pc3);
aqua1.AjoutEtreVivant(bar1);
aqua1.AjoutEtreVivant(bar2);
aqua1.AjoutEtreVivant(bar3);
aqua1.AjoutEtreVivant(carpe1);
aqua1.AjoutEtreVivant(carpe2);
aqua1.AjoutEtreVivant(carpe3);


for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"Tour {i}");
    aqua1.PasserTemp();  
}

AquariumSerialisation.Save(aqua1);

//StreamWriter sw = File.Open("monFichier", FileMode.Create);
//sw.WriteLine("Ouvrir");
//sw.Close();