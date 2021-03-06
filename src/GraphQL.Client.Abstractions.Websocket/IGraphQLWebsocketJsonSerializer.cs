using System.IO;
using System.Threading.Tasks;

namespace GraphQL.Client.Abstractions.Websocket
{
	/// <summary>
	/// The json serializer interface for the graphql-dotnet http client.
	/// Implementations should provide a parameterless constructor for convenient usage
	/// </summary>
    public interface IGraphQLWebsocketJsonSerializer: IGraphQLJsonSerializer {
	    byte[] SerializeToBytes(GraphQLWebSocketRequest request);

	    Task<WebsocketResponseWrapper> DeserializeToWebsocketResponseWrapperAsync(Stream stream);
	    GraphQLWebSocketResponse<GraphQLResponse<TResponse>> DeserializeToWebsocketResponse<TResponse>(byte[] bytes);

	}
}
