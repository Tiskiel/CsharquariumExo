using Csharquarium.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public class Aquarium
    {
        

        private string _Name;
        private List<EtreVivant>? _liVivant;

        public string Name { get => _Name; set => _Name = value; }
        public List<EtreVivant>? LiVivant { get => _liVivant; set => _liVivant = value; }

        public Aquarium(string name) //constructeur
        {
            Name = name;
            LiVivant = new List<EtreVivant>(); 

        }
        
        

        public void PasserTemp()
        {

            

            List<EtreVivant> mort = new List<EtreVivant>();
            List<EtreVivant> naissance = new List<EtreVivant>();
                


            
            //List<EtreVivant> vege = LiVivant.Where(ev => ev is Algue && ev.PtsVie > 0).ToList();
            foreach (EtreVivant ev in LiVivant)
            {
                
                
                    EtreVivant bb = ev.SeReproduire();
                    if (bb != null)
                    {
                        naissance.Add(bb);
                        
                        Console.WriteLine($"🌱 Le bébé algue est né 🌱");
                    }
                
                
            }

            //List<EtreVivant> Poisson = LiVivant.Where(ev => ev is Poisson && ev.PtsVie > 0).ToList();
            foreach (EtreVivant ev in LiVivant)
            {
                
                //List<EtreVivant> poisson = Poisson;
                EtreVivant bb = ev.SeReproduire(LiVivant[RandomAll.GetRandom(LiVivant.Count)]);
                if (bb != null)
                {
                    naissance.Add(bb);
                    Console.WriteLine($" 🐠 Le bébé , {bb.GetType().Name} est né 🐠 ");
                }
            }
           



            List<EtreVivant> Algues = LiVivant.Where(ev => ev is Algue && ev.PtsVie > 0).ToList();
            List<EtreVivant> herbivores = LiVivant.Where(ev => ev is Herbivore && (ev.PtsVie <= 5 && ev.PtsVie > 0)).ToList(); 
            foreach (Herbivore herbi in herbivores)
            {

                int count = 0;
                count = Algues.Count; 
                
                List<EtreVivant> algues = Algues;

                if (count != 0)
                {

                Algue algue = algues[RandomAll.GetRandom(count)] as Algue; 
                herbi.Manger(algue);
                if (algue.PtsVie <= 0)
                {
                    mort.Add(algue);
                    Console.WriteLine($" 💀 l'{algue} a été mangée par {herbi} 💀 ");
                }
                }

            }

            List<EtreVivant> Carnivores = LiVivant.Where(ev => ev is Carnivore && (ev.PtsVie <= 5 && ev.PtsVie > 0)).ToList();
            List<EtreVivant> Poissons = LiVivant.Where(ev => ev is Poisson && ev.PtsVie > 0).ToList();
            foreach (Carnivore carni in Carnivores)
            {
                
                List<EtreVivant> poissons = Poissons;
                Poisson poisson = poissons[RandomAll.GetRandom(poissons.Count)] as Poisson; 
                carni.Manger(poisson);

                if (poisson.PtsVie <= 0)
                {
                    mort.Add(poisson);
                    Console.WriteLine($" 👻 Le {poisson.GetType().Name} à subit une attaque qui à eu raison de lui ! 👻 ");
                }
            }


            for (int i = 0; i < LiVivant.Count; i++)
            {

                Algue test = new Algue(10, 10);

                LiVivant[i].PtsVie--;
                


                if (LiVivant[i].GetType() is Algue)
                {
                    test.PvUp();
                    LiVivant[i].Viellir();
                }

                if (LiVivant[i].Age == 20 || LiVivant[i].PtsVie <= 0)
                {
                    mort.Add(LiVivant[i]);
                    Console.WriteLine($" 💀 Le/l'{LiVivant[i].GetType().Name} est mort en ce jour ! 💀 ");
                }
            }

            foreach(EtreVivant ev in naissance)
            {
                LiVivant.Add(ev);
            }

            foreach(EtreVivant ev in mort)
            {
                LiVivant.Remove(ev);
            }

            naissance.Clear();
            mort.Clear();


            int CountAl = 0;
            int CountPs = 0;
            for (int i = 0; i < LiVivant.Count; i++)
            {
                if (LiVivant[i].GetType() is Algue)
                {
                    CountAl++;
                }else if (LiVivant[i].GetType() is Poisson)
                {
                    CountPs++;
                }
            }
            Console.WriteLine($"Vous avez {CountPs} poisson(s) et {CountAl} algue(s) en vie dans votre aquarium ");

            
        }

        void sauveDonnes( )
        {

        }


        public void AjoutEtreVivant(EtreVivant ev)
        {
            if(ev != null)
            {
                LiVivant.Add(ev);
                
            }

        }
    }
}
