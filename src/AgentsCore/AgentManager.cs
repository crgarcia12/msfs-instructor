namespace MSFSInstructor;

using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AgentManager
{
    private readonly List<AgentBase> _agents = new List<AgentBase>(5);
    private readonly IHubContext<WebSocketConnector> _wsConnector;
    internal readonly SimBridgeClient SimBridgeClient;
    internal SimConnector SimConnector;
    public AgentManager(IHubContext<WebSocketConnector> wsConnector, SimBridgeClient simBridgeClient)
    {
        _wsConnector = wsConnector;
        SimBridgeClient = simBridgeClient;

        _agents.Add(new Pilot(this));
    }

    public async Task SendEventAsync(AgentEvent agentEvent)
    {
        if (!string.IsNullOrWhiteSpace(agentEvent.FrontEndMessage))
        {
            if (agentEvent.Sender is AgentBase agent)
            {
                var agentFrontEndEvent = new AgentFrontEndEvent()
                {
                    agent = agent.AgentName,
                    message = agentEvent.FrontEndMessage
                };
                await _wsConnector.Clients.All.SendAsync("ReceiveAgentEvent", agentFrontEndEvent);
            }
        }

        foreach (var registeredAgent in _agents)
        {
            if (registeredAgent != agentEvent.Sender)
            {
                await registeredAgent.ProcessEvent(agentEvent);
            }
        }
    }

    internal void RegisterSimConnectorInstance(SimConnector simConnector)
    {
        SimConnector = simConnector;
    }
}
