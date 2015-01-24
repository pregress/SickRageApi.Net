using System;

namespace SickRage.Model
{
    [Flags]
    public enum FutureType
    {
        Missed = 1,
        Today = 4,
        Soon = 8,
        Later = 16,
    }
}