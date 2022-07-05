using System;

namespace HomeWork5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        //Part 1.1 - Create interface IDeveloper with property Tool, methods Create() and Destroy()
        string Tool { get; set; }
        void Create();
        void Destroy();
    }
}
