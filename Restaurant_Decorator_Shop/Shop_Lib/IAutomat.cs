using Shop_Lib.Burger;
using Shop_Lib.Fries;
using Shop_Lib.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib
{
    public interface IAutomat
    {
        void PickMeatBurger();
        void PickVeggiBurger();
        void AddBaconToBurger();
        void AddCheeseToBurger();
        void PickFries();
        void AddKetchupToFries();
        void AddMayoToFries();
        void AddChiliMayoToFries();
        void CompleteBuy();


    }
}
