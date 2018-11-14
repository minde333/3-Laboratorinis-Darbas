namespace L3_U3_9
{
    /// <summary>
    /// Klasė skirta dirbti su aktoriaus vaidinimo duomenimis
    /// </summary>
    class ActorPerforms
    {
        /// <summary>
        /// Aktoriaus vardas
        /// </summary>
        public string Actor { get; set; }

        /// <summary>
        /// Kiek kartų aktorius vaidino
        /// </summary>
        public int PerformTimes { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is ActorPerforms)) return false;

            return ((ActorPerforms) obj).Actor == Actor;
        }

        public override int GetHashCode()
        {
            return Actor.GetHashCode();
        }
    }
}
