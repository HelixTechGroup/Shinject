# Shinject 

[![Build status](https://ci.appveyor.com/api/projects/status/vf412wymbva3x3nv?svg=true)](https://ci.appveyor.com/project/Shinject/Shinject)
[![codecov](https://codecov.io/gh/Shinject/Shinject/branch/main/graph/badge.svg)](https://codecov.io/gh/Shinject/Shinject)
[![NuGet Version](http://img.shields.io/nuget/v/Shinject.svg?style=flat)](https://www.nuget.org/packages/Shinject/) 
[![NuGet Downloads](http://img.shields.io/nuget/dt/Shinject.svg?style=flat)](https://www.nuget.org/packages/Shinject/)

Shinject is a lightning-fast, ultra-lightweight dependency injector for .NET applications. It helps you split your
application into a collection of loosely-coupled, highly-cohesive pieces, and then glue them back together in a
flexible manner. By using Shinject to support your software's architecture, your code will become easier to write,
reuse, test, and modify.

*Write your code so it's flexible...*
```C#
public class Samurai {
    public IWeapon Weapon { get; private set; }
    public Samurai(IWeapon weapon) 
    {
        this.Weapon = weapon;
    }
}
```
*...and let Shinject glue it together for you.*
```C#
public class WarriorModule : ShinjectModule
{
    public override void Load() 
    {
        this.Bind<IWeapon>().To<Sword>();
    }
}
```

## Features:

1. **Focused.** Too many existing dependency injection projects sacrifice usability for features that aren't often necessary.
   Each time a feature is added to Shinject, its benefit is weighed against the complexity it adds to everyday use. Our goal
   is to keep the barrier to entry - the baseline level of knowledge required to use Shinject - as low as possible. Shinject
   has many advanced features, but understanding them is not required to use the basic features.
   
2. **Sleek.** Framework bloat is a major concern for some projects, and as such, all of Shinject's core functionality is in a
   single assembly with no dependencies outside the .NET base class library. This single assembly's footprint is approximately
   85KB when compiled for release.
   
3. **Fast.** Instead of relying on reflection for invocation, Shinject takes advantage of lightweight code generation in the CLR.
   This can result in a dramatic (8-50x) improvement in performance in many situations.
   
4. **Precise.** Shinject helps developers get things right the first time around. Rather than relying on XML mapping files and
   string identifiers to wire up components, Shinject provides a robust domain-specific language. This means that Shinject
   takes advantage of the capabilities of the language (like type-safety) and the IDE (like IntelliSense and code completion).
   
5. **Agile.** Shinject is designed around a component-based architecture, with customization and evolution in mind. Many facets
   of the system can be augmented or modified to fit the requirements of each project.
   
6. **Stealthy.** Shinject will not invade your code. You can easily isolate the dependency on Shinject to a single assembly in
   your project.
   
7. **Powerful.** Shinject includes many advanced features. For example, Shinject is the first dependency injector to support
   contextual binding, in which a different concrete implementation of a service may be injected depending on the context in
   which it is requested.

## Everything else is in Extensions

Yes, sounds slim and focused, but where is the support for all the features that the competitors have? 

Generally, they are maintained as specific focused extensions with owners who keep them in sync and pull in new ideas and fixes fast. These are summarized on the [extensions](http://Shinject.org/extensions) section of the project website. Most are hosted alongside the core project right here.

## License
Shinject is intended to be used in both open-source and commercial environments. To allow its use in as many
situations as possible, Shinject is dual-licensed. You may choose to use Shinject under either the Apache License,
Version 2.0, or the Microsoft Public License (Ms-PL). These licenses are essentially identical, but you are
encouraged to evaluate both to determine which best fits your intended use.

Refer to [LICENSE.txt](https://github.com/Shinject/Shinject/blob/master/LICENSE.txt) for detailed information.

## Changes history
- [Changes in Shinject 3](https://github.com/Shinject/Shinject/wiki/Changes-in-Shinject-3)
- [Changes in Shinject 2](https://github.com/Shinject/Shinject/wiki/Changes-in-Shinject-2)
- [Detailed change log](https://github.com/Shinject/Shinject/blob/master/CHANGELOG.md)

## Resources
- [Project website](http://Shinject.org/)
- [Documentation](http://Shinject.org/learn)
- [Wiki](https://github.com/Shinject/Shinject/wiki)
- [Nate's blog](http://kohari.org/)
- [Ian's blog](http://innovatian.com/)
- [Remo's blog](http://www.planetgeek.ch/author/remo-gloor/)
