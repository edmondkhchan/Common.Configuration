using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Configuration
{
    public interface IConfiguration
    {
        string GetString(string key);
        decimal GetDecimal(string key);
        bool GetBoolean(string key);
        double GetDouble(string key);
        float GetFloat(string key);
        int GetInt(string key);
        long GetLong(string key);
        short GetShort(string key);
        byte GetByte(string key);
        List<object> GetList(string key);
        void AddProperty(string key, object value);
        void ConfigBuilder();
    }
}
