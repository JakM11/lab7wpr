public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public int Damage { get; }
    public int GoldReward { get; }
    public int Defense { get; }
    public int DefendChance { get; }

    public Enemy(string name, int health, int damage, int gold, int defense, int defendChance)
    {
        Name = name;
        Health = health;
        Damage = damage;
        GoldReward = gold;
        Defense = defense;
        DefendChance = defendChance;
    }

    public void TakeDamage(int damage)
    {
        if(damage <= 0)
        {
            damage = 0;
        }
    
        Health -= damage - Defense;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
