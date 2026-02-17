
using System.Runtime.CompilerServices;

public interface IAnimal
{
    public void Eat();
    public void Move();
    public void MakeSound();
}

public interface IRun
{
    public void Run();
}

public interface IRoar
{
    public void Roar();
}

public interface IWaddle
{
    public void Waddle();
}

public interface IScreech
{
    public void Screech();
}

public interface IFly
{
    public void Fly();
}
public class Lion : IAnimal, IRun, IRoar
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void MakeSound()
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void Roar()
    {
        throw new NotImplementedException();
    }

    public void Run()
    {
        throw new NotImplementedException();
    }
}

public class Penguin : IAnimal, IWaddle, IScreech
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void MakeSound()
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void Screech()
    {
        throw new NotImplementedException();
    }

    public void Waddle()
    {
        throw new NotImplementedException();
    }
}

public class Eagle : IAnimal, IFly, IScreech
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void MakeSound()
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void Screech()
    {
        throw new NotImplementedException();
    }
}