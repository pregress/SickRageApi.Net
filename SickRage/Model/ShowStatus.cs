using System.Runtime.Serialization;

namespace SickRage.Model
{
    public enum ShowStatus
    {
        Unknown = 0,

        Continuing,

        Ended,

        [EnumMember(Value = "New Series")]
        NewSeries,

        [EnumMember(Value = "Returning Series")]
        ReturningSeries,
    }
}