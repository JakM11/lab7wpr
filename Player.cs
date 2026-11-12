
public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string name, int maxHealth, int gold, int level, int exp)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = level;
        Experience = exp;
    }

    public void TakeDamage(int damage)
    {
        if(damage <= 0)
        {
            damage = 0;
        }
    
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
        if(amount <= 0)
        {
            amount = 0;
        }
    
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public void GetExperience(int exp)
    {
        Experience += exp;

        while(Experience >= 50)
        {
            Experience -= 50;
            Level++;
            MaxHealth = MaxHealth + 10;
            Health = MaxHealth;
        }
        
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
