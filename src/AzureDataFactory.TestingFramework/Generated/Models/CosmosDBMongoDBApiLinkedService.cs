// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Linked service for CosmosDB (MongoDB API) data source. </summary>
    public partial class CosmosDBMongoDBApiLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of CosmosDBMongoDBApiLinkedService. </summary>
        /// <param name="connectionString"> The CosmosDB (MongoDB API) connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="database"> The name of the CosmosDB (MongoDB API) database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> or <paramref name="database"/> is null. </exception>
        public CosmosDBMongoDBApiLinkedService(DataFactoryElement<string> connectionString, DataFactoryElement<string> database)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));
            Argument.AssertNotNull(database, nameof(database));

            ConnectionString = connectionString;
            Database = database;
            LinkedServiceType = "CosmosDbMongoDbApi";
        }

        /// <summary> Initializes a new instance of CosmosDBMongoDBApiLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="isServerVersionAbove32"> Whether the CosmosDB (MongoDB API) server version is higher than 3.2. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="connectionString"> The CosmosDB (MongoDB API) connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="database"> The name of the CosmosDB (MongoDB API) database that you want to access. Type: string (or Expression with resultType string). </param>
        internal CosmosDBMongoDBApiLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<bool> isServerVersionAbove32, DataFactoryElement<string> connectionString, DataFactoryElement<string> database) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            IsServerVersionAbove32 = isServerVersionAbove32;
            ConnectionString = connectionString;
            Database = database;
            LinkedServiceType = linkedServiceType ?? "CosmosDbMongoDbApi";
        }

        /// <summary> Whether the CosmosDB (MongoDB API) server version is higher than 3.2. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> IsServerVersionAbove32 { get; set; }
        /// <summary> The CosmosDB (MongoDB API) connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> The name of the CosmosDB (MongoDB API) database that you want to access. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Database { get; set; }
    }
}