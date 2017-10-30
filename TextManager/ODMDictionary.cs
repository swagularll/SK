using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTextManager
{
    public class ODMDictionary
    {
        private List<data> data_body = new List<data>();
        public ODMDictionary()
        {
        }

        public ODMDictionary(string json)
        {
            data_body = JsonConvert.DeserializeObject<List<data>>(json);
        }
        public void add(string key, string value)
        {
            data d = new data(key, value);
            data_body.Add(d);
        }

        public bool peek(string key)
        {
            for (int i = 0; i < data_body.Count; i++)
            {
                if (data_body[i].key.Equals(key))
                    return true;
            }
            return false;
        }
        public void clear()
        {
            data_body.Clear();
        }

        public string getValue(string _key)
        {
            return data_body.Where(x => x.key == _key).FirstOrDefault().value;
        }
        public void setValue(string _key, string _value)
        {
            data_body.Where(x => x.key == _key).FirstOrDefault().value = _value;
        }

        public string getJsonString()//Important: right way to avoid serialization problem
        {
            return JsonConvert.SerializeObject(data_body);
        }

        public class data
        {
            public string key = "";
            public string value = "";
            public data(string key, string value)
            {
                this.key = key;
                this.value = value;
            }
            public data()
            {
            }
        }
    }

}
