﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

public class AmericaFactory : ContinentFactory
{
    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }

    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }
}

