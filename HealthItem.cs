class HealthItem
{
    public string Name { get; }
    public int Price { get; set; }
    public int Amount { get; set; }
    public int HealAmount { get; set; }

    public HealthItem(string name, int price, int amount, int heal)
    {
        Name = name;
        Price = price;
        Amount = amount;
        HealAmount = heal;
    }

    public int UseOne()
    {
        if(Amount > 0)
        {
            Amount--;
            return HealAmount;
        }
        else return 0;
    }
    public void AddOne()
    {
        Amount++;
    }

    public void RemoveOne()
    {
        if (Amount > 0)
        {
            Amount--;
        }
    }
}
