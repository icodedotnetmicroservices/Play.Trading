using Automatonymous;

namespace Play.Trading.Service.StateMachines
{
    public class PurchaseStateMachine : MassTransitStateMachine<PurchaseState>
    {

        public State Accepted { get; }
        public State ItemsGranted { get; }
        public State Completed { get; }
        public State Faulted { get; }

        protected PurchaseStateMachine()
        {
            InstanceState(state => state.CurrentState);
        }
        
    }

}