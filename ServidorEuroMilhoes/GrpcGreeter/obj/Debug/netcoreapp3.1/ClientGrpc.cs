// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/client.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServidorEuroMilhoes {
  public static partial class EuroMilhoes
  {
    static readonly string __ServiceName = "greet.EuroMilhoes";

    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.Nif> __Marshaller_greet_Nif = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.Nif.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.ApostaUtilizador> __Marshaller_greet_ApostaUtilizador = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.ApostaUtilizador.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.teste> __Marshaller_greet_teste = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.teste.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.TodasApostas> __Marshaller_greet_TodasApostas = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.TodasApostas.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RegistarAposta> __Marshaller_greet_RegistarAposta = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.RegistarAposta.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RegistarApostaReply> __Marshaller_greet_RegistarApostaReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.RegistarApostaReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.Connection> __Marshaller_greet_Connection = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.Connection.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RespostaArquivar> __Marshaller_greet_RespostaArquivar = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.RespostaArquivar.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.ApostasVencedoras> __Marshaller_greet_ApostasVencedoras = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.ApostasVencedoras.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RespostaSorteio> __Marshaller_greet_RespostaSorteio = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.RespostaSorteio.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServidorEuroMilhoes.RespostaApostasFeitas> __Marshaller_greet_RespostaApostasFeitas = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServidorEuroMilhoes.RespostaApostasFeitas.Parser.ParseFrom);

    static readonly grpc::Method<global::ServidorEuroMilhoes.Nif, global::ServidorEuroMilhoes.ApostaUtilizador> __Method_ListaApostas = new grpc::Method<global::ServidorEuroMilhoes.Nif, global::ServidorEuroMilhoes.ApostaUtilizador>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListaApostas",
        __Marshaller_greet_Nif,
        __Marshaller_greet_ApostaUtilizador);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.TodasApostas> __Method_ListaApostasAtuais = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.TodasApostas>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListaApostasAtuais",
        __Marshaller_greet_teste,
        __Marshaller_greet_TodasApostas);

    static readonly grpc::Method<global::ServidorEuroMilhoes.RegistarAposta, global::ServidorEuroMilhoes.RegistarApostaReply> __Method_Registar = new grpc::Method<global::ServidorEuroMilhoes.RegistarAposta, global::ServidorEuroMilhoes.RegistarApostaReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Registar",
        __Marshaller_greet_RegistarAposta,
        __Marshaller_greet_RegistarApostaReply);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.Connection> __Method_TesteConeccao = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.Connection>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TesteConeccao",
        __Marshaller_greet_teste,
        __Marshaller_greet_Connection);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaArquivar> __Method_ArquivarApostas = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaArquivar>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ArquivarApostas",
        __Marshaller_greet_teste,
        __Marshaller_greet_RespostaArquivar);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.ApostasVencedoras> __Method_ListaApostasVencedoras = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.ApostasVencedoras>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListaApostasVencedoras",
        __Marshaller_greet_teste,
        __Marshaller_greet_ApostasVencedoras);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaSorteio> __Method_SetSorteioAtualFalse = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaSorteio>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetSorteioAtualFalse",
        __Marshaller_greet_teste,
        __Marshaller_greet_RespostaSorteio);

    static readonly grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaApostasFeitas> __Method_ApostasFeitas = new grpc::Method<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaApostasFeitas>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ApostasFeitas",
        __Marshaller_greet_teste,
        __Marshaller_greet_RespostaApostasFeitas);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServidorEuroMilhoes.ClientReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EuroMilhoes</summary>
    [grpc::BindServiceMethod(typeof(EuroMilhoes), "BindService")]
    public abstract partial class EuroMilhoesBase
    {
      public virtual global::System.Threading.Tasks.Task ListaApostas(global::ServidorEuroMilhoes.Nif request, grpc::IServerStreamWriter<global::ServidorEuroMilhoes.ApostaUtilizador> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ListaApostasAtuais(global::ServidorEuroMilhoes.teste request, grpc::IServerStreamWriter<global::ServidorEuroMilhoes.TodasApostas> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServidorEuroMilhoes.RegistarApostaReply> Registar(global::ServidorEuroMilhoes.RegistarAposta request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServidorEuroMilhoes.Connection> TesteConeccao(global::ServidorEuroMilhoes.teste request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServidorEuroMilhoes.RespostaArquivar> ArquivarApostas(global::ServidorEuroMilhoes.teste request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ListaApostasVencedoras(global::ServidorEuroMilhoes.teste request, grpc::IServerStreamWriter<global::ServidorEuroMilhoes.ApostasVencedoras> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServidorEuroMilhoes.RespostaSorteio> SetSorteioAtualFalse(global::ServidorEuroMilhoes.teste request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServidorEuroMilhoes.RespostaApostasFeitas> ApostasFeitas(global::ServidorEuroMilhoes.teste request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EuroMilhoesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListaApostas, serviceImpl.ListaApostas)
          .AddMethod(__Method_ListaApostasAtuais, serviceImpl.ListaApostasAtuais)
          .AddMethod(__Method_Registar, serviceImpl.Registar)
          .AddMethod(__Method_TesteConeccao, serviceImpl.TesteConeccao)
          .AddMethod(__Method_ArquivarApostas, serviceImpl.ArquivarApostas)
          .AddMethod(__Method_ListaApostasVencedoras, serviceImpl.ListaApostasVencedoras)
          .AddMethod(__Method_SetSorteioAtualFalse, serviceImpl.SetSorteioAtualFalse)
          .AddMethod(__Method_ApostasFeitas, serviceImpl.ApostasFeitas).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EuroMilhoesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListaApostas, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::ServidorEuroMilhoes.Nif, global::ServidorEuroMilhoes.ApostaUtilizador>(serviceImpl.ListaApostas));
      serviceBinder.AddMethod(__Method_ListaApostasAtuais, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.TodasApostas>(serviceImpl.ListaApostasAtuais));
      serviceBinder.AddMethod(__Method_Registar, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServidorEuroMilhoes.RegistarAposta, global::ServidorEuroMilhoes.RegistarApostaReply>(serviceImpl.Registar));
      serviceBinder.AddMethod(__Method_TesteConeccao, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.Connection>(serviceImpl.TesteConeccao));
      serviceBinder.AddMethod(__Method_ArquivarApostas, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaArquivar>(serviceImpl.ArquivarApostas));
      serviceBinder.AddMethod(__Method_ListaApostasVencedoras, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.ApostasVencedoras>(serviceImpl.ListaApostasVencedoras));
      serviceBinder.AddMethod(__Method_SetSorteioAtualFalse, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaSorteio>(serviceImpl.SetSorteioAtualFalse));
      serviceBinder.AddMethod(__Method_ApostasFeitas, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServidorEuroMilhoes.teste, global::ServidorEuroMilhoes.RespostaApostasFeitas>(serviceImpl.ApostasFeitas));
    }

  }
}
#endregion
