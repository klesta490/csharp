// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// FlowDistinguisherMethod specifies the method of a flow distinguisher.
    /// </summary>
    public partial class V1beta1FlowDistinguisherMethod
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1FlowDistinguisherMethod
        /// class.
        /// </summary>
        public V1beta1FlowDistinguisherMethod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1FlowDistinguisherMethod
        /// class.
        /// </summary>
        /// <param name="type">`type` is the type of flow distinguisher method
        /// The supported types are "ByUser" and "ByNamespace".
        /// Required.</param>
        public V1beta1FlowDistinguisherMethod(string type)
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets `type` is the type of flow distinguisher method The
        /// supported types are "ByUser" and "ByNamespace". Required.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}