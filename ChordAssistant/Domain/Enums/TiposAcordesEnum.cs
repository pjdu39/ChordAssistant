using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChordAssistant.Domain
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TiposAcordesEnum
    {
        M = 0,
        m = 1,
        Disminuido = 2
    }
}
