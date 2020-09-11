namespace command
{
    public class EmailJob : IJob
    {
        private Email _email;

        public void Run()
        {
            if (_email != null)
            {
                _email.SendEmail();
            }
        }

        public void Email(Email email) => _email = email;
    }
}