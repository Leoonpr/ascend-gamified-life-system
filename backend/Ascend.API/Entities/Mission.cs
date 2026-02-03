using System;
using Ascend.API.Enums;

namespace Ascend.API.Entities;

public class Mission
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int XPReward { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public MissionStatus Status { get; set; }
    public Player? Player { get; set; }

}
