using System;
using Ascend.API.Enums;

namespace Ascend.API.Entities;

public class Player
{
    public Guid Id {get; set; }
    public string? Name {get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password {get; set;}
    public int Level {get; set; }
    public long CurrentXP {get; set; }
    public long RequiredXP {get; set; }
    public RankType Rank {get; set; }
    public int AvailablePoints {get; set; }

}
