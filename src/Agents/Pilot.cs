namespace MSFSInstructor;

using System.Threading.Tasks;

public class Pilot : AgentBase
{

    public Pilot(AgentManager agentManager) : base(agentManager, nameof(Pilot))
    {
    }

    public override async Task ProcessEvent(AgentEvent agentEvent)
    {
        await Task.Delay(100);
    }
}
