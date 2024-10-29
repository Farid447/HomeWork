using System.Xml.Linq;

namespace Generic;

internal abstract class Animal
{
    private int _avgLifeTime;
    private Gender _gender;
    private string _breed;
    private int _hp;

    public int AvgLifeTime { get { return _avgLifeTime; } set { _avgLifeTime = value; } }

    public Gender Gender { get { return _gender; } set { _gender = value; } }
    public string Breed { get { return _breed; } set { _breed = value; } }
    public int HP { get { return _hp; } set { _hp = value; } }

}

internal class Wolf<T> : Animal where T : Animal
{
    bool _isPrideLeader;
    int _attackDamage;
    public bool IsPrideLeader { get { return _isPrideLeader; } set { _isPrideLeader = value; } }
    public int AttackDamage { get { return _attackDamage; } set { _attackDamage = value; } }

    public Wolf(bool isPrideLeader, int attackDamage, int avgLifeTime, Gender gender, string breed, int hp)
    {
        IsPrideLeader = isPrideLeader;
        AttackDamage = attackDamage;
        AvgLifeTime = avgLifeTime;
        Gender = gender;
        Breed = breed;
        HP = hp;
    }

    public void Hunt(T animal)
    {
        animal.HP -= AttackDamage;
        if(animal.HP<0)
            animal.HP = 0;
    }
}

class Elephant : Animal
{
    private double _weight;
    private bool _isTrained;

    public double Weight { get { return _weight; } set { _weight = value; } }
    public bool IsTrained { get { return _isTrained; } set { _isTrained = value; } }

    public Elephant(double weight, bool isTrained, int avgLifeTime,Gender gender, string breed, int hp)
    {
        Weight = weight;
        IsTrained = isTrained;
        AvgLifeTime = avgLifeTime;
        Gender = gender;
        Breed = breed;
        HP = hp;
    }

}

abstract class Food
{
    private int _calorie;

    public int Calorie { get { return _calorie; } set { _calorie = value; } }
}

class Meat : Food
{
    private MeatType _nov;
    public MeatType Nov { get { return _nov; } set { _nov = value; } }

    public Meat(int calorie, MeatType nov)
    {
        Calorie = calorie;
        Nov = nov;
    }
}

class Grass : Food
{
    private string _name;

    public string Name { get { return _name; } set { _name = value; } }

    public Grass(int calorie, string name)
    {
        Calorie = calorie;
        Name = name;
    }
}

class ZooCage<T, U> where T : Animal, new() where U : Food, new()
{

}

enum MeatType
{
    pismis = 1,
    qizardilmis,
    toyuq,
    baliq,
    dana
}

enum Gender
{
    kiwi = 1,
    arvad
}