using System;
using System.Collections.Generic;
using System.Text;

namespace RundenRollen
{
    public class Trupp
    {
        public Trupp(string name, int anzahlEinheiten, int grad, int moral, int breite)
        {
            Name = name;
            AnzahlEinheiten = anzahlEinheiten;
            Grad = grad;
            Moral = moral;
            Breite = breite;
        }
        public string Name { get; set; }
        public int AnzahlEinheiten { get; set; }
        public int Grad { get; set; }
        public int Moral { get; set; }
        public int AngriffsWert { get; set; }
        public int[,] Einheiten { get; set; }
        public int Breite { get; set; } = 0;

        public bool Magic { get; set; } = true;
        public void UseMagic()
        {
            Magic = false;
            Moral--;
        }
        
        public bool Fighting { get; set; } = true;
        public void MoralWerfen()
        {
            if ((Moral + Randomizer.GetWZwanzig()) >= 20)
            {
                Moral--;
            }
            else
            {
                Moral--;
                Fighting = false;
            }
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="AngegriffenerTrupp"></param>
        public virtual void Attack(Trupp AngegriffenerTrupp)
        {
            if( AngriffsWert + Randomizer.GetWZwanzig() >= 20) {
                List<int> Dmg = new List<int>();
                for (int i = 0; i < Breite; i++)
                {
                    Dmg.Add(Randomizer.GetWZwei());
                }

                int k = 0;
                int j = 0;
                for (int i = 0; i < Dmg.Count; i++)
                {
                    if(j == AngegriffenerTrupp.Breite)
                    {
                        k++;
                        j = 0;
                    }
                    if(AngegriffenerTrupp.Einheiten[k,j] == 0)
                    {
                        j++;
                    }
                    else
                    {
                        AngegriffenerTrupp.Einheiten[k, j] -= Dmg[i];
                    }
                }
            }
        }
        public void SortFormation()
        {
            Array.Sort(Einheiten);
        }


    }

    //class RangedTrupp : Trupp
    //{
    //    public RangedTrupp(string name, int anzahlEinheiten, int grad, int moral, int breite)
    //        :base(name, anzahlEinheiten, grad, moral, breite) { }

    //    Zustand Zustand = Zustand.Bereit;
    //    public override void Attack()
    //    {

    //    }

    //}

    //class MountedTrupp : Trupp
    //{
    //    public MountedTrupp(string name, int anzahlEinheiten, int grad, int moral, int breite)
    //        : base(name, anzahlEinheiten, grad, moral, breite) { }
    //}
    //public enum Zustand{
    //    Kämpft,
    //    Bereit,
    //    Fliehen
    //}
}
