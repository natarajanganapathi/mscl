namespace mscl.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class CommandAttribute : Attribute
{
    public CommandAttribute(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public string Name { get; set; }
    public string Description { get; set; }
}
