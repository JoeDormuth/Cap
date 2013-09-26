#region "Imports"

#region "System Imports"
using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
#endregion

#endregion

namespace Capstone.Infrastructure.Util {
    /// <summary>
    /// Simple class for serializing/deserializing json data
    /// </summary>
    public static class Json {

        /// <summary>
        /// Converts an object into a Json string
        /// </summary>
        public static string Serialize<TEntity>(TEntity obj) {
            try {
                using (var ms = new MemoryStream()) {
                    var ser = new DataContractJsonSerializer(typeof(TEntity));
                    ser.WriteObject(ms, obj);

                    ms.Position = 0;
                    using (var sr = new StreamReader(ms)) {
                        return sr.ReadToEnd();
                    }
                }
            } catch (Exception ex) {
                // TODO: Add Logging 
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts a JSON string into an object
        /// </summary>
        public static TEntity Deserialize<TEntity>(string json) {
            try {
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json))) {
                    var ser = new DataContractJsonSerializer(typeof(TEntity));
                    ms.Position = 0;
                    return (TEntity)ser.ReadObject(ms);
                }
            } catch (Exception ex) {
                // TODO: Add logging
                return default(TEntity);
            }
        }
    }
}
