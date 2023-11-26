using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija_Lista
{
    internal class Kosarica : IEnumerable<Artikl>
    {
        public List<Artikl> artikli;
        public Kosarica(List<Artikl> artikli)
            => this.artikli = artikli;
        public double Vrijednost
            => artikli.ConvertAll(x => x.cijena).Sum();
        public void UkloniPreskupe(double limit)
            => artikli.RemoveAll(x => x.cijena >= limit);
        public void UkloniVisak(double budget)
        {
            artikli.Sort((a,b) => a.cijena.CompareTo(b.cijena));
            int i;
            for(i = 0; i < artikli.Count; i++)
            {
                if (artikli[i].cijena > budget)
                    break;
                else
                    budget -= artikli[i].cijena;
            }
            artikli.RemoveRange(i, artikli.Count - i);
        }

        public List<Artikl> TriNajjeftinija
        {
            get
            {
                artikli.Sort((a, b) => a.cijena.CompareTo(b.cijena));
                return artikli.GetRange(0, Math.Min(3, artikli.Count));
            }
        }
        public override string ToString()
        {
            string poruka = "Sadrzaj kosarice:\n";
            foreach (var artikl in artikli)
            {
                poruka += '\t' + artikl.ToString() + '\n';
            }
            return poruka;
        }
        public IEnumerator<Artikl> GetEnumerator()
        {
            foreach (Artikl artikl in artikli)
                yield return artikl;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
