namespace regexCalculadora
{
    public class Token
    {
        public bool IsMatch { get; set; }
        public TokenType TokenType { get; set; }
        public string Value { get; set; }
        public string RemainingString { get; set; }
    }
}