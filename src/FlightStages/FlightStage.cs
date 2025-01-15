using System;
using System.Collections.Generic;

namespace MsfsInstructor;

public class ChecklistItem
{
    public string Name { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime StartedTime { get; set; }
    public int WaitTimeInMinutes { get; set; }
}


public class FlightStage
{
    public string Name { get; set; }
    public List<ChecklistItem> Items { get; set; } = new List<ChecklistItem>();
}

public class CheckList
{
    public static List<FlightStage> Stages = new List<FlightStage>()
    {
        new FlightStage
        {
            Name = "Before boarding",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Chrono 10 mins", WaitTimeInMinutes=10 },
                new ChecklistItem { Name = "Nav light" },
                new ChecklistItem { Name = "Fuel" },
                new ChecklistItem { Name = "Heading bug" },
                new ChecklistItem { Name = "Barometer" }
            }
        },
        new FlightStage
        {
            Name = "Boarding",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Seatbelt sign" },
                new ChecklistItem { Name = "Flap" },
                new ChecklistItem { Name = "Xponder StdBy" }
            }
        },
        new FlightStage
        {
            Name = "Pushback",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "BCN light" },
                new ChecklistItem { Name = "Engine 2" },
                new ChecklistItem { Name = "Engine 1" },
                            new ChecklistItem { Name = "Chrono 2 mins", WaitTimeInMinutes=2 },
            }
        },
        new FlightStage
        {
            Name = "Before Taxi",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Taxi light" },
                new ChecklistItem { Name = "Control surface" }
            }
        },
        new FlightStage
        {
            Name = "Before Rwy",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Xpndr C" },
                new ChecklistItem { Name = "Strobe Light" },
                new ChecklistItem { Name = "Landing Light" }
            }
        },
        new FlightStage
        {
            Name = "Crossing 10k ASC",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Landing Light" },
                new ChecklistItem { Name = "Seatbelt sign" },
                new ChecklistItem { Name = "Announce" },
                new ChecklistItem { Name = "Barometer" }
            }
        },
        new FlightStage
        {
            Name = "Crossing 10k DESC",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Landing Light" },
                new ChecklistItem { Name = "Seatbelt sign" },
                new ChecklistItem { Name = "Announce" },
                new ChecklistItem { Name = "Barometer" }
            }
        },
        new FlightStage
        {
            Name = "Crossing 2k",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Autopilot" }
            }
        },
        new FlightStage
        {
            Name = "Taxi",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Flaps" },
                new ChecklistItem { Name = "Landing lights" },
                new ChecklistItem { Name = "Taxi lights" },
                new ChecklistItem { Name = "Strobe" },
                new ChecklistItem { Name = "Transponder StdBy" }
            }
        },
        new FlightStage
        {
            Name = "Parking",
            Items = new List<ChecklistItem>
            {
                new ChecklistItem { Name = "Chrono 3 mins", WaitTimeInMinutes=3 },
                new ChecklistItem { Name = "Taxi light" },
                new ChecklistItem { Name = "Engines" },
                new ChecklistItem { Name = "Beacon light" },
                new ChecklistItem { Name = "Seatbelt" }
            }
        }
    };
}