namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery plan A2A input.</summary>
    public partial class RecoveryPlanA2AInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanA2AInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanA2AInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInput __recoveryPlanProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanProviderSpecificInput();

        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInputInternal)__recoveryPlanProviderSpecificInput).InstanceType; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInputInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInputInternal)__recoveryPlanProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInputInternal)__recoveryPlanProviderSpecificInput).InstanceType = value; }

        /// <summary>Backing field for <see cref="PrimaryZone" /> property.</summary>
        private string _primaryZone;

        /// <summary>The primary zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PrimaryZone { get => this._primaryZone; set => this._primaryZone = value; }

        /// <summary>Backing field for <see cref="RecoveryZone" /> property.</summary>
        private string _recoveryZone;

        /// <summary>The recovery zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryZone { get => this._recoveryZone; set => this._recoveryZone = value; }

        /// <summary>Creates an new <see cref="RecoveryPlanA2AInput" /> instance.</summary>
        public RecoveryPlanA2AInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__recoveryPlanProviderSpecificInput), __recoveryPlanProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__recoveryPlanProviderSpecificInput), __recoveryPlanProviderSpecificInput);
        }
    }
    /// Recovery plan A2A input.
    public partial interface IRecoveryPlanA2AInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInput
    {
        /// <summary>The primary zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The primary zone.",
        SerializedName = @"primaryZone",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryZone { get; set; }
        /// <summary>The recovery zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery zone.",
        SerializedName = @"recoveryZone",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryZone { get; set; }

    }
    /// Recovery plan A2A input.
    internal partial interface IRecoveryPlanA2AInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificInputInternal
    {
        /// <summary>The primary zone.</summary>
        string PrimaryZone { get; set; }
        /// <summary>The recovery zone.</summary>
        string RecoveryZone { get; set; }

    }
}