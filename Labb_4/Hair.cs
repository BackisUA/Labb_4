namespace Labb_4
{
    public struct Hair
    {
        //Struct för att hålla koll på hårfärg och hårlängd
        public string HairColor { get; set; }
        public string HairLength { get; set; }

        //Konstruktor för att skapa en instans av Hair
        public Hair(string hairColor, string hairLength)
        {
            HairLength = hairLength;
            HairColor = hairColor;
        }

        //Metod som returnerar en sträng med information om håret
        public override string ToString()
        {
            return $"Haircolor: {HairColor}, Hairlength: {HairLength}";
        }

    }


}
