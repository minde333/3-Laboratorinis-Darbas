using System;

namespace L3_U3_9
{
    class Series : Video
    {
        // Serialo pradžios metai 
        public string StartDate { get; set; }
        // Serialo epizodų skaičius
        public int Episodes { get; set; }
        // Serialo pabaigos metai
        public string EndDate { get; set; }
        // Požymis: ar serialas tęsiasi
        public string Airing { get; set; }

        public Series(string name, string genre, string studio, string actor1, string actor2, string startDate, string endDate, int episodes, string airing) : base(name, genre, studio, actor1, actor2)
        {
            StartDate = startDate;
            Episodes = episodes;
            EndDate = endDate;
            Airing = airing;
        }

        /// <summary>
        /// Perrašytas išspausdinimo metodas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("| {0, -34} | {1,-27} | {2,-34} | {3,-20} | {4,-17} | {5,-19} | {6,-20} | {7,-12} | {8,-22} | {9,-22} | {10,-23} | {11,-19} |",
                        Name, Genre, Studio, Actor1, Actor2, "", "", "", StartDate, EndDate, Episodes, Airing);
        }

        /// <summary>
        /// Perrašomas Equals metodas, kuris leidžia patikrinti ar vienodi du
        /// pateikti serialai
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Series other))
            {
                return false;
            }
            return Name == other.Name &&
                   Genre == other.Genre &&
                   Studio == other.Studio &&
                   Actor1 == other.Actor1 &&
                   Actor2 == other.Actor2 &&
                   StartDate == other.StartDate &&
                   Episodes == other.Episodes &&
                   EndDate == other.EndDate &&
                   Airing == other.Airing;
        }

        /// <summary>
        /// Dėl pakeisto Equals metodo, pakeičiamas GetHashCode metodas
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Genre.GetHashCode() ^ Studio.GetHashCode() ^ Actor1.GetHashCode() ^ Actor2.GetHashCode() ^ StartDate.GetHashCode() ^ Episodes.GetHashCode() ^ EndDate.GetHashCode() ^ Airing.GetHashCode();
        }

        public static bool operator ==(Series lhs, Series rhs)
        {
            if (Object.ReferenceEquals(lhs, null))
            {
                if (Object.ReferenceEquals(rhs, null))
                {
                    return true;
                }
                return false;
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Series lhs, Series rhs)
        {
            return !(lhs == rhs);
        }
    }
}
