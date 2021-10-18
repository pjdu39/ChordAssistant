using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotasEnum
    {
        Do = 0,
        Re_b = 1,
        Re = 2,
        Mi_b = 3,
        Mi = 4,
        Fa = 5,
        Sol_b = 6,
        Sol = 7,
        La_b = 8,
        La = 9,
        Si_b = 10,
        Si = 11,
    }
}
