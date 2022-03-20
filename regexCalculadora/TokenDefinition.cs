using System.Text.RegularExpressions;

namespace regexCalculadora
{
    public class TokenDefinition
    {
        private Regex _regex;
        private readonly TokenType _tokenType;

        public TokenDefinition(TokenType tokenType, string pattern)
        {
            _tokenType = tokenType;
            _regex = new Regex(pattern);
        }

        public Token Match(string userInput)
        {
            var match = _regex.Match(userInput);
            string remainingString = "";
            Token token = new Token();
            if (match.Success)
            {
                token.IsMatch = true;
                if (match.Length != userInput.Length)
                {
                    remainingString = userInput.Substring(match.Length);
                }
                token.Value = match.Value;
                token.RemainingString = remainingString;
                token.TokenType = _tokenType;
                return token;
            }
            else
            {
                token.IsMatch = false;
            }
            return token;
        }
    }
}