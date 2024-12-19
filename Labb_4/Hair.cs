namespace Labb_4
{
    public struct Hair
    {
        public string HairColor { get; set; }
        public string HairLength { get; set; }

        public Hair(string hairColor, string hairLength)
        {
            HairLength = hairLength;
            HairColor = hairColor;
        }

        public override string ToString()
        {
            return $"Haircolor: {HairColor}, Hairlength: {HairLength}";
        }

    }


}
