// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DataTypes/vector3.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dolittle.TimeSeries.DataTypes.Protobuf {

  /// <summary>Holder for reflection information generated from DataTypes/vector3.proto</summary>
  public static partial class Vector3Reflection {

    #region Descriptor
    /// <summary>File descriptor for DataTypes/vector3.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Vector3Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdEYXRhVHlwZXMvdmVjdG9yMy5wcm90bxIdZG9saXR0bGUudGltZXNlcmll",
            "cy5kYXRhdHlwZXMaG0RhdGFUeXBlcy9tZWFzdXJlbWVudC5wcm90byKuAQoH",
            "VmVjdG9yMxI1CgF4GAEgASgLMiouZG9saXR0bGUudGltZXNlcmllcy5kYXRh",
            "dHlwZXMuTWVhc3VyZW1lbnQSNQoBeRgCIAEoCzIqLmRvbGl0dGxlLnRpbWVz",
            "ZXJpZXMuZGF0YXR5cGVzLk1lYXN1cmVtZW50EjUKAXoYAyABKAsyKi5kb2xp",
            "dHRsZS50aW1lc2VyaWVzLmRhdGF0eXBlcy5NZWFzdXJlbWVudEIpqgImRG9s",
            "aXR0bGUuVGltZVNlcmllcy5EYXRhVHlwZXMuUHJvdG9idWZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Dolittle.TimeSeries.DataTypes.Protobuf.MeasurementReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.TimeSeries.DataTypes.Protobuf.Vector3), global::Dolittle.TimeSeries.DataTypes.Protobuf.Vector3.Parser, new[]{ "X", "Y", "Z" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Vector3 : pb::IMessage<Vector3> {
    private static readonly pb::MessageParser<Vector3> _parser = new pb::MessageParser<Vector3>(() => new Vector3());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vector3> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.TimeSeries.DataTypes.Protobuf.Vector3Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3(Vector3 other) : this() {
      x_ = other.x_ != null ? other.x_.Clone() : null;
      y_ = other.y_ != null ? other.y_.Clone() : null;
      z_ = other.z_ != null ? other.z_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3 Clone() {
      return new Vector3(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vector3);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vector3 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(X, other.X)) return false;
      if (!object.Equals(Y, other.Y)) return false;
      if (!object.Equals(Z, other.Z)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (x_ != null) hash ^= X.GetHashCode();
      if (y_ != null) hash ^= Y.GetHashCode();
      if (z_ != null) hash ^= Z.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (x_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(X);
      }
      if (y_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Y);
      }
      if (z_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Z);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (x_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(X);
      }
      if (y_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Y);
      }
      if (z_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Z);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vector3 other) {
      if (other == null) {
        return;
      }
      if (other.x_ != null) {
        if (x_ == null) {
          X = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
        }
        X.MergeFrom(other.X);
      }
      if (other.y_ != null) {
        if (y_ == null) {
          Y = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
        }
        Y.MergeFrom(other.Y);
      }
      if (other.z_ != null) {
        if (z_ == null) {
          Z = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
        }
        Z.MergeFrom(other.Z);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (x_ == null) {
              X = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
            }
            input.ReadMessage(X);
            break;
          }
          case 18: {
            if (y_ == null) {
              Y = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
            }
            input.ReadMessage(Y);
            break;
          }
          case 26: {
            if (z_ == null) {
              Z = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
            }
            input.ReadMessage(Z);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
