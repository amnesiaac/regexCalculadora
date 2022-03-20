using System.Collections.Generic;

namespace regexCalculadora
{
    public class TokenDIctionary
    {
        List<TokenDefinition> _tokenDefinitions = new List<TokenDefinition>();
        public TokenDIctionary()
        {
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Number, @"^\d$"));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Operator, @"[*+\/-]"));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Word, "[a-zA-Z]"));
        }

    }
}