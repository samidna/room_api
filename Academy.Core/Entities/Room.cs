using Academy.Core.Entities.Common;

namespace Academy.Core.Entities;

public class Room : BaseEntity
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string ImageUrl { get; set; }
    public int Order { get; set; }
}

