namespace Ascend.Domain.ValueObjects;

public class PlayerAttributes
{
    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Intelligence { get; private set; }
    public int Vitality { get; private set; }
    public int Perception { get; private set; }

    protected PlayerAttributes() { }

    public PlayerAttributes(
        int strength = 0,
        int agility = 0,
        int intelligence = 0,
        int vitality = 0,
        int perception = 0)
    {
        Validate(strength, agility, intelligence, vitality, perception);

        Strength = strength;
        Agility = agility;
        Intelligence = intelligence;
        Vitality = vitality;
        Perception = perception;
    }

    public PlayerAttributes DistributePoints(
        int strength = 0,
        int agility = 0,
        int intelligence = 0,
        int vitality = 0,
        int perception = 0)
    {
        Validate(strength, agility, intelligence, vitality, perception);

        return new PlayerAttributes(
            Strength + strength,
            Agility + agility,
            Intelligence + intelligence,
            Vitality + vitality,
            Perception + perception
        );
    }

    private static void Validate(params int[] values)
    {
        if (values.Any(v => v < 0))
            throw new ArgumentException("Attributes cannot be negative.");
    }
}
