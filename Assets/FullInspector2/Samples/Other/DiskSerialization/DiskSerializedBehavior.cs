#if !UNITY_WEBPLAYER

using FullInspector.Samples.Button;
using ProtoBuf;
using System;
using System.IO;
using UnityEngine;

// NOTE: Because we're using NotSupportedSerializationOperator(), if we try to serialize a
//       UnityEngine.Object reference a NotSupportedException will be thrown. If you know of a good
//       way to serialize UnityEngine.Object references to disk, please submit a bug report
//       detailing the process and I'll be happy to add a DiskSerializationOperator to Full
//       Inspector.

namespace FullInspector.Samples.Other.DiskSerialization {
    /// <summary>
    /// The object that we will serialize.
    /// </summary>
    [Serializable]
    [ProtoContract]
    public struct SerializedStruct {
        [ProtoMember(1)]
        public bool BoolValue;

        [ProtoMember(2)]
        public int IntValue;
    }

    [AddComponentMenu("Full Inspector Samples/Other/Disk Serialized Behavior")]
    public class DiskSerializedBehavior : BaseBehavior {
        [Comment("This is the value that will be serialized. Use the context menu for " +
            "serialization operations.")]
        public SerializedStruct Value;

        [Comment("The path that the value will be serialized to")]
        [Margin(10)]
        public string Path;

        [ContextMenu("Deserialize From Path")]
        private void DeserializeFromPath() {
            // Read in the serialized state
            string content = File.ReadAllText(Path);

            // Restore the value
            Value = SerializationHelpers.DeserializeFromContent<SerializedStruct, JsonNetSerializer>(content);
            Debug.Log("Object state has been restored from " + Path);
        }

        [ContextMenu("Serialize To Path")]
        private void SerializeToPath() {
            // Get the serialized state of the object
            string content = SerializationHelpers.SerializeToContent<SerializedStruct, JsonNetSerializer>(Value);

            // Write it out to disk
            File.WriteAllText(Path, content);
            Debug.Log("Object state has been saved to " + Path);
        }

        [ContextMenu("Serialize To Console")]
        private void SerializeToConsole() {
            // Get the serialized state of the object
            string content = SerializationHelpers.SerializeToContent<SerializedStruct, JsonNetSerializer>(Value);

            // Write it out to the console
            Debug.Log(content);
        }
    }
}

#endif