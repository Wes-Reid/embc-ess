using Microsoft.EntityFrameworkCore.Migrations;

namespace Gov.Jag.Embc.Public.Migrations
{
    public partial class FixCityInViewEvacuee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF EXISTS (SELECT 1 FROM sys.views WHERE [name] = 'viewEvacuee')
            BEGIN
	            DROP VIEW [dbo].[viewEvacuee]
            END
            GO

            CREATE VIEW [dbo].[viewEvacuee]
				            AS
				            WITH referralSummary
				            AS
				            (
					            SELECT
						            re.RegistrationId,re.EvacueeId
					            FROM
						            ReferralEvacuees re
					            INNER JOIN
						            Referrals r ON re.ReferralId = r.Id AND r.Active = 1
					            GROUP BY
						            re.RegistrationId,re.EvacueeId
				            )
				            SELECT
					            CONCAT(e.RegistrationId, '-', e.EvacueeSequenceNumber) AS Id,
					            er.RestrictedAccess,
					            CONVERT(bit, CASE WHEN e.EvacueeTypeCode = 'HOH' THEN 1 ELSE 0 END) AS IsHeadOfHousehold,
					            e.FirstName,
					            e.LastName,
					            e.Nickname,
					            e.Initials,
					            e.Dob,
					            era.AddressLine1 AS PrimaryAddress,
					            ISNULL((SELECT Name FROM Communities WHERE Id = era.CommunityId), era.City) AS City,   
					            era.Province,
					            era.PostalCode,
					            er.SelfRegisteredDate,
					            CONVERT(VARCHAR(20), e.RegistrationId) AS RegistrationId,
					            t.TaskNumber AS IncidentTaskNumber,
					            er.RegistrationCompletionDate,
					            ISNULL(c.Name, t.RegionName) AS EvacuatedFrom,
					            hc.Name AS EvacuatedTo,
					            CONVERT(bit, CASE WHEN er.RegistrationCompletionDate IS NOT NULL THEN 1 ELSE 0 END) AS IsFinalized,
					            CONVERT(bit, CASE WHEN re.RegistrationId IS NOT NULL THEN 1 ELSE 0 END) AS HasReferrals,
					            er.Active
				            FROM
					            Evacuees e
				            INNER JOIN
					            EvacueeRegistrations er ON e.RegistrationId = er.EssFileNumber
				            LEFT OUTER JOIN
					            IncidentTasks t ON er.IncidentTaskId = t.Id
				            LEFT OUTER JOIN
					            Communities c ON t.CommunityId = c.Id
				            LEFT OUTER JOIN
					            Communities hc ON er.HostCommunityId = hc.Id
				            LEFT OUTER JOIN
					            referralSummary re ON e.RegistrationId = re.RegistrationId AND e.EvacueeSequenceNumber = re.EvacueeId
				            LEFT OUTER JOIN
					            EvacueeRegistrationAddresses era ON e.RegistrationId = era.RegistrationId
            GO
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF EXISTS (SELECT 1 FROM sys.views WHERE [name] = 'viewEvacuee')
            BEGIN
	            DROP VIEW [dbo].[viewEvacuee]
            END
            GO

            CREATE VIEW [dbo].[viewEvacuee]
				            AS
				            WITH referralSummary
				            AS
				            (
					            SELECT
						            re.RegistrationId,re.EvacueeId
					            FROM
						            ReferralEvacuees re
					            INNER JOIN
						            Referrals r ON re.ReferralId = r.Id AND r.Active = 1
					            GROUP BY
						            re.RegistrationId,re.EvacueeId
				            )
				            SELECT
					            CONCAT(e.RegistrationId, '-', e.EvacueeSequenceNumber) AS Id,
					            er.RestrictedAccess,
					            CONVERT(bit, CASE WHEN e.EvacueeTypeCode = 'HOH' THEN 1 ELSE 0 END) AS IsHeadOfHousehold,
					            e.FirstName,
					            e.LastName,
					            e.Nickname,
					            e.Initials,
					            e.Dob,
					            era.AddressLine1 AS PrimaryAddress,
					            era.City,   
					            era.Province,
					            era.PostalCode,
					            er.SelfRegisteredDate,
					            CONVERT(VARCHAR(20), e.RegistrationId) AS RegistrationId,
					            t.TaskNumber AS IncidentTaskNumber,
					            er.RegistrationCompletionDate,
					            ISNULL(c.Name, t.RegionName) AS EvacuatedFrom,
					            hc.Name AS EvacuatedTo,
					            CONVERT(bit, CASE WHEN er.RegistrationCompletionDate IS NOT NULL THEN 1 ELSE 0 END) AS IsFinalized,
					            CONVERT(bit, CASE WHEN re.RegistrationId IS NOT NULL THEN 1 ELSE 0 END) AS HasReferrals,
					            er.Active
				            FROM
					            Evacuees e
				            INNER JOIN
					            EvacueeRegistrations er ON e.RegistrationId = er.EssFileNumber
				            LEFT OUTER JOIN
					            IncidentTasks t ON er.IncidentTaskId = t.Id
				            LEFT OUTER JOIN
					            Communities c ON t.CommunityId = c.Id
				            LEFT OUTER JOIN
					            Communities hc ON er.HostCommunityId = hc.Id
				            LEFT OUTER JOIN
					            referralSummary re ON e.RegistrationId = re.RegistrationId AND e.EvacueeSequenceNumber = re.EvacueeId
				            LEFT OUTER JOIN
					            EvacueeRegistrationAddresses era ON e.RegistrationId = era.RegistrationId
            GO
            ");
        }
    }
}
