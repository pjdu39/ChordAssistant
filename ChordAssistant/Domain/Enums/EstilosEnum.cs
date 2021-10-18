using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EstilosEnum
    {
        Popular = 0,
        Clasico = 1,
        Jazz = 2
    }
}
