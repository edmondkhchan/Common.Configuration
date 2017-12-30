using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Configuration
{
    public abstract class Configuration : IConfiguration
    {
        private static Dictionary<string, object> configMapping = new Dictionary<string, object>();

        public virtual string GetString(string key)
        {
            string result = string.Empty;

            if (configMapping.ContainsKey(key))
                result = configMapping[key].ToString();

            return result;
        }

        public virtual decimal GetDecimal(string key)
        {
            decimal result = 0;

            if (configMapping.ContainsKey(key))
                result = decimal.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual bool GetBoolean(string key)
        {
            bool result = false;

            if (configMapping.ContainsKey(key))
                result = bool.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual double GetDouble(string key)
        {
            double result = 0;

            if (configMapping.ContainsKey(key))
                result = double.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual float GetFloat(string key)
        {
            float result = 0;

            if (configMapping.ContainsKey(key))
                result = float.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual int GetInt(string key)
        {
            int result = 0;

            if (configMapping.ContainsKey(key))
                result = int.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual long GetLong(string key)
        {
            long result = 0;

            if (configMapping.ContainsKey(key))
                result = long.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual short GetShort(string key)
        {
            short result = 0;

            if (configMapping.ContainsKey(key))
                result = short.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual byte GetByte(string key)
        {
            byte result = new byte();

            if (configMapping.ContainsKey(key))
                result = byte.Parse(configMapping[key].ToString());

            return result;
        }

        public virtual List<object> GetList(string key)
        {
            List<object> result = new List<object>();

            if (configMapping.ContainsKey(key))
                result = (List<object>)configMapping[key];

            return result;
        }

        public virtual void AddProperty(string key, object value)
        {
            if (configMapping.ContainsKey(key))
                configMapping[key] = value;
            else
                configMapping.Add(key, value);
        }

        public abstract void ConfigBuilder();
    }
}
