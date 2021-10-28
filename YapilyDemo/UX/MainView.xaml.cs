using System;
using System.Diagnostics;
using Appmilla.Yapily.Api;
using Appmilla.Yapily.Client;
using Appmilla.Yapily.Model;
using Xamarin.Forms;

namespace YapilyDemo.UX
{
    public partial class MainView : ContentPage
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public MainView()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Username = "7b67086c-2f2d-4b03-9c4d-96d57bc294ac";
            Configuration.Password = "4c40bc5d-fb96-4d1e-9b33-be9684c1c20c";
            // Configure OAuth2 access token for authorization: tokenAuth
            //var token = "7b67086c-2f2d-4b03-9c4d-96d57bc294ac:4c40bc5d-fb96-4d1e-9b33-be9684c1c20c";
            //Configuration.ApiKey = Base64Encode(token);

            /*
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | __Mandatory__. The account Id of the user's bank account.
            var consent = consent_example;  // string | __Mandatory__. The `consent-token` containing the user's authorisation to make the request.
            var xYapilyApiVersion = xYapilyApiVersion_example;  // string | __Optional__. Determines the API version to use. Valid values are `1.0` or `2.0-ALPHA`. Defaults to `1.0` (optional) 
            var limit = 56;  // int? | __Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000. (optional) 
            */

            var yapilyApiVersion = "1.0";

            var institutionsApi = new InstitutionsApi();

            var applicationApi = new ApplicationApi();

            var usersApi = new ApplicationUsersApi();

            var accountsApi = new AccountsApi();
            
            try
            {
                //var refitApplicationApi = RestService.For<IApplication>();
                //var refitApplicationMe = await refitApplicationApi.GetApplicationMeUsingGETAsync();
                
                
                var me = applicationApi.GetApplicationMeUsingGET(yapilyApiVersion);
                Debug.WriteLine(me);

                var users = usersApi.GetUsersUsingGET(yapilyApiVersion, null);

                var institutions = institutionsApi.GetInstitutionsUsingGET(yapilyApiVersion);
                // Get account direct debits
                //ApiListResponseOfPaymentResponse result = apiInstance.GetAccountDirectDebitsUsingGET(accountId, consent, xYapilyApiVersion, limit);
                Debug.WriteLine(institutions);

                var institutionId = institutions.Data[0].Id;

                var myInstitution = institutionsApi.GetInstitutionUsingGET(institutionId, yapilyApiVersion);

                var authRequest = new AccountAuthorisationRequest()
                {
                    UserUuid = "f9817f34-6a2e-4186-ba6b-41c71ba0d123",
                    ApplicationUserId = "user-1299560",
                    //ApplicationUserId = "7b67086c-2f2d-4b03-9c4d-96d57bc294ac",
                    InstitutionId = institutionId,
                    Callback = "https://app.walldo.com/callback"
                    //Callback = "https://yapilydemo/callback/"
                };

                var authResponse = accountsApi.InitiateAccountRequestUsingPOST(
                    authRequest,
                    yapilyApiVersion,
                    string.Empty,
                    string.Empty,
                    string.Empty);

                Debug.WriteLine(authResponse);

            }
            catch (Exception exception)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountDirectDebitsUsingGET: " + exception.Message);
            }
        }
    }
}
