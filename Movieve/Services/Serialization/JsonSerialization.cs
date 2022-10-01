using Movieve.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Movieve.Services.Serialization
{
    public static class JsonSerialization
    {
        public static void JsonSerialize(List<User> list, string filename)
        {
            if (!filename.EndsWith(".json"))
            {
                filename = filename + ".json";
            }
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filename))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, list);
                }
            }
        }

        public static List<User> JsonDeserialize(string filename)
        {
            if (!filename.EndsWith(".json"))
            {
                filename = filename + ".json";
            }
            User[] users = null;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(filename))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    users = serializer.Deserialize<User[]>(jr);
                }
                foreach (var item in users)
                {
                    return users.ToList();
                }
                return null;
            }

        }
    }
}
