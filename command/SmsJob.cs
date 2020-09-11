namespace command
{
    public class SmsJob : IJob
    {
        private Sms _sms;

        public void Run()
        {
            if (_sms != null)
            {
                _sms.SendSms();
            }
        }

        public void Sms(Sms sms) => _sms = sms;
    }
}