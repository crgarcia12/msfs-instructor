using MSFSInstructor;
using System.Threading.Tasks;

namespace MsfsInstructor.Agents
{
    public class FlightDirector : AgentBase
    {


        public FlightDirector(AgentManager agentManager) : base(agentManager, nameof(Pilot))
        {
            
        }

        public override async Task ProcessEvent(AgentEvent agentEvent)
        {
            await Task.Delay(100);
        }
    }
}
