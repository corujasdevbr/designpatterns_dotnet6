namespace Builder
{
    public class EmailBuilder : IBuilder
    {
        private readonly Email _email;
        public EmailBuilder()
        {
            _email = new Email();
        }

        public EmailBuilder Body(string content)
        {
            _email.Body = content;
            return this;
        }

        public EmailBuilder From(string address)
        {
            _email.From = address;
            return this;
        }

        public EmailBuilder Subject(string title)
        {
            _email.Subject = title;
            return this;
        }

        public EmailBuilder To(string address)
        {
            _email.To = address;
            return this;
        }

        public Email Build()
        {
            return _email;
        }
    }
}
