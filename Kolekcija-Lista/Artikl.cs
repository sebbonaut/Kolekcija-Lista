using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija_Lista
{
    internal class Artikl : IEquatable<Artikl>
    {
        public readonly string naziv;
        public readonly double cijena;
        public Artikl(string naziv, double cijena)
        {
            this.naziv = naziv;
            this.cijena = cijena;
        }

        public bool Equals(Artikl? other)
        {
            if(other is not null)
                return other.naziv == naziv && other.cijena == cijena;
            return this == null;
        }

        public override bool Equals(object? obj)
            => (obj is Artikl) && Equals(obj as Artikl);

        public override int GetHashCode()
            => HashCode.Combine(naziv, cijena);

        public override string ToString()
            => naziv + " " + cijena + " eur";
    }
}
