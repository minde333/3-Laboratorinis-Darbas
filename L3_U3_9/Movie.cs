using System;

namespace L3_U3_9
{
    /// Klasė saugoti duomenis apie filmą
    class Movie : Video
    {
        // Filmo išleidimo metai 
        public int Release { get; set; }
        // Filmą sukūrusio režisieriaus vardas
        public string Director { get; set; }
        // Filmo pelnas
        public double Profit { get; set; }

        public Movie(string name, string genre, string studio, string actor1, string actor2, int release, string director, double profit) : base(name, genre, studio, actor1, actor2)
        {
            Release = release;
            Director = director;
            Profit = profit;
        }

        /// <summary>
        /// Perrašytas išspausdinimo metodas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("| {0, -34} | {1,-27} | {2,-34} | {3,-20} | {4,-17} | {5,-19} | {6,-20} | {7,-12} | {8,-22} | {9,-22} | {10,-23} | {11,-19} |",
                        Name, Genre, Studio, Actor1, Actor2, Release, Director, Profit, "", "", "", "");
        }

        /// <summary>
        /// Perrašomas Equals metodas, kuris leidžia patikrinti ar vienodi du
        /// pateikti filmai
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Movie other))
            {
                return false;
            }
            return Name == other.Name &&
                   Release == other.Release &&
                   Genre == other.Genre &&
                   Studio == other.Studio &&
                   Director == other.Director &&
                   Actor1 == other.Actor1 &&
                   Actor2 == other.Actor2 &&
                   Math.Abs(Profit - other.Profit) < 0.1;
        }

        /// <summary>
        /// Dėl pakeisto Equals metodo, pakeičiamas GetHashCode metodas
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Genre.GetHashCode() ^ Studio.GetHashCode() ^ Director.GetHashCode() ^ Actor1.GetHashCode() ^ Actor2.GetHashCode() ^ Profit.GetHashCode();
        }

        public static bool operator ==(Movie lhs, Movie rhs)
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

        public static bool operator !=(Movie lhs, Movie rhs)
        {
            return !(lhs == rhs);
        }
    }
}
