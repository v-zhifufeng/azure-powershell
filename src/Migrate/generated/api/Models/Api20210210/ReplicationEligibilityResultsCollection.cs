namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Replication eligibility results collection response model.</summary>
    public partial class ReplicationEligibilityResultsCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsCollectionInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResults[] _value;

        /// <summary>The replication eligibility results details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResults[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ReplicationEligibilityResultsCollection" /> instance.</summary>
        public ReplicationEligibilityResultsCollection()
        {

        }
    }
    /// Replication eligibility results collection response model.
    public partial interface IReplicationEligibilityResultsCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The replication eligibility results details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replication eligibility results details.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResults) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResults[] Value { get; set; }

    }
    /// Replication eligibility results collection response model.
    internal partial interface IReplicationEligibilityResultsCollectionInternal

    {
        /// <summary>The replication eligibility results details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResults[] Value { get; set; }

    }
}