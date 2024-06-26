# Dropbox.Sign - the C# library for the Dropbox Sign API

Dropbox Sign v3 API

## Migrating from legacy SDK

This SDK is generated from our officially maintained [OpenAPI spec](https://github.com/hellosign/hellosign-openapi/blob/main/openapi.yaml).
We've made important updates that introduce new functionality and create feature parity between the Dropbox Sign API and the SDK.
However, some of these changes are considered "breaking" in the sense that they'll require you to update your existing code in order to continue using the SDK.
Please refer to this [migration guide](https://developers.hellosign.com/docs/sdks/dotnet/migration-guide/) for more information.

## Contributing

This repo is no longer accepting new issues or Pull Requests. All issues or
Pull Requests *must* be opened against the
[hellosign/hellosign-openapi](https://github.com/hellosign/hellosign-openapi) repo!

### Changes to the SDK code

You must make SDK code changes in the mustache file within the `templates`
directory that corresponds to the file you want updated.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 3.0.0
- SDK version: 1.4.1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

### Building

You must have `docker` (or `podman` linked to `docker`) installed. Highly
recommended to use
[rootless docker](https://docs.docker.com/engine/security/rootless/).

Run the following and everything is done for you:

```shell
./run-build
```

*Attention*: Any changes you have made to the SDK code that you have not made
to the OAS file and/or the mustache template files _will be lost_ when you run
this command.

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 108.0.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.9.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

<a name="usage"></a>
## Installation & Usage

### NuGet Package Manager

The Dropbox Sign .NET SDK can be installed using the NuGet package manager, under the package name **Dropbox.Sign** ([package details](https://www.nuget.org/packages/Dropbox.Sign)).

### Build from Source

You can follow the NuGet quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli#publish-the-package) the package via the dotnet CLI. Or, you can [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?tabs=netcore-cli) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?tabs=netcore-cli#publish-the-package) using Visual Studio.

Alternatively, the .nupkg can be published to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consumed via NuGet as usual.

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;

using Dropbox.Sign.Api;
using Dropbox.Sign.Client;
using Dropbox.Sign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var accountApi = new AccountApi(config);

        var data = new AccountCreateRequest(
            emailAddress: "newuser@dropboxsign.com"
        );

        try
        {
            var result = accountApi.AccountCreate(data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling Dropbox Sign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}

```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.hellosign.com/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**AccountCreate**](docs/AccountApi.md#accountcreate) | **POST** /account/create | Create Account
*AccountApi* | [**AccountGet**](docs/AccountApi.md#accountget) | **GET** /account | Get Account
*AccountApi* | [**AccountUpdate**](docs/AccountApi.md#accountupdate) | **PUT** /account | Update Account
*AccountApi* | [**AccountVerify**](docs/AccountApi.md#accountverify) | **POST** /account/verify | Verify Account
*ApiAppApi* | [**ApiAppCreate**](docs/ApiAppApi.md#apiappcreate) | **POST** /api_app | Create API App
*ApiAppApi* | [**ApiAppDelete**](docs/ApiAppApi.md#apiappdelete) | **DELETE** /api_app/{client_id} | Delete API App
*ApiAppApi* | [**ApiAppGet**](docs/ApiAppApi.md#apiappget) | **GET** /api_app/{client_id} | Get API App
*ApiAppApi* | [**ApiAppList**](docs/ApiAppApi.md#apiapplist) | **GET** /api_app/list | List API Apps
*ApiAppApi* | [**ApiAppUpdate**](docs/ApiAppApi.md#apiappupdate) | **PUT** /api_app/{client_id} | Update API App
*BulkSendJobApi* | [**BulkSendJobGet**](docs/BulkSendJobApi.md#bulksendjobget) | **GET** /bulk_send_job/{bulk_send_job_id} | Get Bulk Send Job
*BulkSendJobApi* | [**BulkSendJobList**](docs/BulkSendJobApi.md#bulksendjoblist) | **GET** /bulk_send_job/list | List Bulk Send Jobs
*EmbeddedApi* | [**EmbeddedEditUrl**](docs/EmbeddedApi.md#embeddedediturl) | **POST** /embedded/edit_url/{template_id} | Get Embedded Template Edit URL
*EmbeddedApi* | [**EmbeddedSignUrl**](docs/EmbeddedApi.md#embeddedsignurl) | **GET** /embedded/sign_url/{signature_id} | Get Embedded Sign URL
*OAuthApi* | [**OauthTokenGenerate**](docs/OAuthApi.md#oauthtokengenerate) | **POST** /oauth/token | OAuth Token Generate
*OAuthApi* | [**OauthTokenRefresh**](docs/OAuthApi.md#oauthtokenrefresh) | **POST** /oauth/token?refresh | OAuth Token Refresh
*ReportApi* | [**ReportCreate**](docs/ReportApi.md#reportcreate) | **POST** /report/create | Create Report
*SignatureRequestApi* | [**SignatureRequestBulkCreateEmbeddedWithTemplate**](docs/SignatureRequestApi.md#signaturerequestbulkcreateembeddedwithtemplate) | **POST** /signature_request/bulk_create_embedded_with_template | Embedded Bulk Send with Template
*SignatureRequestApi* | [**SignatureRequestBulkSendWithTemplate**](docs/SignatureRequestApi.md#signaturerequestbulksendwithtemplate) | **POST** /signature_request/bulk_send_with_template | Bulk Send with Template
*SignatureRequestApi* | [**SignatureRequestCancel**](docs/SignatureRequestApi.md#signaturerequestcancel) | **POST** /signature_request/cancel/{signature_request_id} | Cancel Incomplete Signature Request
*SignatureRequestApi* | [**SignatureRequestCreateEmbedded**](docs/SignatureRequestApi.md#signaturerequestcreateembedded) | **POST** /signature_request/create_embedded | Create Embedded Signature Request
*SignatureRequestApi* | [**SignatureRequestCreateEmbeddedWithTemplate**](docs/SignatureRequestApi.md#signaturerequestcreateembeddedwithtemplate) | **POST** /signature_request/create_embedded_with_template | Create Embedded Signature Request with Template
*SignatureRequestApi* | [**SignatureRequestFiles**](docs/SignatureRequestApi.md#signaturerequestfiles) | **GET** /signature_request/files/{signature_request_id} | Download Files
*SignatureRequestApi* | [**SignatureRequestFilesAsDataUri**](docs/SignatureRequestApi.md#signaturerequestfilesasdatauri) | **GET** /signature_request/files_as_data_uri/{signature_request_id} | Download Files as Data Uri
*SignatureRequestApi* | [**SignatureRequestFilesAsFileUrl**](docs/SignatureRequestApi.md#signaturerequestfilesasfileurl) | **GET** /signature_request/files_as_file_url/{signature_request_id} | Download Files as File Url
*SignatureRequestApi* | [**SignatureRequestGet**](docs/SignatureRequestApi.md#signaturerequestget) | **GET** /signature_request/{signature_request_id} | Get Signature Request
*SignatureRequestApi* | [**SignatureRequestList**](docs/SignatureRequestApi.md#signaturerequestlist) | **GET** /signature_request/list | List Signature Requests
*SignatureRequestApi* | [**SignatureRequestReleaseHold**](docs/SignatureRequestApi.md#signaturerequestreleasehold) | **POST** /signature_request/release_hold/{signature_request_id} | Release On-Hold Signature Request
*SignatureRequestApi* | [**SignatureRequestRemind**](docs/SignatureRequestApi.md#signaturerequestremind) | **POST** /signature_request/remind/{signature_request_id} | Send Request Reminder
*SignatureRequestApi* | [**SignatureRequestRemove**](docs/SignatureRequestApi.md#signaturerequestremove) | **POST** /signature_request/remove/{signature_request_id} | Remove Signature Request Access
*SignatureRequestApi* | [**SignatureRequestSend**](docs/SignatureRequestApi.md#signaturerequestsend) | **POST** /signature_request/send | Send Signature Request
*SignatureRequestApi* | [**SignatureRequestSendWithTemplate**](docs/SignatureRequestApi.md#signaturerequestsendwithtemplate) | **POST** /signature_request/send_with_template | Send with Template
*SignatureRequestApi* | [**SignatureRequestUpdate**](docs/SignatureRequestApi.md#signaturerequestupdate) | **POST** /signature_request/update/{signature_request_id} | Update Signature Request
*TeamApi* | [**TeamAddMember**](docs/TeamApi.md#teamaddmember) | **PUT** /team/add_member | Add User to Team
*TeamApi* | [**TeamCreate**](docs/TeamApi.md#teamcreate) | **POST** /team/create | Create Team
*TeamApi* | [**TeamDelete**](docs/TeamApi.md#teamdelete) | **DELETE** /team/destroy | Delete Team
*TeamApi* | [**TeamGet**](docs/TeamApi.md#teamget) | **GET** /team | Get Team
*TeamApi* | [**TeamInfo**](docs/TeamApi.md#teaminfo) | **GET** /team/info | Get Team Info
*TeamApi* | [**TeamInvites**](docs/TeamApi.md#teaminvites) | **GET** /team/invites | List Team Invites
*TeamApi* | [**TeamMembers**](docs/TeamApi.md#teammembers) | **GET** /team/members/{team_id} | List Team Members
*TeamApi* | [**TeamRemoveMember**](docs/TeamApi.md#teamremovemember) | **POST** /team/remove_member | Remove User from Team
*TeamApi* | [**TeamSubTeams**](docs/TeamApi.md#teamsubteams) | **GET** /team/sub_teams/{team_id} | List Sub Teams
*TeamApi* | [**TeamUpdate**](docs/TeamApi.md#teamupdate) | **PUT** /team | Update Team
*TemplateApi* | [**TemplateAddUser**](docs/TemplateApi.md#templateadduser) | **POST** /template/add_user/{template_id} | Add User to Template
*TemplateApi* | [**TemplateCreate**](docs/TemplateApi.md#templatecreate) | **POST** /template/create | Create  Template
*TemplateApi* | [**TemplateCreateEmbeddedDraft**](docs/TemplateApi.md#templatecreateembeddeddraft) | **POST** /template/create_embedded_draft | Create Embedded Template Draft
*TemplateApi* | [**TemplateDelete**](docs/TemplateApi.md#templatedelete) | **POST** /template/delete/{template_id} | Delete Template
*TemplateApi* | [**TemplateFiles**](docs/TemplateApi.md#templatefiles) | **GET** /template/files/{template_id} | Get Template Files
*TemplateApi* | [**TemplateFilesAsDataUri**](docs/TemplateApi.md#templatefilesasdatauri) | **GET** /template/files_as_data_uri/{template_id} | Get Template Files as Data Uri
*TemplateApi* | [**TemplateFilesAsFileUrl**](docs/TemplateApi.md#templatefilesasfileurl) | **GET** /template/files_as_file_url/{template_id} | Get Template Files as File Url
*TemplateApi* | [**TemplateGet**](docs/TemplateApi.md#templateget) | **GET** /template/{template_id} | Get Template
*TemplateApi* | [**TemplateList**](docs/TemplateApi.md#templatelist) | **GET** /template/list | List Templates
*TemplateApi* | [**TemplateRemoveUser**](docs/TemplateApi.md#templateremoveuser) | **POST** /template/remove_user/{template_id} | Remove User from Template
*TemplateApi* | [**TemplateUpdateFiles**](docs/TemplateApi.md#templateupdatefiles) | **POST** /template/update_files/{template_id} | Update Template Files
*UnclaimedDraftApi* | [**UnclaimedDraftCreate**](docs/UnclaimedDraftApi.md#unclaimeddraftcreate) | **POST** /unclaimed_draft/create | Create Unclaimed Draft
*UnclaimedDraftApi* | [**UnclaimedDraftCreateEmbedded**](docs/UnclaimedDraftApi.md#unclaimeddraftcreateembedded) | **POST** /unclaimed_draft/create_embedded | Create Embedded Unclaimed Draft
*UnclaimedDraftApi* | [**UnclaimedDraftCreateEmbeddedWithTemplate**](docs/UnclaimedDraftApi.md#unclaimeddraftcreateembeddedwithtemplate) | **POST** /unclaimed_draft/create_embedded_with_template | Create Embedded Unclaimed Draft with Template
*UnclaimedDraftApi* | [**UnclaimedDraftEditAndResend**](docs/UnclaimedDraftApi.md#unclaimeddrafteditandresend) | **POST** /unclaimed_draft/edit_and_resend/{signature_request_id} | Edit and Resend Unclaimed Draft


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountCreateRequest](docs/AccountCreateRequest.md)
 - [Model.AccountCreateResponse](docs/AccountCreateResponse.md)
 - [Model.AccountGetResponse](docs/AccountGetResponse.md)
 - [Model.AccountResponse](docs/AccountResponse.md)
 - [Model.AccountResponseQuotas](docs/AccountResponseQuotas.md)
 - [Model.AccountUpdateRequest](docs/AccountUpdateRequest.md)
 - [Model.AccountVerifyRequest](docs/AccountVerifyRequest.md)
 - [Model.AccountVerifyResponse](docs/AccountVerifyResponse.md)
 - [Model.AccountVerifyResponseAccount](docs/AccountVerifyResponseAccount.md)
 - [Model.ApiAppCreateRequest](docs/ApiAppCreateRequest.md)
 - [Model.ApiAppGetResponse](docs/ApiAppGetResponse.md)
 - [Model.ApiAppListResponse](docs/ApiAppListResponse.md)
 - [Model.ApiAppResponse](docs/ApiAppResponse.md)
 - [Model.ApiAppResponseOAuth](docs/ApiAppResponseOAuth.md)
 - [Model.ApiAppResponseOptions](docs/ApiAppResponseOptions.md)
 - [Model.ApiAppResponseOwnerAccount](docs/ApiAppResponseOwnerAccount.md)
 - [Model.ApiAppResponseWhiteLabelingOptions](docs/ApiAppResponseWhiteLabelingOptions.md)
 - [Model.ApiAppUpdateRequest](docs/ApiAppUpdateRequest.md)
 - [Model.BulkSendJobGetResponse](docs/BulkSendJobGetResponse.md)
 - [Model.BulkSendJobGetResponseSignatureRequests](docs/BulkSendJobGetResponseSignatureRequests.md)
 - [Model.BulkSendJobListResponse](docs/BulkSendJobListResponse.md)
 - [Model.BulkSendJobResponse](docs/BulkSendJobResponse.md)
 - [Model.BulkSendJobSendResponse](docs/BulkSendJobSendResponse.md)
 - [Model.EmbeddedEditUrlRequest](docs/EmbeddedEditUrlRequest.md)
 - [Model.EmbeddedEditUrlResponse](docs/EmbeddedEditUrlResponse.md)
 - [Model.EmbeddedEditUrlResponseEmbedded](docs/EmbeddedEditUrlResponseEmbedded.md)
 - [Model.EmbeddedSignUrlResponse](docs/EmbeddedSignUrlResponse.md)
 - [Model.EmbeddedSignUrlResponseEmbedded](docs/EmbeddedSignUrlResponseEmbedded.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ErrorResponseError](docs/ErrorResponseError.md)
 - [Model.EventCallbackRequest](docs/EventCallbackRequest.md)
 - [Model.EventCallbackRequestEvent](docs/EventCallbackRequestEvent.md)
 - [Model.EventCallbackRequestEventMetadata](docs/EventCallbackRequestEventMetadata.md)
 - [Model.FileResponse](docs/FileResponse.md)
 - [Model.FileResponseDataUri](docs/FileResponseDataUri.md)
 - [Model.ListInfoResponse](docs/ListInfoResponse.md)
 - [Model.OAuthTokenGenerateRequest](docs/OAuthTokenGenerateRequest.md)
 - [Model.OAuthTokenRefreshRequest](docs/OAuthTokenRefreshRequest.md)
 - [Model.OAuthTokenResponse](docs/OAuthTokenResponse.md)
 - [Model.ReportCreateRequest](docs/ReportCreateRequest.md)
 - [Model.ReportCreateResponse](docs/ReportCreateResponse.md)
 - [Model.ReportResponse](docs/ReportResponse.md)
 - [Model.SignatureRequestBulkCreateEmbeddedWithTemplateRequest](docs/SignatureRequestBulkCreateEmbeddedWithTemplateRequest.md)
 - [Model.SignatureRequestBulkSendWithTemplateRequest](docs/SignatureRequestBulkSendWithTemplateRequest.md)
 - [Model.SignatureRequestCreateEmbeddedRequest](docs/SignatureRequestCreateEmbeddedRequest.md)
 - [Model.SignatureRequestCreateEmbeddedWithTemplateRequest](docs/SignatureRequestCreateEmbeddedWithTemplateRequest.md)
 - [Model.SignatureRequestGetResponse](docs/SignatureRequestGetResponse.md)
 - [Model.SignatureRequestListResponse](docs/SignatureRequestListResponse.md)
 - [Model.SignatureRequestRemindRequest](docs/SignatureRequestRemindRequest.md)
 - [Model.SignatureRequestResponse](docs/SignatureRequestResponse.md)
 - [Model.SignatureRequestResponseAttachment](docs/SignatureRequestResponseAttachment.md)
 - [Model.SignatureRequestResponseCustomFieldBase](docs/SignatureRequestResponseCustomFieldBase.md)
 - [Model.SignatureRequestResponseCustomFieldCheckbox](docs/SignatureRequestResponseCustomFieldCheckbox.md)
 - [Model.SignatureRequestResponseCustomFieldText](docs/SignatureRequestResponseCustomFieldText.md)
 - [Model.SignatureRequestResponseCustomFieldTypeEnum](docs/SignatureRequestResponseCustomFieldTypeEnum.md)
 - [Model.SignatureRequestResponseDataBase](docs/SignatureRequestResponseDataBase.md)
 - [Model.SignatureRequestResponseDataTypeEnum](docs/SignatureRequestResponseDataTypeEnum.md)
 - [Model.SignatureRequestResponseDataValueCheckbox](docs/SignatureRequestResponseDataValueCheckbox.md)
 - [Model.SignatureRequestResponseDataValueCheckboxMerge](docs/SignatureRequestResponseDataValueCheckboxMerge.md)
 - [Model.SignatureRequestResponseDataValueDateSigned](docs/SignatureRequestResponseDataValueDateSigned.md)
 - [Model.SignatureRequestResponseDataValueDropdown](docs/SignatureRequestResponseDataValueDropdown.md)
 - [Model.SignatureRequestResponseDataValueInitials](docs/SignatureRequestResponseDataValueInitials.md)
 - [Model.SignatureRequestResponseDataValueRadio](docs/SignatureRequestResponseDataValueRadio.md)
 - [Model.SignatureRequestResponseDataValueSignature](docs/SignatureRequestResponseDataValueSignature.md)
 - [Model.SignatureRequestResponseDataValueText](docs/SignatureRequestResponseDataValueText.md)
 - [Model.SignatureRequestResponseDataValueTextMerge](docs/SignatureRequestResponseDataValueTextMerge.md)
 - [Model.SignatureRequestResponseSignatures](docs/SignatureRequestResponseSignatures.md)
 - [Model.SignatureRequestSendRequest](docs/SignatureRequestSendRequest.md)
 - [Model.SignatureRequestSendWithTemplateRequest](docs/SignatureRequestSendWithTemplateRequest.md)
 - [Model.SignatureRequestUpdateRequest](docs/SignatureRequestUpdateRequest.md)
 - [Model.SubAttachment](docs/SubAttachment.md)
 - [Model.SubBulkSignerList](docs/SubBulkSignerList.md)
 - [Model.SubBulkSignerListCustomField](docs/SubBulkSignerListCustomField.md)
 - [Model.SubCC](docs/SubCC.md)
 - [Model.SubCustomField](docs/SubCustomField.md)
 - [Model.SubEditorOptions](docs/SubEditorOptions.md)
 - [Model.SubFieldOptions](docs/SubFieldOptions.md)
 - [Model.SubFormFieldGroup](docs/SubFormFieldGroup.md)
 - [Model.SubFormFieldRule](docs/SubFormFieldRule.md)
 - [Model.SubFormFieldRuleAction](docs/SubFormFieldRuleAction.md)
 - [Model.SubFormFieldRuleTrigger](docs/SubFormFieldRuleTrigger.md)
 - [Model.SubFormFieldsPerDocumentBase](docs/SubFormFieldsPerDocumentBase.md)
 - [Model.SubFormFieldsPerDocumentCheckbox](docs/SubFormFieldsPerDocumentCheckbox.md)
 - [Model.SubFormFieldsPerDocumentCheckboxMerge](docs/SubFormFieldsPerDocumentCheckboxMerge.md)
 - [Model.SubFormFieldsPerDocumentDateSigned](docs/SubFormFieldsPerDocumentDateSigned.md)
 - [Model.SubFormFieldsPerDocumentDropdown](docs/SubFormFieldsPerDocumentDropdown.md)
 - [Model.SubFormFieldsPerDocumentFontEnum](docs/SubFormFieldsPerDocumentFontEnum.md)
 - [Model.SubFormFieldsPerDocumentHyperlink](docs/SubFormFieldsPerDocumentHyperlink.md)
 - [Model.SubFormFieldsPerDocumentInitials](docs/SubFormFieldsPerDocumentInitials.md)
 - [Model.SubFormFieldsPerDocumentRadio](docs/SubFormFieldsPerDocumentRadio.md)
 - [Model.SubFormFieldsPerDocumentSignature](docs/SubFormFieldsPerDocumentSignature.md)
 - [Model.SubFormFieldsPerDocumentText](docs/SubFormFieldsPerDocumentText.md)
 - [Model.SubFormFieldsPerDocumentTextMerge](docs/SubFormFieldsPerDocumentTextMerge.md)
 - [Model.SubFormFieldsPerDocumentTypeEnum](docs/SubFormFieldsPerDocumentTypeEnum.md)
 - [Model.SubMergeField](docs/SubMergeField.md)
 - [Model.SubOAuth](docs/SubOAuth.md)
 - [Model.SubOptions](docs/SubOptions.md)
 - [Model.SubSignatureRequestGroupedSigners](docs/SubSignatureRequestGroupedSigners.md)
 - [Model.SubSignatureRequestSigner](docs/SubSignatureRequestSigner.md)
 - [Model.SubSignatureRequestTemplateSigner](docs/SubSignatureRequestTemplateSigner.md)
 - [Model.SubSigningOptions](docs/SubSigningOptions.md)
 - [Model.SubTeamResponse](docs/SubTeamResponse.md)
 - [Model.SubTemplateRole](docs/SubTemplateRole.md)
 - [Model.SubUnclaimedDraftSigner](docs/SubUnclaimedDraftSigner.md)
 - [Model.SubUnclaimedDraftTemplateSigner](docs/SubUnclaimedDraftTemplateSigner.md)
 - [Model.SubWhiteLabelingOptions](docs/SubWhiteLabelingOptions.md)
 - [Model.TeamAddMemberRequest](docs/TeamAddMemberRequest.md)
 - [Model.TeamCreateRequest](docs/TeamCreateRequest.md)
 - [Model.TeamGetInfoResponse](docs/TeamGetInfoResponse.md)
 - [Model.TeamGetResponse](docs/TeamGetResponse.md)
 - [Model.TeamInfoResponse](docs/TeamInfoResponse.md)
 - [Model.TeamInviteResponse](docs/TeamInviteResponse.md)
 - [Model.TeamInvitesResponse](docs/TeamInvitesResponse.md)
 - [Model.TeamMemberResponse](docs/TeamMemberResponse.md)
 - [Model.TeamMembersResponse](docs/TeamMembersResponse.md)
 - [Model.TeamParentResponse](docs/TeamParentResponse.md)
 - [Model.TeamRemoveMemberRequest](docs/TeamRemoveMemberRequest.md)
 - [Model.TeamResponse](docs/TeamResponse.md)
 - [Model.TeamSubTeamsResponse](docs/TeamSubTeamsResponse.md)
 - [Model.TeamUpdateRequest](docs/TeamUpdateRequest.md)
 - [Model.TemplateAddUserRequest](docs/TemplateAddUserRequest.md)
 - [Model.TemplateCreateEmbeddedDraftRequest](docs/TemplateCreateEmbeddedDraftRequest.md)
 - [Model.TemplateCreateEmbeddedDraftResponse](docs/TemplateCreateEmbeddedDraftResponse.md)
 - [Model.TemplateCreateEmbeddedDraftResponseTemplate](docs/TemplateCreateEmbeddedDraftResponseTemplate.md)
 - [Model.TemplateCreateRequest](docs/TemplateCreateRequest.md)
 - [Model.TemplateCreateResponse](docs/TemplateCreateResponse.md)
 - [Model.TemplateCreateResponseTemplate](docs/TemplateCreateResponseTemplate.md)
 - [Model.TemplateEditResponse](docs/TemplateEditResponse.md)
 - [Model.TemplateGetResponse](docs/TemplateGetResponse.md)
 - [Model.TemplateListResponse](docs/TemplateListResponse.md)
 - [Model.TemplateRemoveUserRequest](docs/TemplateRemoveUserRequest.md)
 - [Model.TemplateResponse](docs/TemplateResponse.md)
 - [Model.TemplateResponseAccount](docs/TemplateResponseAccount.md)
 - [Model.TemplateResponseAccountQuota](docs/TemplateResponseAccountQuota.md)
 - [Model.TemplateResponseCCRole](docs/TemplateResponseCCRole.md)
 - [Model.TemplateResponseDocument](docs/TemplateResponseDocument.md)
 - [Model.TemplateResponseDocumentCustomFieldBase](docs/TemplateResponseDocumentCustomFieldBase.md)
 - [Model.TemplateResponseDocumentCustomFieldCheckbox](docs/TemplateResponseDocumentCustomFieldCheckbox.md)
 - [Model.TemplateResponseDocumentCustomFieldText](docs/TemplateResponseDocumentCustomFieldText.md)
 - [Model.TemplateResponseDocumentFieldGroup](docs/TemplateResponseDocumentFieldGroup.md)
 - [Model.TemplateResponseDocumentFieldGroupRule](docs/TemplateResponseDocumentFieldGroupRule.md)
 - [Model.TemplateResponseDocumentFormFieldBase](docs/TemplateResponseDocumentFormFieldBase.md)
 - [Model.TemplateResponseDocumentFormFieldCheckbox](docs/TemplateResponseDocumentFormFieldCheckbox.md)
 - [Model.TemplateResponseDocumentFormFieldDateSigned](docs/TemplateResponseDocumentFormFieldDateSigned.md)
 - [Model.TemplateResponseDocumentFormFieldDropdown](docs/TemplateResponseDocumentFormFieldDropdown.md)
 - [Model.TemplateResponseDocumentFormFieldHyperlink](docs/TemplateResponseDocumentFormFieldHyperlink.md)
 - [Model.TemplateResponseDocumentFormFieldInitials](docs/TemplateResponseDocumentFormFieldInitials.md)
 - [Model.TemplateResponseDocumentFormFieldRadio](docs/TemplateResponseDocumentFormFieldRadio.md)
 - [Model.TemplateResponseDocumentFormFieldSignature](docs/TemplateResponseDocumentFormFieldSignature.md)
 - [Model.TemplateResponseDocumentFormFieldText](docs/TemplateResponseDocumentFormFieldText.md)
 - [Model.TemplateResponseDocumentStaticFieldBase](docs/TemplateResponseDocumentStaticFieldBase.md)
 - [Model.TemplateResponseDocumentStaticFieldCheckbox](docs/TemplateResponseDocumentStaticFieldCheckbox.md)
 - [Model.TemplateResponseDocumentStaticFieldDateSigned](docs/TemplateResponseDocumentStaticFieldDateSigned.md)
 - [Model.TemplateResponseDocumentStaticFieldDropdown](docs/TemplateResponseDocumentStaticFieldDropdown.md)
 - [Model.TemplateResponseDocumentStaticFieldHyperlink](docs/TemplateResponseDocumentStaticFieldHyperlink.md)
 - [Model.TemplateResponseDocumentStaticFieldInitials](docs/TemplateResponseDocumentStaticFieldInitials.md)
 - [Model.TemplateResponseDocumentStaticFieldRadio](docs/TemplateResponseDocumentStaticFieldRadio.md)
 - [Model.TemplateResponseDocumentStaticFieldSignature](docs/TemplateResponseDocumentStaticFieldSignature.md)
 - [Model.TemplateResponseDocumentStaticFieldText](docs/TemplateResponseDocumentStaticFieldText.md)
 - [Model.TemplateResponseFieldAvgTextLength](docs/TemplateResponseFieldAvgTextLength.md)
 - [Model.TemplateResponseSignerRole](docs/TemplateResponseSignerRole.md)
 - [Model.TemplateUpdateFilesRequest](docs/TemplateUpdateFilesRequest.md)
 - [Model.TemplateUpdateFilesResponse](docs/TemplateUpdateFilesResponse.md)
 - [Model.TemplateUpdateFilesResponseTemplate](docs/TemplateUpdateFilesResponseTemplate.md)
 - [Model.UnclaimedDraftCreateEmbeddedRequest](docs/UnclaimedDraftCreateEmbeddedRequest.md)
 - [Model.UnclaimedDraftCreateEmbeddedWithTemplateRequest](docs/UnclaimedDraftCreateEmbeddedWithTemplateRequest.md)
 - [Model.UnclaimedDraftCreateRequest](docs/UnclaimedDraftCreateRequest.md)
 - [Model.UnclaimedDraftCreateResponse](docs/UnclaimedDraftCreateResponse.md)
 - [Model.UnclaimedDraftEditAndResendRequest](docs/UnclaimedDraftEditAndResendRequest.md)
 - [Model.UnclaimedDraftResponse](docs/UnclaimedDraftResponse.md)
 - [Model.WarningResponse](docs/WarningResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: HTTP basic authentication

<a name="oauth2"></a>
### oauth2

- **Type**: Bearer Authentication

