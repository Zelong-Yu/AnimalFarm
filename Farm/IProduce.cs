using System;


namespace Farm
{
    interface IProduce
    {
        string Product { get; }
        string Provide();
    }
}
