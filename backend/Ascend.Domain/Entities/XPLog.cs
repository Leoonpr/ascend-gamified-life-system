using System;
using Ascend.API.Enums;

namespace Ascend.API.Entities;

public class XPLog
{
    public Guid Id { get; set; }
    public Guid PlayerId { get; set; }
    public long Amount { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public XPReason Reason { get; set; }

}
