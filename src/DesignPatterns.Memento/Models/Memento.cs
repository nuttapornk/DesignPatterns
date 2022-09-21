using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Models
{
    public class Memento<T>
    {
        public string Type { get; set; }

        private readonly string _serializeData;
        public T Object => JsonConvert.DeserializeObject<T>(_serializeData);

        public Memento(T serializeObject)
        {
            Type = typeof(T).ToString();
            _serializeData = JsonConvert.SerializeObject(serializeObject);
        }
    }
}
