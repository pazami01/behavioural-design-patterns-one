namespace mediator
{
    public class Machine : IColleague
    {
        public IMachineMediator Mediator { get; set; }

        public void Start() => Wash();
        public void Wash() => Mediator.Open();
    }
}