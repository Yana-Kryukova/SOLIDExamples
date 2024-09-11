using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExamples.Duck.Bad
{
    public interface IDuck
    {
        void Swim();
        // contract says that IsSwimming should be true if Swim has been called.
        bool IsSwimming { get; }
    }
    public class OrganicDuck : IDuck
    {
        public bool IsSwimming => throw new NotImplementedException();

        public void Swim() { }
    }
    public class ElectricDuck : IDuck
    {
        bool _isSwimming;
        public bool IsTurnedOn { get; set; }

        public void Swim()
        {
            if (!IsTurnedOn)
                return;

            _isSwimming = true;
            //swim logic
        }

        public bool IsSwimming => _isSwimming;
        public void TurnOn() { }
    }


    public class PlayWithDuck
    {
        public void DoSomethingWithDuck(IDuck duck) 
        {
            if (duck is ElectricDuck)
            {
                ((ElectricDuck)duck).TurnOn();
            }
            duck.Swim();
        }
    }
    #region Комментарии
    // Здесь сложность применения принципа лежит в том,
    // что электрическая утка может поплыть только в том случае, если она включена.
    // То есть, если мы в этот метод засунем ВЫКЛЮЧЕННУЮ электрическую утку и вызовем duck.Swim();
    // то она не сможет поплыть.То есть в даном случае LSP соблюдается только при первом взгляде,
    // но на практике этот принцип не соблюдается.

    // Правильное решение при котором будет слюблюдаться принцип - 
    // изменить электрическую утку таким образом,
    // что бы она включалась автоматически при вызове метода .Swim();.

    // Второй способ - не делать электрическую утку "родственником" органической вовсе.
    #endregion
}
