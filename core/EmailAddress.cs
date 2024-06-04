namespace GroovyMail.core
{
    internal class EmailAddress
    {
        public string DisplayName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public EmailAddress()
        {
        }

        public EmailAddress(string email)
        {
            Email = email;
        }

        public EmailAddress(string email, string displayName)
        {
            Email = email;
            DisplayName = displayName;
        }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(DisplayName) ? Email : $"{DisplayName} <{Email}>";
        }
    }
}
