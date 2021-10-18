using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EscalasEnum
    {
        Mayor = 0,
        Dorica = 1,
        Frigia = 2,
        Lidia = 3,
        Mixolidia = 4,
        Menor = 5,
        Locria = 6
    }
}
