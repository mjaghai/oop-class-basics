# Class Basics in C#

A first class: a football player that takes its club, position and shirt number as
constructor arguments instead of being assigned field by field afterwards.

```
ClassBasics/
├── ClassBasics.sln
├── ClassBasics.csproj
├── Fplayer.cs     ← the class
├── Program.cs     ← demo
└── .gitignore
```

## What it demonstrates

| Concept | Where |
|---|---|
| Defining a class with public fields | `Fplayer.cs` |
| **A constructor taking parameters** | `Fplayer(string club, string position, int no)` |
| Assigning fields from constructor parameters | same |
| Creating several objects and reading their fields | `Program.cs` |

```csharp
class Fplayer
{
    public string Club;
    public string Position;
    public int No;

    public Fplayer(string club, string position, int no)
    {
        Club = club;
        Position = position;
        No = no;
    }
}
```

Because the constructor requires all three values, a `Fplayer` can never exist
half-initialised — which is the whole point of having a constructor instead of
setting public fields from outside.

## Running it

```bash
dotnet run
```

No input is needed — the two players are hard-coded in `Program.cs`:

```
manU       <- princeHarry.Club
amf        <- KDB.Position
```

## Notes

Originally in a folder called `test` (with the class in a file called `Class1.cs`,
the Visual Studio default). Renamed to `ClassBasics` / `Fplayer.cs`, along with the
project, assembly and root namespace.

---

<div dir="rtl">

## مبانی کلاس در C#

اولین کلاس: یک بازیکن فوتبال که باشگاه، پست و شماره پیراهنش را از طریق **سازنده**
می‌گیرد، نه اینکه بعداً تک‌تک مقداردهی شود.

**مفاهیمی که نشان می‌دهد:**

- **تعریف کلاس با فیلدهای عمومی**
- **سازنده با پارامتر** و مقداردهی فیلدها از داخل آن
- **ساخت چند شیء** و خواندن فیلدهایشان

چون سازنده هر سه مقدار را الزامی می‌گیرد، یک شیء `Fplayer` هیچ‌وقت **نیمه‌کاره**
ساخته نمی‌شود — و همین دلیل اصلی استفاده از سازنده به جای مقداردهی مستقیم فیلدهای
عمومی از بیرون است.

**اجرا:**

```bash
dotnet run
```

</div>
