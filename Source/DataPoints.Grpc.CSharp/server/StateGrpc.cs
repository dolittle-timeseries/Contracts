// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DataPoints/server/state.proto
// </auto-generated>
// Original file comments:
// ---------------------------------------------------------------------------------------------
//  Copyright (c) Dolittle. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// --------------------------------------------------------------------------------------------
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server {
  /// <summary>
  /// Represents the service for datapoint current state
  /// </summary>
  public static partial class State
  {
    static readonly string __ServiceName = "dolittle.timeseries.datapoints.server.State";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState> __Marshaller_dolittle_timeseries_datapoints_server_DataPointsState = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState> __Method_GetAll = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_dolittle_timeseries_datapoints_server_DataPointsState);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.StateReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of State</summary>
    [grpc::BindServiceMethod(typeof(State), "BindService")]
    public abstract partial class StateBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState> GetAll(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for State</summary>
    public partial class StateClient : grpc::ClientBase<StateClient>
    {
      /// <summary>Creates a new client for State</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StateClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for State that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StateClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StateClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StateClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState GetAll(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState GetAll(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAll, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState> GetAllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState> GetAllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAll, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StateClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StateClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StateBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StateBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Dolittle.TimeSeries.Runtime.DataPoints.Grpc.Server.DataPointsState>(serviceImpl.GetAll));
    }

  }
}
#endregion
