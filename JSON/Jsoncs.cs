using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace JSON
{
    class Json
    {
        [JsonProperty("Имя")]
        public string Name { get; set; }

        [JsonProperty("Фамилия")]
        public string Surname { get; set; }

        [JsonProperty("Возраст")]
        public byte Age { get; set; }

        [JsonProperty("Место")]
        public string Place { get; set; }

        [JsonProperty("Страна")]
        public string Country { get; set; }

        [JsonProperty("Предоплата")]
        public string Prepayment { get; set; }

    }
}
