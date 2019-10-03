// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DataTypes/data_point.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dolittle.TimeSeries.DataTypes.Protobuf {

  /// <summary>Holder for reflection information generated from DataTypes/data_point.proto</summary>
  public static partial class DataPointReflection {

    #region Descriptor
    /// <summary>File descriptor for DataTypes/data_point.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataPointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpEYXRhVHlwZXMvZGF0YV9wb2ludC5wcm90bxIdZG9saXR0bGUudGltZXNl",
            "cmllcy5kYXRhdHlwZXMaEXN5c3RlbS9ndWlkLnByb3RvGh9nb29nbGUvcHJv",
            "dG9idWYvdGltZXN0YW1wLnByb3RvGhVEYXRhVHlwZXMvdmFsdWUucHJvdG8i",
            "kwEKCURhdGFQb2ludBIiCgp0aW1lU2VyaWVzGAEgASgLMg4uZG9saXR0bGUu",
            "Z3VpZBIzCgV2YWx1ZRgCIAEoCzIkLmRvbGl0dGxlLnRpbWVzZXJpZXMuZGF0",
            "YXR5cGVzLlZhbHVlEi0KCXRpbWVzdGFtcBgDIAEoCzIaLmdvb2dsZS5wcm90",
            "b2J1Zi5UaW1lc3RhbXBCKaoCJkRvbGl0dGxlLlRpbWVTZXJpZXMuRGF0YVR5",
            "cGVzLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::System.Protobuf.GuidReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Dolittle.TimeSeries.DataTypes.Protobuf.ValueReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint), global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPoint.Parser, new[]{ "TimeSeries", "Value", "Timestamp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DataPoint : pb::IMessage<DataPoint> {
    private static readonly pb::MessageParser<DataPoint> _parser = new pb::MessageParser<DataPoint>(() => new DataPoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DataPoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.TimeSeries.DataTypes.Protobuf.DataPointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPoint(DataPoint other) : this() {
      timeSeries_ = other.timeSeries_ != null ? other.timeSeries_.Clone() : null;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataPoint Clone() {
      return new DataPoint(this);
    }

    /// <summary>Field number for the "timeSeries" field.</summary>
    public const int TimeSeriesFieldNumber = 1;
    private global::System.Protobuf.guid timeSeries_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::System.Protobuf.guid TimeSeries {
      get { return timeSeries_; }
      set {
        timeSeries_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Dolittle.TimeSeries.DataTypes.Protobuf.Value value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dolittle.TimeSeries.DataTypes.Protobuf.Value Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DataPoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DataPoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TimeSeries, other.TimeSeries)) return false;
      if (!object.Equals(Value, other.Value)) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (timeSeries_ != null) hash ^= TimeSeries.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
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
      if (timeSeries_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TimeSeries);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (timeSeries_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeSeries);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DataPoint other) {
      if (other == null) {
        return;
      }
      if (other.timeSeries_ != null) {
        if (timeSeries_ == null) {
          TimeSeries = new global::System.Protobuf.guid();
        }
        TimeSeries.MergeFrom(other.TimeSeries);
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Value();
        }
        Value.MergeFrom(other.Value);
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
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
            if (timeSeries_ == null) {
              TimeSeries = new global::System.Protobuf.guid();
            }
            input.ReadMessage(TimeSeries);
            break;
          }
          case 18: {
            if (value_ == null) {
              Value = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Value();
            }
            input.ReadMessage(Value);
            break;
          }
          case 26: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
